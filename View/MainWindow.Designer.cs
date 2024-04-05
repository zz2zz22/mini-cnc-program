namespace robot_arm_automation.View
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMainSetting = new XanderUI.XUIButton();
            this.btnResetAll = new XanderUI.XUIButton();
            this.btnClose = new XanderUI.XUIButton();
            this.btnShowAutomationStatus = new XanderUI.XUIButton();
            this.pbxCompanyLogo = new System.Windows.Forms.PictureBox();
            this.btnZLock = new XanderUI.XUIButton();
            this.btnYLock = new XanderUI.XUIButton();
            this.btnXLock = new XanderUI.XUIButton();
            this.panelRobotArmLocation = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpLocationValue = new System.Windows.Forms.TableLayoutPanel();
            this.lbZAxisValue = new System.Windows.Forms.Label();
            this.lbYAxisValue = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbXAxisValue = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCordinateShow = new System.Windows.Forms.PictureBox();
            this.btnSetZero = new XanderUI.XUIButton();
            this.tlpAutomation = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlManualAutomation = new System.Windows.Forms.TabControl();
            this.tabPageSetPoint = new System.Windows.Forms.TabPage();
            this.lbSP5 = new System.Windows.Forms.Label();
            this.lbSP2 = new System.Windows.Forms.Label();
            this.lbSP4 = new System.Windows.Forms.Label();
            this.lbSP3 = new System.Windows.Forms.Label();
            this.btnZ_Increase = new XanderUI.XUIButton();
            this.btnY_Increase = new XanderUI.XUIButton();
            this.btnX_Increase = new XanderUI.XUIButton();
            this.xuiSwitchMotorState = new XanderUI.XUISwitch();
            this.btnZ_Decrease = new XanderUI.XUIButton();
            this.btnY_Decrease = new XanderUI.XUIButton();
            this.btnX_Decrease = new XanderUI.XUIButton();
            this.btnSetNewORG = new XanderUI.XUIButton();
            this.btnReturnToORG = new XanderUI.XUIButton();
            this.btnSetPointNo2 = new XanderUI.XUIButton();
            this.btnSetPointNo1 = new XanderUI.XUIButton();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.txbNumberOfLayers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbMoveRange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbManualSpeed = new System.Windows.Forms.TextBox();
            this.lbSP1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSpinSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbZSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbYSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbXSpeed = new System.Windows.Forms.TextBox();
            this.lbUS1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelChangeRunState = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartMachine = new XanderUI.XUIButton();
            this.btnStopMachine = new XanderUI.XUIButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyLogo)).BeginInit();
            this.panelRobotArmLocation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpLocationValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCordinateShow)).BeginInit();
            this.tlpAutomation.SuspendLayout();
            this.tabControlManualAutomation.SuspendLayout();
            this.tabPageSetPoint.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanelChangeRunState.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnMainSetting);
            this.panelHeader.Controls.Add(this.btnResetAll);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.btnShowAutomationStatus);
            this.panelHeader.Controls.Add(this.pbxCompanyLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1006, 65);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnMainSetting
            // 
            this.btnMainSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainSetting.ButtonImage = global::robot_arm_automation.Properties.Resources.control;
            this.btnMainSetting.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnMainSetting.ButtonText = "Button";
            this.btnMainSetting.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnMainSetting.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMainSetting.CornerRadius = 5;
            this.btnMainSetting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMainSetting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMainSetting.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMainSetting.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnMainSetting.Location = new System.Drawing.Point(857, 3);
            this.btnMainSetting.Name = "btnMainSetting";
            this.btnMainSetting.Size = new System.Drawing.Size(56, 56);
            this.btnMainSetting.TabIndex = 4;
            this.btnMainSetting.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnMainSetting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMainSetting.Click += new System.EventHandler(this.btnMainSetting_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnResetAll.ButtonImage = global::robot_arm_automation.Properties.Resources.reset;
            this.btnResetAll.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnResetAll.ButtonText = "RESET ALL";
            this.btnResetAll.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnResetAll.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnResetAll.CornerRadius = 5;
            this.btnResetAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResetAll.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAll.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResetAll.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnResetAll.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnResetAll.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnResetAll.Location = new System.Drawing.Point(412, 0);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(162, 63);
            this.btnResetAll.TabIndex = 3;
            this.btnResetAll.TextColor = System.Drawing.Color.White;
            this.btnResetAll.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
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
            this.btnClose.Location = new System.Drawing.Point(946, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowAutomationStatus
            // 
            this.btnShowAutomationStatus.BackgroundColor = System.Drawing.Color.Red;
            this.btnShowAutomationStatus.ButtonImage = global::robot_arm_automation.Properties.Resources._switch;
            this.btnShowAutomationStatus.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnShowAutomationStatus.ButtonText = "Cur Status";
            this.btnShowAutomationStatus.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnShowAutomationStatus.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAutomationStatus.CornerRadius = 5;
            this.btnShowAutomationStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowAutomationStatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAutomationStatus.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowAutomationStatus.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnShowAutomationStatus.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAutomationStatus.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnShowAutomationStatus.Location = new System.Drawing.Point(198, 0);
            this.btnShowAutomationStatus.Name = "btnShowAutomationStatus";
            this.btnShowAutomationStatus.Size = new System.Drawing.Size(214, 63);
            this.btnShowAutomationStatus.TabIndex = 0;
            this.btnShowAutomationStatus.TextColor = System.Drawing.Color.White;
            this.btnShowAutomationStatus.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowAutomationStatus.Click += new System.EventHandler(this.btnShowAutomationStatus_Click);
            // 
            // pbxCompanyLogo
            // 
            this.pbxCompanyLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbxCompanyLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxCompanyLogo.Image = global::robot_arm_automation.Properties.Resources.LogoTechlinkN;
            this.pbxCompanyLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbxCompanyLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxCompanyLogo.Name = "pbxCompanyLogo";
            this.pbxCompanyLogo.Size = new System.Drawing.Size(198, 63);
            this.pbxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCompanyLogo.TabIndex = 0;
            this.pbxCompanyLogo.TabStop = false;
            // 
            // btnZLock
            // 
            this.btnZLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZLock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnZLock.ButtonImage = global::robot_arm_automation.Properties.Resources.z_lock;
            this.btnZLock.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnZLock.ButtonText = "Button";
            this.btnZLock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnZLock.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZLock.CornerRadius = 5;
            this.btnZLock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZLock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnZLock.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZLock.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnZLock.Location = new System.Drawing.Point(148, 368);
            this.btnZLock.Name = "btnZLock";
            this.btnZLock.Size = new System.Drawing.Size(56, 56);
            this.btnZLock.TabIndex = 7;
            this.btnZLock.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnZLock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZLock.Click += new System.EventHandler(this.btnZLock_Click);
            // 
            // btnYLock
            // 
            this.btnYLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYLock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYLock.ButtonImage = global::robot_arm_automation.Properties.Resources.y_lock;
            this.btnYLock.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnYLock.ButtonText = "Button";
            this.btnYLock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnYLock.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnYLock.CornerRadius = 5;
            this.btnYLock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnYLock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnYLock.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnYLock.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnYLock.Location = new System.Drawing.Point(82, 368);
            this.btnYLock.Name = "btnYLock";
            this.btnYLock.Size = new System.Drawing.Size(56, 56);
            this.btnYLock.TabIndex = 6;
            this.btnYLock.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnYLock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnYLock.Click += new System.EventHandler(this.btnYLock_Click);
            // 
            // btnXLock
            // 
            this.btnXLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXLock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXLock.ButtonImage = global::robot_arm_automation.Properties.Resources.x_lock;
            this.btnXLock.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXLock.ButtonText = "Button";
            this.btnXLock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnXLock.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXLock.CornerRadius = 5;
            this.btnXLock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXLock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnXLock.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXLock.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnXLock.Location = new System.Drawing.Point(15, 368);
            this.btnXLock.Name = "btnXLock";
            this.btnXLock.Size = new System.Drawing.Size(56, 56);
            this.btnXLock.TabIndex = 5;
            this.btnXLock.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnXLock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXLock.Click += new System.EventHandler(this.btnXLock_Click);
            // 
            // panelRobotArmLocation
            // 
            this.panelRobotArmLocation.Controls.Add(this.label13);
            this.panelRobotArmLocation.Controls.Add(this.label11);
            this.panelRobotArmLocation.Controls.Add(this.panel1);
            this.panelRobotArmLocation.Controls.Add(this.pictureBox3);
            this.panelRobotArmLocation.Controls.Add(this.pictureBox2);
            this.panelRobotArmLocation.Controls.Add(this.pictureBoxCordinateShow);
            this.panelRobotArmLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRobotArmLocation.Location = new System.Drawing.Point(0, 65);
            this.panelRobotArmLocation.Name = "panelRobotArmLocation";
            this.panelRobotArmLocation.Size = new System.Drawing.Size(521, 608);
            this.panelRobotArmLocation.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(474, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "X";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpLocationValue);
            this.panel1.Location = new System.Drawing.Point(79, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 100);
            this.panel1.TabIndex = 3;
            // 
            // tlpLocationValue
            // 
            this.tlpLocationValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tlpLocationValue.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpLocationValue.ColumnCount = 4;
            this.tlpLocationValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpLocationValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpLocationValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpLocationValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpLocationValue.Controls.Add(this.lbZAxisValue, 3, 1);
            this.tlpLocationValue.Controls.Add(this.lbYAxisValue, 2, 1);
            this.tlpLocationValue.Controls.Add(this.lb3, 0, 1);
            this.tlpLocationValue.Controls.Add(this.lb6, 3, 0);
            this.tlpLocationValue.Controls.Add(this.lb5, 2, 0);
            this.tlpLocationValue.Controls.Add(this.lb4, 1, 0);
            this.tlpLocationValue.Controls.Add(this.lb2, 0, 0);
            this.tlpLocationValue.Controls.Add(this.lbXAxisValue, 1, 1);
            this.tlpLocationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLocationValue.Location = new System.Drawing.Point(0, 0);
            this.tlpLocationValue.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLocationValue.Name = "tlpLocationValue";
            this.tlpLocationValue.RowCount = 2;
            this.tlpLocationValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLocationValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpLocationValue.Size = new System.Drawing.Size(436, 100);
            this.tlpLocationValue.TabIndex = 0;
            // 
            // lbZAxisValue
            // 
            this.lbZAxisValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbZAxisValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbZAxisValue.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZAxisValue.Location = new System.Drawing.Point(315, 31);
            this.lbZAxisValue.Name = "lbZAxisValue";
            this.lbZAxisValue.Size = new System.Drawing.Size(117, 68);
            this.lbZAxisValue.TabIndex = 7;
            this.lbZAxisValue.Text = "0";
            this.lbZAxisValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYAxisValue
            // 
            this.lbYAxisValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbYAxisValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbYAxisValue.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYAxisValue.Location = new System.Drawing.Point(194, 31);
            this.lbYAxisValue.Name = "lbYAxisValue";
            this.lbYAxisValue.Size = new System.Drawing.Size(114, 68);
            this.lbYAxisValue.TabIndex = 6;
            this.lbYAxisValue.Text = "0";
            this.lbYAxisValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(4, 31);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(62, 68);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "Value\r\n(mm)";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb6
            // 
            this.lb6.BackColor = System.Drawing.Color.Transparent;
            this.lb6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(315, 1);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(117, 29);
            this.lb6.TabIndex = 3;
            this.lb6.Text = "Z";
            this.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5
            // 
            this.lb5.BackColor = System.Drawing.Color.Transparent;
            this.lb5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(194, 1);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(114, 29);
            this.lb5.TabIndex = 2;
            this.lb5.Text = "Y";
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4
            // 
            this.lb4.BackColor = System.Drawing.Color.Transparent;
            this.lb4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(73, 1);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(114, 29);
            this.lb4.TabIndex = 1;
            this.lb4.Text = "X";
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(4, 1);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(62, 29);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Axis";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbXAxisValue
            // 
            this.lbXAxisValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbXAxisValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbXAxisValue.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXAxisValue.Location = new System.Drawing.Point(73, 31);
            this.lbXAxisValue.Name = "lbXAxisValue";
            this.lbXAxisValue.Size = new System.Drawing.Size(114, 68);
            this.lbXAxisValue.TabIndex = 5;
            this.lbXAxisValue.Text = "0";
            this.lbXAxisValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::robot_arm_automation.Properties.Resources.Y_Axis;
            this.pictureBox3.Location = new System.Drawing.Point(3, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 507);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::robot_arm_automation.Properties.Resources.X_Axis_drawio;
            this.pictureBox2.Location = new System.Drawing.Point(65, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(453, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxCordinateShow
            // 
            this.pictureBoxCordinateShow.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxCordinateShow.Location = new System.Drawing.Point(79, 59);
            this.pictureBoxCordinateShow.Name = "pictureBoxCordinateShow";
            this.pictureBoxCordinateShow.Size = new System.Drawing.Size(360, 440);
            this.pictureBoxCordinateShow.TabIndex = 0;
            this.pictureBoxCordinateShow.TabStop = false;
            this.pictureBoxCordinateShow.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnSetZero
            // 
            this.btnSetZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetZero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetZero.ButtonImage = global::robot_arm_automation.Properties.Resources.zero;
            this.btnSetZero.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSetZero.ButtonText = "Button";
            this.btnSetZero.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSetZero.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetZero.CornerRadius = 5;
            this.btnSetZero.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetZero.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetZero.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetZero.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnSetZero.Location = new System.Drawing.Point(404, 6);
            this.btnSetZero.Name = "btnSetZero";
            this.btnSetZero.Size = new System.Drawing.Size(56, 56);
            this.btnSetZero.TabIndex = 21;
            this.btnSetZero.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetZero.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetZero.Click += new System.EventHandler(this.btnSetZero_Click);
            // 
            // tlpAutomation
            // 
            this.tlpAutomation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpAutomation.ColumnCount = 1;
            this.tlpAutomation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAutomation.Controls.Add(this.tabControlManualAutomation, 0, 0);
            this.tlpAutomation.Controls.Add(this.tableLayoutPanelChangeRunState, 0, 1);
            this.tlpAutomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAutomation.Location = new System.Drawing.Point(521, 65);
            this.tlpAutomation.Name = "tlpAutomation";
            this.tlpAutomation.RowCount = 2;
            this.tlpAutomation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpAutomation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAutomation.Size = new System.Drawing.Size(485, 608);
            this.tlpAutomation.TabIndex = 3;
            // 
            // tabControlManualAutomation
            // 
            this.tabControlManualAutomation.Controls.Add(this.tabPageSetPoint);
            this.tabControlManualAutomation.Controls.Add(this.tabPageSetting);
            this.tabControlManualAutomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlManualAutomation.Location = new System.Drawing.Point(5, 5);
            this.tabControlManualAutomation.Name = "tabControlManualAutomation";
            this.tabControlManualAutomation.SelectedIndex = 0;
            this.tabControlManualAutomation.Size = new System.Drawing.Size(475, 475);
            this.tabControlManualAutomation.TabIndex = 1;
            // 
            // tabPageSetPoint
            // 
            this.tabPageSetPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageSetPoint.Controls.Add(this.lbSP5);
            this.tabPageSetPoint.Controls.Add(this.btnSetZero);
            this.tabPageSetPoint.Controls.Add(this.btnZLock);
            this.tabPageSetPoint.Controls.Add(this.lbSP2);
            this.tabPageSetPoint.Controls.Add(this.btnYLock);
            this.tabPageSetPoint.Controls.Add(this.lbSP4);
            this.tabPageSetPoint.Controls.Add(this.btnXLock);
            this.tabPageSetPoint.Controls.Add(this.lbSP3);
            this.tabPageSetPoint.Controls.Add(this.btnZ_Increase);
            this.tabPageSetPoint.Controls.Add(this.btnY_Increase);
            this.tabPageSetPoint.Controls.Add(this.btnX_Increase);
            this.tabPageSetPoint.Controls.Add(this.xuiSwitchMotorState);
            this.tabPageSetPoint.Controls.Add(this.btnZ_Decrease);
            this.tabPageSetPoint.Controls.Add(this.btnY_Decrease);
            this.tabPageSetPoint.Controls.Add(this.btnX_Decrease);
            this.tabPageSetPoint.Controls.Add(this.btnSetNewORG);
            this.tabPageSetPoint.Controls.Add(this.btnReturnToORG);
            this.tabPageSetPoint.Controls.Add(this.btnSetPointNo2);
            this.tabPageSetPoint.Controls.Add(this.btnSetPointNo1);
            this.tabPageSetPoint.Location = new System.Drawing.Point(4, 32);
            this.tabPageSetPoint.Name = "tabPageSetPoint";
            this.tabPageSetPoint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetPoint.Size = new System.Drawing.Size(467, 439);
            this.tabPageSetPoint.TabIndex = 1;
            this.tabPageSetPoint.Text = "Set Point / ORG";
            // 
            // lbSP5
            // 
            this.lbSP5.AutoSize = true;
            this.lbSP5.Location = new System.Drawing.Point(11, 342);
            this.lbSP5.Name = "lbSP5";
            this.lbSP5.Size = new System.Drawing.Size(87, 23);
            this.lbSP5.TabIndex = 22;
            this.lbSP5.Text = "Axis lock:";
            // 
            // lbSP2
            // 
            this.lbSP2.AutoSize = true;
            this.lbSP2.Location = new System.Drawing.Point(11, 19);
            this.lbSP2.Name = "lbSP2";
            this.lbSP2.Size = new System.Drawing.Size(127, 23);
            this.lbSP2.TabIndex = 16;
            this.lbSP2.Text = "Toggle motor:";
            // 
            // lbSP4
            // 
            this.lbSP4.AutoSize = true;
            this.lbSP4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSP4.Location = new System.Drawing.Point(302, 18);
            this.lbSP4.Name = "lbSP4";
            this.lbSP4.Size = new System.Drawing.Size(38, 24);
            this.lbSP4.TabIndex = 18;
            this.lbSP4.Text = "ON";
            // 
            // lbSP3
            // 
            this.lbSP3.AutoSize = true;
            this.lbSP3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSP3.Location = new System.Drawing.Point(144, 18);
            this.lbSP3.Name = "lbSP3";
            this.lbSP3.Size = new System.Drawing.Size(42, 24);
            this.lbSP3.TabIndex = 17;
            this.lbSP3.Text = "OFF";
            // 
            // btnZ_Increase
            // 
            this.btnZ_Increase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZ_Increase.BackgroundColor = System.Drawing.Color.Lime;
            this.btnZ_Increase.ButtonImage = global::robot_arm_automation.Properties.Resources.z_increase;
            this.btnZ_Increase.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnZ_Increase.ButtonText = "Button";
            this.btnZ_Increase.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnZ_Increase.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZ_Increase.CornerRadius = 5;
            this.btnZ_Increase.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZ_Increase.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnZ_Increase.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZ_Increase.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnZ_Increase.Location = new System.Drawing.Point(122, 245);
            this.btnZ_Increase.Name = "btnZ_Increase";
            this.btnZ_Increase.Size = new System.Drawing.Size(80, 80);
            this.btnZ_Increase.TabIndex = 20;
            this.btnZ_Increase.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnZ_Increase.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZ_Increase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZ_Increase_MouseDown);
            this.btnZ_Increase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZ_Increase_MouseUp);
            // 
            // btnY_Increase
            // 
            this.btnY_Increase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnY_Increase.BackgroundColor = System.Drawing.Color.Lime;
            this.btnY_Increase.ButtonImage = global::robot_arm_automation.Properties.Resources.y_increase;
            this.btnY_Increase.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnY_Increase.ButtonText = "Button";
            this.btnY_Increase.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnY_Increase.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnY_Increase.CornerRadius = 5;
            this.btnY_Increase.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnY_Increase.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnY_Increase.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnY_Increase.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnY_Increase.Location = new System.Drawing.Point(122, 159);
            this.btnY_Increase.Name = "btnY_Increase";
            this.btnY_Increase.Size = new System.Drawing.Size(80, 80);
            this.btnY_Increase.TabIndex = 19;
            this.btnY_Increase.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnY_Increase.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnY_Increase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnY_Increase_MouseDown);
            this.btnY_Increase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnY_Increase_MouseUp);
            // 
            // btnX_Increase
            // 
            this.btnX_Increase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX_Increase.BackgroundColor = System.Drawing.Color.Lime;
            this.btnX_Increase.ButtonImage = global::robot_arm_automation.Properties.Resources.x_increase;
            this.btnX_Increase.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnX_Increase.ButtonText = "Button";
            this.btnX_Increase.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnX_Increase.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnX_Increase.CornerRadius = 5;
            this.btnX_Increase.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnX_Increase.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnX_Increase.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnX_Increase.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnX_Increase.Location = new System.Drawing.Point(122, 73);
            this.btnX_Increase.Name = "btnX_Increase";
            this.btnX_Increase.Size = new System.Drawing.Size(80, 80);
            this.btnX_Increase.TabIndex = 18;
            this.btnX_Increase.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnX_Increase.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnX_Increase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnX_Increase_MouseDown);
            this.btnX_Increase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnX_Increase_MouseUp);
            // 
            // xuiSwitchMotorState
            // 
            this.xuiSwitchMotorState.BackColor = System.Drawing.Color.Transparent;
            this.xuiSwitchMotorState.HandleOffColor = System.Drawing.Color.Gray;
            this.xuiSwitchMotorState.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xuiSwitchMotorState.Location = new System.Drawing.Point(189, 6);
            this.xuiSwitchMotorState.Name = "xuiSwitchMotorState";
            this.xuiSwitchMotorState.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xuiSwitchMotorState.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xuiSwitchMotorState.Size = new System.Drawing.Size(107, 49);
            this.xuiSwitchMotorState.SwitchState = XanderUI.XUISwitch.State.Off;
            this.xuiSwitchMotorState.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.xuiSwitchMotorState.TabIndex = 15;
            this.xuiSwitchMotorState.Text = "xuiSwitch1";
            this.xuiSwitchMotorState.SwitchStateChanged += new System.EventHandler(this.xuiSwitchMotorState_SwitchStateChanged);
            // 
            // btnZ_Decrease
            // 
            this.btnZ_Decrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZ_Decrease.BackgroundColor = System.Drawing.Color.Lime;
            this.btnZ_Decrease.ButtonImage = global::robot_arm_automation.Properties.Resources.z_decrease;
            this.btnZ_Decrease.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnZ_Decrease.ButtonText = "Button";
            this.btnZ_Decrease.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnZ_Decrease.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZ_Decrease.CornerRadius = 5;
            this.btnZ_Decrease.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZ_Decrease.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnZ_Decrease.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnZ_Decrease.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnZ_Decrease.Location = new System.Drawing.Point(15, 245);
            this.btnZ_Decrease.Name = "btnZ_Decrease";
            this.btnZ_Decrease.Size = new System.Drawing.Size(80, 80);
            this.btnZ_Decrease.TabIndex = 17;
            this.btnZ_Decrease.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnZ_Decrease.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnZ_Decrease.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZ_Decrease_MouseDown);
            this.btnZ_Decrease.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZ_Decrease_MouseUp);
            // 
            // btnY_Decrease
            // 
            this.btnY_Decrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnY_Decrease.BackgroundColor = System.Drawing.Color.Lime;
            this.btnY_Decrease.ButtonImage = global::robot_arm_automation.Properties.Resources.y_decrease;
            this.btnY_Decrease.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnY_Decrease.ButtonText = "Button";
            this.btnY_Decrease.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnY_Decrease.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnY_Decrease.CornerRadius = 5;
            this.btnY_Decrease.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnY_Decrease.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnY_Decrease.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnY_Decrease.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnY_Decrease.Location = new System.Drawing.Point(15, 159);
            this.btnY_Decrease.Name = "btnY_Decrease";
            this.btnY_Decrease.Size = new System.Drawing.Size(80, 80);
            this.btnY_Decrease.TabIndex = 16;
            this.btnY_Decrease.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnY_Decrease.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnY_Decrease.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnY_Decrease_MouseDown);
            this.btnY_Decrease.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnY_Decrease_MouseUp);
            // 
            // btnX_Decrease
            // 
            this.btnX_Decrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX_Decrease.BackgroundColor = System.Drawing.Color.Lime;
            this.btnX_Decrease.ButtonImage = global::robot_arm_automation.Properties.Resources.x_decrease;
            this.btnX_Decrease.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnX_Decrease.ButtonText = "Button";
            this.btnX_Decrease.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnX_Decrease.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnX_Decrease.CornerRadius = 5;
            this.btnX_Decrease.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnX_Decrease.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnX_Decrease.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnX_Decrease.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnX_Decrease.Location = new System.Drawing.Point(15, 73);
            this.btnX_Decrease.Name = "btnX_Decrease";
            this.btnX_Decrease.Size = new System.Drawing.Size(80, 80);
            this.btnX_Decrease.TabIndex = 15;
            this.btnX_Decrease.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnX_Decrease.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnX_Decrease.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnX_Decrease_MouseDown);
            this.btnX_Decrease.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnX_Decrease_MouseUp);
            // 
            // btnSetNewORG
            // 
            this.btnSetNewORG.BackgroundColor = System.Drawing.Color.Lime;
            this.btnSetNewORG.ButtonImage = global::robot_arm_automation.Properties.Resources.update_1;
            this.btnSetNewORG.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSetNewORG.ButtonText = "Set new origin";
            this.btnSetNewORG.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSetNewORG.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetNewORG.CornerRadius = 5;
            this.btnSetNewORG.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetNewORG.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetNewORG.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetNewORG.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetNewORG.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSetNewORG.Location = new System.Drawing.Point(239, 331);
            this.btnSetNewORG.Name = "btnSetNewORG";
            this.btnSetNewORG.Size = new System.Drawing.Size(221, 57);
            this.btnSetNewORG.TabIndex = 14;
            this.btnSetNewORG.TextColor = System.Drawing.Color.Black;
            this.btnSetNewORG.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetNewORG.Click += new System.EventHandler(this.btnSetNewORG_Click);
            // 
            // btnReturnToORG
            // 
            this.btnReturnToORG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReturnToORG.ButtonImage = global::robot_arm_automation.Properties.Resources.arrow;
            this.btnReturnToORG.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnReturnToORG.ButtonText = "Return to origin";
            this.btnReturnToORG.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnReturnToORG.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnToORG.CornerRadius = 5;
            this.btnReturnToORG.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToORG.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReturnToORG.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnReturnToORG.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnToORG.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnReturnToORG.Location = new System.Drawing.Point(239, 268);
            this.btnReturnToORG.Name = "btnReturnToORG";
            this.btnReturnToORG.Size = new System.Drawing.Size(223, 57);
            this.btnReturnToORG.TabIndex = 13;
            this.btnReturnToORG.TextColor = System.Drawing.Color.Black;
            this.btnReturnToORG.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReturnToORG.Click += new System.EventHandler(this.btnReturnToORG_Click);
            // 
            // btnSetPointNo2
            // 
            this.btnSetPointNo2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetPointNo2.ButtonImage = global::robot_arm_automation.Properties.Resources.bottom_right;
            this.btnSetPointNo2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSetPointNo2.ButtonText = "Set point #2";
            this.btnSetPointNo2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSetPointNo2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetPointNo2.CornerRadius = 5;
            this.btnSetPointNo2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPointNo2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetPointNo2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetPointNo2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetPointNo2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSetPointNo2.Location = new System.Drawing.Point(238, 159);
            this.btnSetPointNo2.Name = "btnSetPointNo2";
            this.btnSetPointNo2.Size = new System.Drawing.Size(223, 57);
            this.btnSetPointNo2.TabIndex = 12;
            this.btnSetPointNo2.TextColor = System.Drawing.Color.Black;
            this.btnSetPointNo2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetPointNo2.Click += new System.EventHandler(this.btnSetPointNo2_Click);
            // 
            // btnSetPointNo1
            // 
            this.btnSetPointNo1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetPointNo1.ButtonImage = global::robot_arm_automation.Properties.Resources.left_corner;
            this.btnSetPointNo1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSetPointNo1.ButtonText = "Set point #1";
            this.btnSetPointNo1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSetPointNo1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetPointNo1.CornerRadius = 5;
            this.btnSetPointNo1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPointNo1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetPointNo1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetPointNo1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSetPointNo1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSetPointNo1.Location = new System.Drawing.Point(239, 96);
            this.btnSetPointNo1.Name = "btnSetPointNo1";
            this.btnSetPointNo1.Size = new System.Drawing.Size(223, 57);
            this.btnSetPointNo1.TabIndex = 11;
            this.btnSetPointNo1.TextColor = System.Drawing.Color.Black;
            this.btnSetPointNo1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetPointNo1.Click += new System.EventHandler(this.btnSetPointNo1_Click);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageSetting.Controls.Add(this.txbNumberOfLayers);
            this.tabPageSetting.Controls.Add(this.label12);
            this.tabPageSetting.Controls.Add(this.label10);
            this.tabPageSetting.Controls.Add(this.txbMoveRange);
            this.tabPageSetting.Controls.Add(this.label9);
            this.tabPageSetting.Controls.Add(this.label1);
            this.tabPageSetting.Controls.Add(this.txbManualSpeed);
            this.tabPageSetting.Controls.Add(this.lbSP1);
            this.tabPageSetting.Controls.Add(this.label8);
            this.tabPageSetting.Controls.Add(this.txbSpinSpeed);
            this.tabPageSetting.Controls.Add(this.label7);
            this.tabPageSetting.Controls.Add(this.label6);
            this.tabPageSetting.Controls.Add(this.label5);
            this.tabPageSetting.Controls.Add(this.label4);
            this.tabPageSetting.Controls.Add(this.txbZSpeed);
            this.tabPageSetting.Controls.Add(this.label3);
            this.tabPageSetting.Controls.Add(this.txbYSpeed);
            this.tabPageSetting.Controls.Add(this.label2);
            this.tabPageSetting.Controls.Add(this.txbXSpeed);
            this.tabPageSetting.Controls.Add(this.lbUS1);
            this.tabPageSetting.Controls.Add(this.pictureBox5);
            this.tabPageSetting.Controls.Add(this.pictureBox4);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 25);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Size = new System.Drawing.Size(467, 446);
            this.tabPageSetting.TabIndex = 2;
            this.tabPageSetting.Text = "User Setting";
            // 
            // txbNumberOfLayers
            // 
            this.txbNumberOfLayers.Location = new System.Drawing.Point(229, 290);
            this.txbNumberOfLayers.Name = "txbNumberOfLayers";
            this.txbNumberOfLayers.Size = new System.Drawing.Size(119, 30);
            this.txbNumberOfLayers.TabIndex = 22;
            this.txbNumberOfLayers.Text = "0";
            this.txbNumberOfLayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNumberOfLayers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNumberOfLayers_KeyDown);
            this.txbNumberOfLayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumberOfLayers_KeyPress);
            this.txbNumberOfLayers.Leave += new System.EventHandler(this.txbNumberOfLayers_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(225, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Number of layers (L2):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "(mm)";
            // 
            // txbMoveRange
            // 
            this.txbMoveRange.Location = new System.Drawing.Point(7, 290);
            this.txbMoveRange.Name = "txbMoveRange";
            this.txbMoveRange.Size = new System.Drawing.Size(119, 30);
            this.txbMoveRange.TabIndex = 18;
            this.txbMoveRange.Text = "0.0";
            this.txbMoveRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMoveRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMoveRange_KeyDown);
            this.txbMoveRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoveRange_KeyPress);
            this.txbMoveRange.Leave += new System.EventHandler(this.txbMoveRange_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Move range (L1):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "(mm/s)";
            // 
            // txbManualSpeed
            // 
            this.txbManualSpeed.Location = new System.Drawing.Point(136, 16);
            this.txbManualSpeed.Name = "txbManualSpeed";
            this.txbManualSpeed.Size = new System.Drawing.Size(99, 30);
            this.txbManualSpeed.TabIndex = 3;
            this.txbManualSpeed.Text = "0.0";
            this.txbManualSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbManualSpeed_KeyDown);
            this.txbManualSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbManualSpeed_KeyPress);
            this.txbManualSpeed.Leave += new System.EventHandler(this.txbManualSpeed_Leave);
            // 
            // lbSP1
            // 
            this.lbSP1.AutoSize = true;
            this.lbSP1.Location = new System.Drawing.Point(3, 20);
            this.lbSP1.Name = "lbSP1";
            this.lbSP1.Size = new System.Drawing.Size(129, 23);
            this.lbSP1.TabIndex = 2;
            this.lbSP1.Text = "Manual speed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "(mm/s)";
            // 
            // txbSpinSpeed
            // 
            this.txbSpinSpeed.Location = new System.Drawing.Point(169, 215);
            this.txbSpinSpeed.Name = "txbSpinSpeed";
            this.txbSpinSpeed.Size = new System.Drawing.Size(119, 30);
            this.txbSpinSpeed.TabIndex = 14;
            this.txbSpinSpeed.Text = "0.0";
            this.txbSpinSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSpinSpeed_KeyDown);
            this.txbSpinSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSpinSpeed_KeyPress);
            this.txbSpinSpeed.Leave += new System.EventHandler(this.txbSpinSpeed_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Spin motor speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "(mm/s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "(mm/s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "(mm/s)";
            // 
            // txbZSpeed
            // 
            this.txbZSpeed.Location = new System.Drawing.Point(89, 165);
            this.txbZSpeed.Name = "txbZSpeed";
            this.txbZSpeed.Size = new System.Drawing.Size(119, 30);
            this.txbZSpeed.TabIndex = 9;
            this.txbZSpeed.Text = "0.0";
            this.txbZSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbZSpeed_KeyDown);
            this.txbZSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbZSpeed_KeyPress);
            this.txbZSpeed.Leave += new System.EventHandler(this.txbZSpeed_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z speed:";
            // 
            // txbYSpeed
            // 
            this.txbYSpeed.Location = new System.Drawing.Point(89, 117);
            this.txbYSpeed.Name = "txbYSpeed";
            this.txbYSpeed.Size = new System.Drawing.Size(119, 30);
            this.txbYSpeed.TabIndex = 7;
            this.txbYSpeed.Text = "0.0";
            this.txbYSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbYSpeed_KeyDown);
            this.txbYSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbYSpeed_KeyPress);
            this.txbYSpeed.Leave += new System.EventHandler(this.txbYSpeed_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y speed:";
            // 
            // txbXSpeed
            // 
            this.txbXSpeed.Location = new System.Drawing.Point(89, 71);
            this.txbXSpeed.Name = "txbXSpeed";
            this.txbXSpeed.Size = new System.Drawing.Size(119, 30);
            this.txbXSpeed.TabIndex = 5;
            this.txbXSpeed.Text = "0.0";
            this.txbXSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbXSpeed_KeyDown);
            this.txbXSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbXSpeed_KeyPress);
            this.txbXSpeed.Leave += new System.EventHandler(this.txbXSpeed_Leave);
            // 
            // lbUS1
            // 
            this.lbUS1.AutoSize = true;
            this.lbUS1.Location = new System.Drawing.Point(3, 71);
            this.lbUS1.Name = "lbUS1";
            this.lbUS1.Size = new System.Drawing.Size(80, 23);
            this.lbUS1.TabIndex = 4;
            this.lbUS1.Text = "X speed:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = global::robot_arm_automation.Properties.Resources.number_of_layers_drawio;
            this.pictureBox5.Location = new System.Drawing.Point(229, 326);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(187, 96);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::robot_arm_automation.Properties.Resources.move_range_drawio;
            this.pictureBox4.Location = new System.Drawing.Point(7, 326);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(179, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // tableLayoutPanelChangeRunState
            // 
            this.tableLayoutPanelChangeRunState.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelChangeRunState.ColumnCount = 2;
            this.tableLayoutPanelChangeRunState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChangeRunState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChangeRunState.Controls.Add(this.btnStartMachine, 0, 0);
            this.tableLayoutPanelChangeRunState.Controls.Add(this.btnStopMachine, 1, 0);
            this.tableLayoutPanelChangeRunState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChangeRunState.Location = new System.Drawing.Point(5, 488);
            this.tableLayoutPanelChangeRunState.Name = "tableLayoutPanelChangeRunState";
            this.tableLayoutPanelChangeRunState.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelChangeRunState.RowCount = 1;
            this.tableLayoutPanelChangeRunState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChangeRunState.Size = new System.Drawing.Size(475, 115);
            this.tableLayoutPanelChangeRunState.TabIndex = 2;
            // 
            // btnStartMachine
            // 
            this.btnStartMachine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartMachine.ButtonImage = global::robot_arm_automation.Properties.Resources.start_button;
            this.btnStartMachine.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnStartMachine.ButtonText = "Button";
            this.btnStartMachine.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnStartMachine.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStartMachine.CornerRadius = 5;
            this.btnStartMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartMachine.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStartMachine.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnStartMachine.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStartMachine.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnStartMachine.Location = new System.Drawing.Point(11, 11);
            this.btnStartMachine.Name = "btnStartMachine";
            this.btnStartMachine.Padding = new System.Windows.Forms.Padding(10);
            this.btnStartMachine.Size = new System.Drawing.Size(222, 93);
            this.btnStartMachine.TabIndex = 1;
            this.btnStartMachine.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnStartMachine.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStartMachine.Click += new System.EventHandler(this.btnStartMachine_Click);
            // 
            // btnStopMachine
            // 
            this.btnStopMachine.BackgroundColor = System.Drawing.Color.Red;
            this.btnStopMachine.ButtonImage = global::robot_arm_automation.Properties.Resources.stop;
            this.btnStopMachine.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnStopMachine.ButtonText = "Button";
            this.btnStopMachine.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnStopMachine.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStopMachine.CornerRadius = 5;
            this.btnStopMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopMachine.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStopMachine.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnStopMachine.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnStopMachine.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.btnStopMachine.Location = new System.Drawing.Point(242, 11);
            this.btnStopMachine.Name = "btnStopMachine";
            this.btnStopMachine.Padding = new System.Windows.Forms.Padding(10);
            this.btnStopMachine.Size = new System.Drawing.Size(222, 93);
            this.btnStopMachine.TabIndex = 0;
            this.btnStopMachine.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnStopMachine.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStopMachine.Click += new System.EventHandler(this.btnStopMachine_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.tlpAutomation);
            this.Controls.Add(this.panelRobotArmLocation);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyLogo)).EndInit();
            this.panelRobotArmLocation.ResumeLayout(false);
            this.panelRobotArmLocation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlpLocationValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCordinateShow)).EndInit();
            this.tlpAutomation.ResumeLayout(false);
            this.tabControlManualAutomation.ResumeLayout(false);
            this.tabPageSetPoint.ResumeLayout(false);
            this.tabPageSetPoint.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.tabPageSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanelChangeRunState.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private XanderUI.XUIButton btnClose;
        private System.Windows.Forms.PictureBox pbxCompanyLogo;
        private System.Windows.Forms.Panel panelRobotArmLocation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxCordinateShow;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tlpAutomation;
        private System.Windows.Forms.TabControl tabControlManualAutomation;
        private System.Windows.Forms.TabPage tabPageSetPoint;
        private XanderUI.XUIButton btnShowAutomationStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChangeRunState;
        private XanderUI.XUIButton btnStopMachine;
        private XanderUI.XUIButton btnStartMachine;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpLocationValue;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lbZAxisValue;
        private System.Windows.Forms.Label lbYAxisValue;
        private System.Windows.Forms.Label lbXAxisValue;
        private System.Windows.Forms.Label lbSP1;
        private System.Windows.Forms.TextBox txbManualSpeed;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnSetPointNo1;
        private XanderUI.XUIButton btnSetPointNo2;
        private XanderUI.XUIButton btnReturnToORG;
        private XanderUI.XUIButton btnSetNewORG;
        private System.Windows.Forms.TextBox txbXSpeed;
        private System.Windows.Forms.Label lbUS1;
        private XanderUI.XUISwitch xuiSwitchMotorState;
        private System.Windows.Forms.Label lbSP2;
        private System.Windows.Forms.Label lbSP3;
        private System.Windows.Forms.Label lbSP4;
        private System.Windows.Forms.TextBox txbZSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbYSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSpinSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txbMoveRange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbNumberOfLayers;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private XanderUI.XUIButton btnResetAll;
        private XanderUI.XUIButton btnMainSetting;
        private XanderUI.XUIButton btnX_Decrease;
        private XanderUI.XUIButton btnY_Decrease;
        private XanderUI.XUIButton btnZ_Decrease;
        private XanderUI.XUIButton btnY_Increase;
        private XanderUI.XUIButton btnX_Increase;
        private XanderUI.XUIButton btnZ_Increase;
        private XanderUI.XUIButton btnZLock;
        private XanderUI.XUIButton btnYLock;
        private XanderUI.XUIButton btnXLock;
        private XanderUI.XUIButton btnSetZero;
        private System.Windows.Forms.Label lbSP5;
    }
}