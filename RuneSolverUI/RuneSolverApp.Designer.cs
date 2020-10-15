using System.Drawing;
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
            this.lb_expiry = new System.Windows.Forms.Label();
            this.lb_expiryDate = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.grp_Settings = new System.Windows.Forms.GroupBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tt_antiDeathLoop = new System.Windows.Forms.ToolTip(this.components);
            this.tt_unstickCharacter = new System.Windows.Forms.ToolTip(this.components);
            this.lb_jumpKey = new System.Windows.Forms.Label();
            this.ddl_jumpKey = new System.Windows.Forms.ComboBox();
            this.cb_enableUnstickCharacter = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_toggleOnOff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.lb_expiry);
            this.groupBox1.Controls.Add(this.lb_expiryDate);
            this.groupBox1.Controls.Add(this.lb_Status);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lb_username);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lb_expiry
            // 
            this.lb_expiry.AutoSize = true;
            this.lb_expiry.BackColor = System.Drawing.Color.Transparent;
            this.lb_expiry.Location = new System.Drawing.Point(27, 88);
            this.lb_expiry.Name = "lb_expiry";
            this.lb_expiry.Size = new System.Drawing.Size(45, 15);
            this.lb_expiry.TabIndex = 2;
            this.lb_expiry.Text = "Expiry :";
            // 
            // lb_expiryDate
            // 
            this.lb_expiryDate.AutoSize = true;
            this.lb_expiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lb_expiryDate.Location = new System.Drawing.Point(78, 88);
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
            this.lb_Status.Location = new System.Drawing.Point(78, 69);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(88, 15);
            this.lb_Status.TabIndex = 3;
            this.lb_Status.Text = "Not Connected";
            this.lb_Status.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 1;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 2;
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
            this.lb_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // grp_Settings
            // 
            this.grp_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.grp_Settings.Location = new System.Drawing.Point(3, 148);
            this.grp_Settings.Name = "grp_Settings";
            this.grp_Settings.Size = new System.Drawing.Size(222, 254);
            this.grp_Settings.TabIndex = 5;
            this.grp_Settings.TabStop = false;
            this.grp_Settings.Text = "Extra Features";
            // 
            // lb_unstick
            // 
            this.lb_unstick.AutoSize = true;
            this.lb_unstick.BackColor = System.Drawing.Color.Transparent;
            this.lb_unstick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_unstick.Location = new System.Drawing.Point(6, 183);
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
            this.cb_antiDeathLoop.Location = new System.Drawing.Point(6, 151);
            this.cb_antiDeathLoop.Name = "cb_antiDeathLoop";
            this.cb_antiDeathLoop.Size = new System.Drawing.Size(156, 19);
            this.cb_antiDeathLoop.TabIndex = 3;
            this.cb_antiDeathLoop.Text = "Enable Anti Death Loop :";
            this.cb_antiDeathLoop.UseVisualStyleBackColor = false;
            // 
            // ddl_potionHakuKey
            // 
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
            "F12"});
            this.ddl_potionHakuKey.Location = new System.Drawing.Point(109, 122);
            this.ddl_potionHakuKey.Name = "ddl_potionHakuKey";
            this.ddl_potionHakuKey.Size = new System.Drawing.Size(97, 23);
            this.ddl_potionHakuKey.TabIndex = 2;
            // 
            // lb_potionHakuKey
            // 
            this.lb_potionHakuKey.AutoSize = true;
            this.lb_potionHakuKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_potionHakuKey.Location = new System.Drawing.Point(6, 125);
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
            this.lb_antiDeathLoop.Location = new System.Drawing.Point(6, 101);
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
            // 
            // ddl_eliteBoxKey
            // 
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
            "F12"});
            this.ddl_eliteBoxKey.Location = new System.Drawing.Point(109, 40);
            this.ddl_eliteBoxKey.Name = "ddl_eliteBoxKey";
            this.ddl_eliteBoxKey.Size = new System.Drawing.Size(97, 23);
            this.ddl_eliteBoxKey.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_toggleOnOff);
            this.panel1.Controls.Add(this.grp_Settings);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(360, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 449);
            this.panel1.TabIndex = 0;
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
            // lb_jumpKey
            // 
            this.lb_jumpKey.AutoSize = true;
            this.lb_jumpKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_jumpKey.Location = new System.Drawing.Point(6, 204);
            this.lb_jumpKey.Name = "lb_jumpKey";
            this.lb_jumpKey.Size = new System.Drawing.Size(64, 15);
            this.lb_jumpKey.TabIndex = 1;
            this.lb_jumpKey.Text = "Jump Key :";
            // 
            // ddl_jumpKey
            // 
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
            "alt"});
            this.ddl_jumpKey.Location = new System.Drawing.Point(109, 201);
            this.ddl_jumpKey.Name = "ddl_jumpKey";
            this.ddl_jumpKey.Size = new System.Drawing.Size(97, 23);
            this.ddl_jumpKey.TabIndex = 2;
            // 
            // cb_enableUnstickCharacter
            // 
            this.cb_enableUnstickCharacter.AutoSize = true;
            this.cb_enableUnstickCharacter.BackColor = System.Drawing.Color.Transparent;
            this.cb_enableUnstickCharacter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_enableUnstickCharacter.Location = new System.Drawing.Point(6, 230);
            this.cb_enableUnstickCharacter.Name = "cb_enableUnstickCharacter";
            this.cb_enableUnstickCharacter.Size = new System.Drawing.Size(163, 19);
            this.cb_enableUnstickCharacter.TabIndex = 3;
            this.cb_enableUnstickCharacter.Text = "Enable Unstick Character :";
            this.cb_enableUnstickCharacter.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(9, 106);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(206, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_toggleOnOff
            // 
            this.btn_toggleOnOff.Location = new System.Drawing.Point(3, 403);
            this.btn_toggleOnOff.Name = "btn_toggleOnOff";
            this.btn_toggleOnOff.Size = new System.Drawing.Size(222, 40);
            this.btn_toggleOnOff.TabIndex = 6;
            this.btn_toggleOnOff.Text = "Start";
            this.btn_toggleOnOff.UseVisualStyleBackColor = true;
            // 
            // RuneSolverApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(590, 443);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RuneSolverApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RuneSolverApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_Settings.ResumeLayout(false);
            this.grp_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_Status;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label lb_username;
        private GroupBox grp_Settings;
        private Panel panel1;
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
    }
}