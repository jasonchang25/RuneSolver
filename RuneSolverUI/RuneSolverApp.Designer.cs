using System.Windows.Forms;

namespace RuneSolverUI
{
    partial class RuneSolverApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuneSolverApp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_saveLogin = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_expiry = new System.Windows.Forms.Label();
            this.lb_expiryDate = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.grp_Settings = new System.Windows.Forms.GroupBox();
            this.ddl_antiDeathTime = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddl_unstickCharTime = new System.Windows.Forms.ComboBox();
            this.lb_yukiKey = new System.Windows.Forms.Label();
            this.cb_enableYuki = new System.Windows.Forms.CheckBox();
            this.ddl_yukiKey = new System.Windows.Forms.ComboBox();
            this.lb_yuki = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cb_enableUnstickCharacter = new System.Windows.Forms.CheckBox();
            this.ddl_jumpKey = new System.Windows.Forms.ComboBox();
            this.lb_jumpKey = new System.Windows.Forms.Label();
            this.lb_unstick = new System.Windows.Forms.Label();
            this.cb_antiDeathLoop = new System.Windows.Forms.CheckBox();
            this.ddl_potionHakuKey = new System.Windows.Forms.ComboBox();
            this.lb_potionHakuKey = new System.Windows.Forms.Label();
            this.lb_antiDeathLoop = new System.Windows.Forms.Label();
            this.cb_openEliteBox = new System.Windows.Forms.CheckBox();
            this.ddl_eliteBoxKey = new System.Windows.Forms.ComboBox();
            this.lb_eliteBoxKey = new System.Windows.Forms.Label();
            this.lb_eliteBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb = new System.Windows.Forms.Label();
            this.btn_toggleOnOff = new System.Windows.Forms.Button();
            this.tt_antiDeathLoop = new System.Windows.Forms.ToolTip(this.components);
            this.tt_unstickCharacter = new System.Windows.Forms.ToolTip(this.components);
            this.lb_information = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_contact = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grp_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.label4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.cb_saveLogin);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.lb_expiry);
            this.groupBox1.Controls.Add(this.lb_expiryDate);
            this.groupBox1.Controls.Add(this.lb_Status);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.lb_username);
            this.groupBox1.Location = new System.Drawing.Point(382, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // cb_saveLogin
            // 
            this.cb_saveLogin.AutoSize = true;
            this.cb_saveLogin.BackColor = System.Drawing.Color.Transparent;
            this.cb_saveLogin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_saveLogin.Location = new System.Drawing.Point(81, 71);
            this.cb_saveLogin.Name = "cb_saveLogin";
            this.cb_saveLogin.Size = new System.Drawing.Size(117, 19);
            this.cb_saveLogin.TabIndex = 3;
            this.cb_saveLogin.Text = "Remember Login";
            this.cb_saveLogin.UseVisualStyleBackColor = false;
            this.cb_saveLogin.CheckedChanged += new System.EventHandler(this.cb_saveLogin_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(10, 131);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(206, 23);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_expiry
            // 
            this.lb_expiry.AutoSize = true;
            this.lb_expiry.BackColor = System.Drawing.Color.Transparent;
            this.lb_expiry.Location = new System.Drawing.Point(27, 111);
            this.lb_expiry.Name = "lb_expiry";
            this.lb_expiry.Size = new System.Drawing.Size(45, 15);
            this.lb_expiry.TabIndex = 2;
            this.lb_expiry.Text = "Expiry :";
            // 
            // lb_expiryDate
            // 
            this.lb_expiryDate.AutoSize = true;
            this.lb_expiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lb_expiryDate.Location = new System.Drawing.Point(78, 111);
            this.lb_expiryDate.Name = "lb_expiryDate";
            this.lb_expiryDate.Size = new System.Drawing.Size(12, 15);
            this.lb_expiryDate.TabIndex = 2;
            this.lb_expiryDate.Text = "-";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_Status.ForeColor = System.Drawing.Color.Red;
            this.lb_Status.Location = new System.Drawing.Point(78, 93);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(88, 15);
            this.lb_Status.TabIndex = 3;
            this.lb_Status.Text = "Not Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status :";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(78, 42);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(120, 23);
            this.tb_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password :";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(78, 16);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(120, 23);
            this.tb_username.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.Location = new System.Drawing.Point(6, 19);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(66, 15);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "Username :";
            // 
            // grp_Settings
            // 
            this.grp_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grp_Settings.Controls.Add(this.ddl_antiDeathTime);
            this.grp_Settings.Controls.Add(this.label8);
            this.grp_Settings.Controls.Add(this.label9);
            this.grp_Settings.Controls.Add(this.ddl_unstickCharTime);
            this.grp_Settings.Controls.Add(this.lb_yukiKey);
            this.grp_Settings.Controls.Add(this.cb_enableYuki);
            this.grp_Settings.Controls.Add(this.ddl_yukiKey);
            this.grp_Settings.Controls.Add(this.lb_yuki);
            this.grp_Settings.Controls.Add(this.pictureBox3);
            this.grp_Settings.Controls.Add(this.cb_enableUnstickCharacter);
            this.grp_Settings.Controls.Add(this.ddl_jumpKey);
            this.grp_Settings.Controls.Add(this.lb_jumpKey);
            this.grp_Settings.Controls.Add(this.lb_unstick);
            this.grp_Settings.Controls.Add(this.cb_antiDeathLoop);
            this.grp_Settings.Controls.Add(this.ddl_potionHakuKey);
            this.grp_Settings.Controls.Add(this.lb_potionHakuKey);
            this.grp_Settings.Controls.Add(this.lb_antiDeathLoop);
            this.grp_Settings.Controls.Add(this.cb_openEliteBox);
            this.grp_Settings.Controls.Add(this.ddl_eliteBoxKey);
            this.grp_Settings.Controls.Add(this.lb_eliteBoxKey);
            this.grp_Settings.Controls.Add(this.lb_eliteBox);
            this.grp_Settings.Controls.Add(this.pictureBox1);
            this.grp_Settings.Location = new System.Drawing.Point(12, 172);
            this.grp_Settings.Name = "grp_Settings";
            this.grp_Settings.Size = new System.Drawing.Size(592, 242);
            this.grp_Settings.TabIndex = 5;
            this.grp_Settings.TabStop = false;
            this.grp_Settings.Text = "Extra Features";
            // 
            // ddl_antiDeathTime
            // 
            this.ddl_antiDeathTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_antiDeathTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddl_antiDeathTime.FormattingEnabled = true;
            this.ddl_antiDeathTime.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120",
            "135",
            "150",
            "165",
            "180",
            "195",
            "210",
            "225",
            "240",
            "255",
            "270",
            "285",
            "300"});
            this.ddl_antiDeathTime.Location = new System.Drawing.Point(218, 117);
            this.ddl_antiDeathTime.Name = "ddl_antiDeathTime";
            this.ddl_antiDeathTime.Size = new System.Drawing.Size(60, 23);
            this.ddl_antiDeathTime.TabIndex = 2;
            this.ddl_antiDeathTime.SelectedIndexChanged += new System.EventHandler(this.ddl_antiDeathTime_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(284, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(284, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "sec";
            // 
            // ddl_unstickCharTime
            // 
            this.ddl_unstickCharTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_unstickCharTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddl_unstickCharTime.FormattingEnabled = true;
            this.ddl_unstickCharTime.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120",
            "135",
            "150",
            "165",
            "180",
            "195",
            "210",
            "225",
            "240",
            "255",
            "270",
            "285",
            "300"});
            this.ddl_unstickCharTime.Location = new System.Drawing.Point(218, 189);
            this.ddl_unstickCharTime.Name = "ddl_unstickCharTime";
            this.ddl_unstickCharTime.Size = new System.Drawing.Size(60, 23);
            this.ddl_unstickCharTime.TabIndex = 2;
            this.ddl_unstickCharTime.SelectedIndexChanged += new System.EventHandler(this.ddl_unstickCharTime_SelectedIndexChanged);
            // 
            // lb_yukiKey
            // 
            this.lb_yukiKey.AutoSize = true;
            this.lb_yukiKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_yukiKey.Location = new System.Drawing.Point(377, 40);
            this.lb_yukiKey.Name = "lb_yukiKey";
            this.lb_yukiKey.Size = new System.Drawing.Size(32, 15);
            this.lb_yukiKey.TabIndex = 1;
            this.lb_yukiKey.Text = "Key :";
            // 
            // cb_enableYuki
            // 
            this.cb_enableYuki.AutoSize = true;
            this.cb_enableYuki.BackColor = System.Drawing.Color.Transparent;
            this.cb_enableYuki.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_enableYuki.Location = new System.Drawing.Point(374, 69);
            this.cb_enableYuki.Name = "cb_enableYuki";
            this.cb_enableYuki.Size = new System.Drawing.Size(165, 19);
            this.cb_enableYuki.TabIndex = 3;
            this.cb_enableYuki.Text = "Enable Yuki cast after rune";
            this.cb_enableYuki.UseVisualStyleBackColor = false;
            this.cb_enableYuki.CheckedChanged += new System.EventHandler(this.cb_enableYuki_CheckedChanged);
            // 
            // ddl_yukiKey
            // 
            this.ddl_yukiKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_yukiKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddl_yukiKey.FormattingEnabled = true;
            this.ddl_yukiKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ddl_yukiKey.Location = new System.Drawing.Point(415, 37);
            this.ddl_yukiKey.Name = "ddl_yukiKey";
            this.ddl_yukiKey.Size = new System.Drawing.Size(97, 23);
            this.ddl_yukiKey.TabIndex = 2;
            this.ddl_yukiKey.SelectedIndexChanged += new System.EventHandler(this.ddl_yukiKey_SelectedIndexChanged);
            // 
            // lb_yuki
            // 
            this.lb_yuki.AutoSize = true;
            this.lb_yuki.BackColor = System.Drawing.Color.Transparent;
            this.lb_yuki.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_yuki.Location = new System.Drawing.Point(312, 19);
            this.lb_yuki.Name = "lb_yuki";
            this.lb_yuki.Size = new System.Drawing.Size(83, 15);
            this.lb_yuki.TabIndex = 1;
            this.lb_yuki.Text = "Yuki-musume";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(312, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // cb_enableUnstickCharacter
            // 
            this.cb_enableUnstickCharacter.AutoSize = true;
            this.cb_enableUnstickCharacter.BackColor = System.Drawing.Color.Transparent;
            this.cb_enableUnstickCharacter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_enableUnstickCharacter.Location = new System.Drawing.Point(12, 218);
            this.cb_enableUnstickCharacter.Name = "cb_enableUnstickCharacter";
            this.cb_enableUnstickCharacter.Size = new System.Drawing.Size(163, 19);
            this.cb_enableUnstickCharacter.TabIndex = 9;
            this.cb_enableUnstickCharacter.Text = "Enable Unstick Character :";
            this.cb_enableUnstickCharacter.UseVisualStyleBackColor = false;
            this.cb_enableUnstickCharacter.CheckedChanged += new System.EventHandler(this.cb_enableUnstickCharacter_CheckedChanged);
            // 
            // ddl_jumpKey
            // 
            this.ddl_jumpKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_jumpKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddl_jumpKey.FormattingEnabled = true;
            this.ddl_jumpKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "ALT"});
            this.ddl_jumpKey.Location = new System.Drawing.Point(115, 189);
            this.ddl_jumpKey.Name = "ddl_jumpKey";
            this.ddl_jumpKey.Size = new System.Drawing.Size(97, 23);
            this.ddl_jumpKey.TabIndex = 8;
            this.ddl_jumpKey.SelectedIndexChanged += new System.EventHandler(this.ddl_jumpKey_SelectedIndexChanged);
            // 
            // lb_jumpKey
            // 
            this.lb_jumpKey.AutoSize = true;
            this.lb_jumpKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_jumpKey.Location = new System.Drawing.Point(12, 192);
            this.lb_jumpKey.Name = "lb_jumpKey";
            this.lb_jumpKey.Size = new System.Drawing.Size(64, 15);
            this.lb_jumpKey.TabIndex = 1;
            this.lb_jumpKey.Text = "Jump Key :";
            // 
            // lb_unstick
            // 
            this.lb_unstick.AutoSize = true;
            this.lb_unstick.BackColor = System.Drawing.Color.Transparent;
            this.lb_unstick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_unstick.Location = new System.Drawing.Point(12, 171);
            this.lb_unstick.Name = "lb_unstick";
            this.lb_unstick.Size = new System.Drawing.Size(106, 15);
            this.lb_unstick.TabIndex = 1;
            this.lb_unstick.Text = "Unstick Character";
            this.tt_unstickCharacter.SetToolTip(this.lb_unstick, resources.GetString("lb_unstick.ToolTip"));
            // 
            // cb_antiDeathLoop
            // 
            this.cb_antiDeathLoop.AutoSize = true;
            this.cb_antiDeathLoop.BackColor = System.Drawing.Color.Transparent;
            this.cb_antiDeathLoop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_antiDeathLoop.Location = new System.Drawing.Point(9, 146);
            this.cb_antiDeathLoop.Name = "cb_antiDeathLoop";
            this.cb_antiDeathLoop.Size = new System.Drawing.Size(156, 19);
            this.cb_antiDeathLoop.TabIndex = 3;
            this.cb_antiDeathLoop.Text = "Enable Anti Death Loop :";
            this.cb_antiDeathLoop.UseVisualStyleBackColor = false;
            this.cb_antiDeathLoop.CheckedChanged += new System.EventHandler(this.cb_antiDeathLoop_CheckedChanged);
            // 
            // ddl_potionHakuKey
            // 
            this.ddl_potionHakuKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_potionHakuKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddl_potionHakuKey.FormattingEnabled = true;
            this.ddl_potionHakuKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ddl_potionHakuKey.Location = new System.Drawing.Point(112, 117);
            this.ddl_potionHakuKey.Name = "ddl_potionHakuKey";
            this.ddl_potionHakuKey.Size = new System.Drawing.Size(97, 23);
            this.ddl_potionHakuKey.TabIndex = 2;
            this.ddl_potionHakuKey.SelectedIndexChanged += new System.EventHandler(this.ddl_potionHakuKey_SelectedIndexChanged);
            // 
            // lb_potionHakuKey
            // 
            this.lb_potionHakuKey.AutoSize = true;
            this.lb_potionHakuKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_potionHakuKey.Location = new System.Drawing.Point(9, 120);
            this.lb_potionHakuKey.Name = "lb_potionHakuKey";
            this.lb_potionHakuKey.Size = new System.Drawing.Size(103, 15);
            this.lb_potionHakuKey.TabIndex = 1;
            this.lb_potionHakuKey.Text = "Potion/Haku Key :";
            // 
            // lb_antiDeathLoop
            // 
            this.lb_antiDeathLoop.AutoSize = true;
            this.lb_antiDeathLoop.BackColor = System.Drawing.Color.Transparent;
            this.lb_antiDeathLoop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_antiDeathLoop.Location = new System.Drawing.Point(9, 96);
            this.lb_antiDeathLoop.Name = "lb_antiDeathLoop";
            this.lb_antiDeathLoop.Size = new System.Drawing.Size(97, 15);
            this.lb_antiDeathLoop.TabIndex = 1;
            this.lb_antiDeathLoop.Text = "Anti Death Loop";
            this.tt_antiDeathLoop.SetToolTip(this.lb_antiDeathLoop, "Sometimes you will enter a death loop if the anti afk mob is sitting on the spawn" +
        " point. \nThis function will use a potion/cast Haku occasionally (30s) to prevent" +
        " this.");
            // 
            // cb_openEliteBox
            // 
            this.cb_openEliteBox.AutoSize = true;
            this.cb_openEliteBox.BackColor = System.Drawing.Color.Transparent;
            this.cb_openEliteBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_openEliteBox.Location = new System.Drawing.Point(68, 69);
            this.cb_openEliteBox.Name = "cb_openEliteBox";
            this.cb_openEliteBox.Size = new System.Drawing.Size(138, 19);
            this.cb_openEliteBox.TabIndex = 3;
            this.cb_openEliteBox.Text = "Auto Open Elite Box :";
            this.cb_openEliteBox.UseVisualStyleBackColor = false;
            this.cb_openEliteBox.CheckedChanged += new System.EventHandler(this.cb_openEliteBox_CheckedChanged);
            // 
            // ddl_eliteBoxKey
            // 
            this.ddl_eliteBoxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_eliteBoxKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddl_eliteBoxKey.FormattingEnabled = true;
            this.ddl_eliteBoxKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ddl_eliteBoxKey.Location = new System.Drawing.Point(109, 40);
            this.ddl_eliteBoxKey.Name = "ddl_eliteBoxKey";
            this.ddl_eliteBoxKey.Size = new System.Drawing.Size(97, 23);
            this.ddl_eliteBoxKey.TabIndex = 2;
            this.ddl_eliteBoxKey.SelectedIndexChanged += new System.EventHandler(this.ddl_eliteBoxKey_SelectedIndexChanged);
            // 
            // lb_eliteBoxKey
            // 
            this.lb_eliteBoxKey.AutoSize = true;
            this.lb_eliteBoxKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_eliteBoxKey.Location = new System.Drawing.Point(71, 43);
            this.lb_eliteBoxKey.Name = "lb_eliteBoxKey";
            this.lb_eliteBoxKey.Size = new System.Drawing.Size(32, 15);
            this.lb_eliteBoxKey.TabIndex = 1;
            this.lb_eliteBoxKey.Text = "Key :";
            // 
            // lb_eliteBox
            // 
            this.lb_eliteBox.AutoSize = true;
            this.lb_eliteBox.BackColor = System.Drawing.Color.Transparent;
            this.lb_eliteBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_eliteBox.Location = new System.Drawing.Point(9, 19);
            this.lb_eliteBox.Name = "lb_eliteBox";
            this.lb_eliteBox.Size = new System.Drawing.Size(109, 15);
            this.lb_eliteBox.TabIndex = 1;
            this.lb_eliteBox.Text = "Rare Treasure Box";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Location = new System.Drawing.Point(9, 183);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(106, 15);
            this.lb.TabIndex = 1;
            this.lb.Text = "Interval (seconds) :";
            // 
            // btn_toggleOnOff
            // 
            this.btn_toggleOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(188)))), ((int)(((byte)(18)))));
            this.btn_toggleOnOff.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_toggleOnOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_toggleOnOff.Location = new System.Drawing.Point(382, 416);
            this.btn_toggleOnOff.Name = "btn_toggleOnOff";
            this.btn_toggleOnOff.Size = new System.Drawing.Size(222, 40);
            this.btn_toggleOnOff.TabIndex = 10;
            this.btn_toggleOnOff.Text = "Start";
            this.btn_toggleOnOff.UseVisualStyleBackColor = false;
            this.btn_toggleOnOff.Click += new System.EventHandler(this.btn_toggleOnOff_Click);
            // 
            // tt_antiDeathLoop
            // 
            this.tt_antiDeathLoop.IsBalloon = true;
            this.tt_antiDeathLoop.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_antiDeathLoop.ToolTipTitle = "Anti Death Loop Explaination";
            // 
            // tt_unstickCharacter
            // 
            this.tt_unstickCharacter.IsBalloon = true;
            this.tt_unstickCharacter.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_unstickCharacter.ToolTipTitle = "Unstick Character Explaination";
            // 
            // lb_information
            // 
            this.lb_information.AutoSize = true;
            this.lb_information.BackColor = System.Drawing.Color.Transparent;
            this.lb_information.Location = new System.Drawing.Point(12, 45);
            this.lb_information.Name = "lb_information";
            this.lb_information.Size = new System.Drawing.Size(344, 75);
            this.lb_information.TabIndex = 1;
            this.lb_information.Text = resources.GetString("lb_information.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "RuneSolver";
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.BackColor = System.Drawing.Color.Transparent;
            this.lb_contact.ForeColor = System.Drawing.Color.Black;
            this.lb_contact.Location = new System.Drawing.Point(12, 434);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(272, 15);
            this.lb_contact.TabIndex = 2;
            this.lb_contact.Text = "Discord Psyren#7724 for any inquiries or questions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Controls.Add(this.label7);
            this.label4.Controls.Add(this.checkBox2);
            this.label4.Controls.Add(this.comboBox2);
            this.label4.Controls.Add(this.label6);
            this.label4.Controls.Add(this.pictureBox2);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(198, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rare Treasure Box";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(70, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Key :";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(67, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Auto Open Elite Box :";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.cb_openEliteBox_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox2.Location = new System.Drawing.Point(108, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ddl_eliteBoxKey_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rare Treasure Box";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox1.Location = new System.Drawing.Point(298, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ddl_eliteBoxKey_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(257, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Auto Open Elite Box :";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.cb_openEliteBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(260, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Key :";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120",
            "135",
            "150",
            "165",
            "180",
            "195",
            "210",
            "225",
            "240",
            "255",
            "270",
            "285",
            "300"});
            this.comboBox4.Location = new System.Drawing.Point(518, 37);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(60, 23);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.ddl_eliteBoxKey_SelectedIndexChanged);
            // 
            // RuneSolverApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(607, 459);
            this.Controls.Add(this.btn_toggleOnOff);
            this.Controls.Add(this.lb_contact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_Settings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RuneSolverApp";
            this.Text = "RuneSolver";
            this.Load += new System.EventHandler(this.RuneSolverApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_Settings.ResumeLayout(false);
            this.grp_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.label4.ResumeLayout(false);
            this.label4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_Status;
        private Label label2;
        private Label label1;
        private TextBox tb_username;
        private Label lb_username;
        private GroupBox grp_Settings;
        private Label lb_expiry;
        private Label lb_expiryDate;
        private Label lb_eliteBoxKey;
        private Label lb_eliteBox;
        private PictureBox pictureBox1;
        private CheckBox cb_openEliteBox;
        private ComboBox ddl_eliteBoxKey;
        private Label lb_antiDeathLoop;
        private ToolTip tt_antiDeathLoop;
        private Label lb_potionHakuKey;
        private ComboBox ddl_potionHakuKey;
        private Label lb_unstick;
        private CheckBox cb_antiDeathLoop;
        private ToolTip tt_unstickCharacter;
        private CheckBox cb_enableUnstickCharacter;
        private ComboBox ddl_jumpKey;
        private Label lb_jumpKey;
        private Button btn_login;
        private Button btn_toggleOnOff;
        private Label lb_information;
        private Label label3;
        private Label lb_contact;
        private TextBox tb_password;
        private CheckBox cb_saveLogin;
        private Label label9;
        private ComboBox ddl_unstickCharTime;
        private Label lb;
        private Label lb_yukiKey;
        private CheckBox cb_enableYuki;
        private ComboBox ddl_yukiKey;
        private Label lb_yuki;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label7;
        private CheckBox checkBox2;
        private ComboBox comboBox2;
        private Label label6;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Label label5;
        private Label _;
        private ComboBox comboBox4;
        private ComboBox ddl_antiDeathTime;
        private Label label8;
    }
}