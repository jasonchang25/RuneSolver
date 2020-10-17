using System;
using System.Windows.Forms;
using System.Drawing;
using RuneSolverUI.Repository;
using RuneSolverUI.Models;
using System.Globalization;

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
            }
            else
            {
                lb_Status.Text = "Connected";
                lb_Status.ForeColor = Color.Green;
                btn_login.Text = "Log Out";
                if (_user.Expiry > DateTime.Now)
                {
                    btn_toggleOnOff.Enabled = true;
                    btn_toggleOnOff.BackColor = Color.FromArgb(10, 188, 18);
                }
                else
                {
                    lb_expiryDate.Text = "Expired";
                    btn_toggleOnOff.Enabled = false;
                    btn_toggleOnOff.BackColor = Color.Gray;
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

        // Event Listener Methods

        private void RuneSolverApp_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository();
            _sessionRepository = new SessionRepository();
            _sessionId = Guid.NewGuid().ToString();
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
                    MessageBox.Show("Maximum session limit reached. Please log out of another session and try again", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _isRunning = true;
                    btn_toggleOnOff.BackColor = Color.Red;
                    btn_toggleOnOff.Text = "Stop";
                    btn_login.Enabled = false;
                }
            }
            else
            {
                _isRunning = false;
                btn_toggleOnOff.BackColor = Color.FromArgb(10, 188, 18);
                btn_toggleOnOff.Text = "Start";
                btn_login.Enabled = true;
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
