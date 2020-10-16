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
            _userRepository = new UserRepository();
            _sessionRepository = new SessionRepository();
            checkLoginStatus();
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


        // Event Listener Methods
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RuneSolverApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lb_information_Click(object sender, EventArgs e)
        {

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
                _sessionId = Guid.NewGuid().ToString();
                _session = _sessionRepository.validateSession(_user, _sessionId, _session);
                if (_session == null)
                {
                    MessageBox.Show("Maximum session limit reached. Please log out of another session and try again", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //checkLoginStatus();
            }
        }
    }
}
