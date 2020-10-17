using System;
using System.Windows.Forms;
using System.Drawing;
using RuneSolverUI.Repository;
using RuneSolverUI.Models;
using System.Globalization;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.ComponentModel;

namespace RuneSolverUI
{
    public partial class RuneSolverApp : Form
    {
        protected string _sessionId;
        protected bool _isRunning = false;
        protected UserRepository _userRepository;
        protected SessionRepository _sessionRepository;
        protected Users _user;
        protected Sessions _session;
        private BackgroundWorker _worker = null;
        private LogWriter _logWriter;
        // Computer vision
        static protected Guid _projectId;
        static protected string _modelName;
        static protected string _ENDPOINT;
        static protected string _predictionKey;
        // Thread Safe
        private delegate void SafeCastHeal();
        private delegate void SafeOpenEliteBox();
        private delegate void SafeUnstickCharacter();
        public RuneSolverApp()
        {
            InitializeComponent();            
        }

        // Helper Methods
        private void checkLoginStatus()
        {             
            if (_user == null) 
            {
                lb_expiryDate.Text = "-";
                btn_toggleOnOff.Enabled = false;
                btn_toggleOnOff.BackColor = Color.Gray;
                lb_Status.Text = "Not Connected";
                lb_Status.ForeColor = Color.Red;
                btn_login.Text = "Login";
                _logWriter.LogWrite("User signed out");
            }
            else
            {
                lb_Status.Text = "Connected";
                lb_Status.ForeColor = Color.Green;
                btn_login.Text = "Log Out";
                if (_user.Expiry > DateTime.Now)
                {
                    lb_expiryDate.Text = _user.Expiry.ToShortDateString();
                    btn_toggleOnOff.Enabled = true;
                    btn_toggleOnOff.BackColor = Color.FromArgb(10, 188, 18);
                    _logWriter.LogWrite("User login successful");
                }
                else
                {
                    lb_expiryDate.Text = "Expired";
                    btn_toggleOnOff.Enabled = false;
                    btn_toggleOnOff.BackColor = Color.Gray;
                    _logWriter.LogWrite("User login failed user license expired");
                }
            }
        }

        private void LoadSettings()
        {
            tb_username.Text = Properties.Settings.Default.Username;
            tb_password.Text = Properties.Settings.Default.Password;
            cb_saveLogin.Checked = Properties.Settings.Default.RememberLogin;
            ddl_eliteBoxKey.SelectedItem = Properties.Settings.Default.EliteBoxKey;
            cb_openEliteBox.Checked = Properties.Settings.Default.EliteBoxActivated;
            ddl_potionHakuKey.SelectedItem = Properties.Settings.Default.AntiDeathKey;
            cb_antiDeathLoop.Checked = Properties.Settings.Default.AntiDeathActivated;
            ddl_jumpKey.SelectedItem = Properties.Settings.Default.JumpKey;
            cb_enableUnstickCharacter.Checked = Properties.Settings.Default.UnstickCharacterActivated;
        }

        private void Process()
        {            
            CustomVisionPredictionClient predictionApi = AuthenticatePrediction(_ENDPOINT, _predictionKey);
            var path = Directory.GetCurrentDirectory();
            var runeImage = "2.png";
            var timeTracker = 300000;
            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;            
            _worker.DoWork += new DoWorkEventHandler((state, args) =>
            {
                do
                {
                    try
                    {
                        if (_worker.CancellationPending)
                            break;

                        if (timeTracker == 0)
                        {
                            _sessionRepository.ExtendSession(_session);
                            timeTracker = 300000;
                        }

                        if (timeTracker % 30000 == 0)
                        {
                            if (cb_antiDeathLoop.Checked) CastHeal();
                        }
                        if (timeTracker % 60000 == 0)
                        {
                            if (cb_enableUnstickCharacter.Checked) UnstickCharacter();
                        }
                        if (timeTracker % 150000 == 0)
                        {
                            if (cb_openEliteBox.Checked) OpenEliteBox();
                        }

                        if (File.Exists(runeImage))
                        {
                            _logWriter.LogWrite("Rune Found, Solving Rune");
                            var solution = GetSolution(predictionApi, runeImage);
                            _logWriter.LogWrite(string.Join(",", solution.Select(s => s.TagName)));
                            SolveRune(solution);
                            _logWriter.LogWrite("Rune Solved");
                            File.Delete(runeImage);
                        }
                        timeTracker -= 5000;
                        Thread.Sleep(5000);
                    }
                    catch (Exception ex)
                    {
                        _logWriter.LogWrite(ex.Message);
                    }                   
                } while (true);
            });
            _worker.RunWorkerAsync();
        }

        private void CastHeal()
        {
            try
            {
                if (ddl_potionHakuKey.InvokeRequired)
                {
                    var d = new SafeCastHeal(CastHeal);
                    ddl_potionHakuKey.Invoke(d, new object[] { });
                }
                else
                {
                    _logWriter.LogWrite("Triggering Anti Death Action");
                    KeyInput.SendKey((KeyInput.DirectXKeyStrokes)Enum.Parse(typeof(KeyInput.DirectXKeyStrokes), String.Concat("DIK_", ddl_potionHakuKey.SelectedItem.ToString())), false, KeyInput.InputType.Keyboard);
                    Thread.Sleep(500);
                    KeyInput.SendKey((KeyInput.DirectXKeyStrokes)Enum.Parse(typeof(KeyInput.DirectXKeyStrokes), String.Concat("DIK_", ddl_potionHakuKey.SelectedItem.ToString())), true, KeyInput.InputType.Keyboard);
                }
            }
            catch (Exception ex)
            {
                _logWriter.LogWrite(ex.Message);
            }                        
        }

        private void UnstickCharacter()
        {
            try
            {
                if (ddl_jumpKey.InvokeRequired)
                {
                    var d = new SafeUnstickCharacter(UnstickCharacter);
                    ddl_jumpKey.Invoke(d, new object[] { });
                }
                else
                {
                    _logWriter.LogWrite("Unsticking Character");
                    KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_LEFTARROW, false, KeyInput.InputType.Keyboard);
                    Thread.Sleep(250);
                    KeyInput.SendKey((KeyInput.DirectXKeyStrokes)Enum.Parse(typeof(KeyInput.DirectXKeyStrokes), String.Concat("DIK_", ddl_jumpKey.SelectedItem.ToString())), false, KeyInput.InputType.Keyboard);
                    Thread.Sleep(500);
                    KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_LEFTARROW, true, KeyInput.InputType.Keyboard);
                    KeyInput.SendKey((KeyInput.DirectXKeyStrokes)Enum.Parse(typeof(KeyInput.DirectXKeyStrokes), String.Concat("DIK_", ddl_jumpKey.SelectedItem.ToString())), true, KeyInput.InputType.Keyboard);
                }
            }
            catch (Exception ex)
            {
                _logWriter.LogWrite(ex.Message);
            }                        
        }

        private void OpenEliteBox()
        {
            try
            {
                if (ddl_eliteBoxKey.InvokeRequired)
                {
                    var d = new SafeOpenEliteBox(OpenEliteBox);
                    ddl_eliteBoxKey.Invoke(d, new object[] { });
                }
                else
                {
                    _logWriter.LogWrite("Opening Elite Box");
                    for (var i = 0; i < 4; i++)
                    {
                        KeyInput.SendKey((KeyInput.DirectXKeyStrokes)Enum.Parse(typeof(KeyInput.DirectXKeyStrokes), String.Concat("DIK_", ddl_eliteBoxKey.SelectedItem.ToString())), false, KeyInput.InputType.Keyboard);
                        Thread.Sleep(250);
                    }
                }
            }
            catch (Exception ex)
            {
                _logWriter.LogWrite(ex.Message);
            }                 
        }

        private void SolveRune(List<PredictionModel> solution)
        {
            try
            {
                foreach (var key in solution)
                {
                    switch (key.TagName)
                    {
                        case "left":
                            KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_LEFTARROW, false, KeyInput.InputType.Keyboard);
                            break;
                        case "right":
                            KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_RIGHTARROW, false, KeyInput.InputType.Keyboard);
                            break;
                        case "down":
                            KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_DOWNARROW, false, KeyInput.InputType.Keyboard);
                            break;
                        case "up":
                            KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_UPARROW, false, KeyInput.InputType.Keyboard);
                            break;
                        default:
                            break;
                    }
                    Thread.Sleep(500);
                }
                KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_LEFTARROW, true, KeyInput.InputType.Keyboard);
                KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_RIGHTARROW, true, KeyInput.InputType.Keyboard);
                KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_DOWNARROW, true, KeyInput.InputType.Keyboard);
                KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_UPARROW, true, KeyInput.InputType.Keyboard);
            }
            catch (Exception ex)
            {
                _logWriter.LogWrite(ex.Message);
            }            
        }

        private CustomVisionPredictionClient AuthenticatePrediction(string endpoint, string predictionKey)
        {
            // Create a prediction endpoint, passing in the obtained prediction key
            CustomVisionPredictionClient predictionApi = new CustomVisionPredictionClient(new ApiKeyServiceClientCredentials(predictionKey))
            {
                Endpoint = endpoint
            };
            return predictionApi;
        }

        private List<PredictionModel> GetSolution(CustomVisionPredictionClient predictionApi, string imageFile)
        {
            // Make a prediction against the new project
            try
            {
                using (var stream = File.OpenRead(imageFile))
                {
                    var result = predictionApi.DetectImage(_projectId, _modelName, stream);
                    var solution = result.Predictions.Take(4).OrderBy(c => c.BoundingBox.Left).ToList();
                    return solution;
                }
            }
            catch (Exception ex)
            {
                _logWriter.LogWrite(ex.Message);
                return new List<PredictionModel>();
            }            
        }

        // Event Listener Methods
        private void RuneSolverApp_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository();
            _sessionRepository = new SessionRepository();
            _sessionId = Guid.NewGuid().ToString();
            // Add your Azure Custom Vision endpoint
            _projectId = Guid.Parse("e50b73f5-e383-4c0f-a2b3-63140dea92a8");
            _ENDPOINT = "https://runeclassifier-prediction.cognitiveservices.azure.com/";
            _predictionKey = "e587c896f1664f8dacb25ce70dde10d9";
            _modelName = "RuneSolver";
            _logWriter = new LogWriter();
            LoadSettings();
            checkLoginStatus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {           
            if (_user == null)
            {
                _user = _userRepository.VerifyLogin(tb_username.Text, tb_password.Text);
                if (_user != null)
                {
                    checkLoginStatus();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password.", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _user = null;
                _sessionRepository.RemoveSession(_session);
                checkLoginStatus();
            }
        }

        private void btn_toggleOnOff_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _session = _sessionRepository.ValidateSession(_user, _sessionId, _session);
                if (_session == null)
                {
                    _logWriter.LogWrite("Process failed. Maximum session limit reached.");
                    MessageBox.Show("Maximum session limit reached. Please log out of another session and try again", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _isRunning = true;
                    btn_toggleOnOff.BackColor = Color.Red;
                    btn_toggleOnOff.Text = "Stop";
                    btn_login.Enabled = false;
                    _logWriter.LogWrite("RuneSolver process started.");
                    Process();
                }
            }
            else
            {
                _isRunning = false;
                _worker.CancelAsync();
                btn_toggleOnOff.BackColor = Color.FromArgb(10, 188, 18);
                btn_toggleOnOff.Text = "Start";
                btn_login.Enabled = true;
                _logWriter.LogWrite("RuneSolver process stopped.");
            }            
        }

        private void cb_saveLogin_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberLogin = cb_saveLogin.Checked;
            if (cb_saveLogin.Checked)
            {
                Properties.Settings.Default.Username = tb_username.Text;
                Properties.Settings.Default.Password = tb_password.Text;
            }
            else
            {
                Properties.Settings.Default.Username = Properties.Settings.Default.Password = "";
            }
            Properties.Settings.Default.Save();
        }

        private void ddl_eliteBoxKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EliteBoxKey = ddl_eliteBoxKey.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void cb_openEliteBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EliteBoxActivated = cb_openEliteBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ddl_potionHakuKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AntiDeathKey = ddl_potionHakuKey.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }
        private void cb_antiDeathLoop_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AntiDeathActivated = cb_antiDeathLoop.Checked;
            Properties.Settings.Default.Save();
        }

        private void ddl_jumpKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.JumpKey = ddl_jumpKey.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void cb_enableUnstickCharacter_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UnstickCharacterActivated = cb_enableUnstickCharacter.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
