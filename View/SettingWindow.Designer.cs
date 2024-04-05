namespace robot_arm_automation.View
{
    partial class SettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPLCIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPLCDatabase = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxPLCValueSetting = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSettingAnnounce = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.txbStartNo = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.txbBitNo = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new XanderUI.XUIButton();
            this.pbxCompanyLogo = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbPLCIP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txbPLCDatabase);
            this.groupBox3.Location = new System.Drawing.Point(12, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 102);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Machine PLC Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "PLC IP:";
            // 
            // txbPLCIP
            // 
            this.txbPLCIP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPLCIP.Location = new System.Drawing.Point(69, 39);
            this.txbPLCIP.Name = "txbPLCIP";
            this.txbPLCIP.Size = new System.Drawing.Size(259, 27);
            this.txbPLCIP.TabIndex = 13;
            this.txbPLCIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPLCIP_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Database number:";
            // 
            // txbPLCDatabase
            // 
            this.txbPLCDatabase.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPLCDatabase.Location = new System.Drawing.Point(474, 39);
            this.txbPLCDatabase.Name = "txbPLCDatabase";
            this.txbPLCDatabase.Size = new System.Drawing.Size(52, 27);
            this.txbPLCDatabase.TabIndex = 14;
            this.txbPLCDatabase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPLCDatabase_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.cbxPLCValueSetting);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lb4);
            this.groupBox2.Controls.Add(this.txbStartNo);
            this.groupBox2.Controls.Add(this.lb5);
            this.groupBox2.Controls.Add(this.txbBitNo);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 140);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offset Settings";
            // 
            // cbxPLCValueSetting
            // 
            this.cbxPLCValueSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPLCValueSetting.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPLCValueSetting.FormattingEnabled = true;
            this.cbxPLCValueSetting.Location = new System.Drawing.Point(19, 31);
            this.cbxPLCValueSetting.Name = "cbxPLCValueSetting";
            this.cbxPLCValueSetting.Size = new System.Drawing.Size(482, 32);
            this.cbxPLCValueSetting.TabIndex = 8;
            this.cbxPLCValueSetting.SelectionChangeCommitted += new System.EventHandler(this.cbxPLCValueSetting_SelectionChangeCommitted);
            this.cbxPLCValueSetting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbxPLCValueSetting_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSettingAnnounce);
            this.panel1.Location = new System.Drawing.Point(19, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 48);
            this.panel1.TabIndex = 21;
            // 
            // lbSettingAnnounce
            // 
            this.lbSettingAnnounce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSettingAnnounce.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSettingAnnounce.ForeColor = System.Drawing.Color.Red;
            this.lbSettingAnnounce.Location = new System.Drawing.Point(0, 0);
            this.lbSettingAnnounce.Name = "lbSettingAnnounce";
            this.lbSettingAnnounce.Size = new System.Drawing.Size(486, 48);
            this.lbSettingAnnounce.TabIndex = 18;
            this.lbSettingAnnounce.Text = "...";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(526, 31);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(51, 16);
            this.lb4.TabIndex = 19;
            this.lb4.Text = "Offset:";
            // 
            // txbStartNo
            // 
            this.txbStartNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStartNo.Location = new System.Drawing.Point(529, 50);
            this.txbStartNo.Name = "txbStartNo";
            this.txbStartNo.Size = new System.Drawing.Size(81, 27);
            this.txbStartNo.TabIndex = 9;
            this.txbStartNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStartNo_KeyPress);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(616, 58);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(10, 16);
            this.lb5.TabIndex = 20;
            this.lb5.Text = ".";
            // 
            // txbBitNo
            // 
            this.txbBitNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBitNo.Location = new System.Drawing.Point(636, 50);
            this.txbBitNo.Name = "txbBitNo";
            this.txbBitNo.Size = new System.Drawing.Size(80, 27);
            this.txbBitNo.TabIndex = 10;
            this.txbBitNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBitNo_KeyPress);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.pbxCompanyLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(768, 65);
            this.panelHeader.TabIndex = 27;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.ButtonImage = global::robot_arm_automation.Properties.Resources.cancel;
            this.btnClose.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnClose.ButtonText = "Button";
            this.btnClose.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnClose.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.CornerRadius = 5;
            this.btnClose.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnClose.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnClose.Location = new System.Drawing.Point(708, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxCompanyLogo
            // 
            this.pbxCompanyLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbxCompanyLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxCompanyLogo.Image = global::robot_arm_automation.Properties.Resources.LogoTechlinkN;
            this.pbxCompanyLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbxCompanyLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxCompanyLogo.Name = "pbxCompanyLogo";
            this.pbxCompanyLogo.Size = new System.Drawing.Size(211, 63);
            this.pbxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCompanyLogo.TabIndex = 0;
            this.pbxCompanyLogo.TabStop = false;
            // 
            // SettingWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(768, 331);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "SettingWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingWindow_FormClosing);
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPLCIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPLCDatabase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxPLCValueSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSettingAnnounce;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txbStartNo;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txbBitNo;
        private System.Windows.Forms.Panel panelHeader;
        private XanderUI.XUIButton btnClose;
        private System.Windows.Forms.PictureBox pbxCompanyLogo;
    }
}