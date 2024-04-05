using robot_arm_automation.Controller;
using robot_arm_automation.Controller.CustomControl;
using robot_arm_automation.Controller.IniFile;
using robot_arm_automation.Controller.PLC;
using robot_arm_automation.Properties;
using robot_arm_automation.View.CustomControl;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace robot_arm_automation.View
{
    public partial class MainWindow : Form
    {
        #region Fields
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        BackgroundWorker bgWorker;
        System.Windows.Forms.Timer tmrCallBgWorker;
        System.Threading.Timer tmrEnsureWorkerGetsCalled;

        object lockObject = new object();

        private static int ConnectionPLC;
        private static PLCConnector pLC;
        private static int db;

        public static bool isConfirmed;
        private static bool isAutomation;

        private string CX, CY, CZ;
        private bool isXLock, isYLock, isZLock;
        private int errorMsgCode = 0;

        IniFile ini = new IniFile(AppDomain.CurrentDomain.BaseDirectory + "\\data\\setting.ini");
        #endregion

        #region Contructor
        public MainWindow()
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\data"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\data");
            }
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #endregion

        /// <summary>
        /// THE SECTION FOR ALL SUB METHODS
        /// </summary>
        /// <param name="METHODS"></param>

        #region Methods
        private void DisableControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                childControl.Enabled = false;

                // If the child control is a container (like another TabControl, Panel, etc.), recursively disable its children
                if (childControl.HasChildren)
                {
                    DisableControls(childControl);
                }
            }
        }

        private void EnableControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                childControl.Enabled = true;

                // If the child control is a container (like another TabControl, Panel, etc.), recursively disable its children
                if (childControl.HasChildren)
                {
                    EnableControls(childControl);
                }
            }
        }

        private void AutomationON()
        {
            try
            {
                pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
                if (ConnectionPLC == 0)
                {
                    pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("AM", "start")), Convert.ToInt32(ini.Read("AM", "bit")));
                    if (isXLock)
                    {
                        pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("XLock", "start")), Convert.ToInt32(ini.Read("XLock", "bit")));
                        btnXLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                        isXLock = false;
                    }
                    if (isYLock)
                    {
                        pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("YLock", "start")), Convert.ToInt32(ini.Read("YLock", "bit")));
                        btnYLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                        isYLock = false;
                    }
                    if (isZLock)
                    {
                        pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("ZLock", "start")), Convert.ToInt32(ini.Read("ZLock", "bit")));
                        btnZLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                        isZLock = false;
                    }
                    isAutomation = true;
                    btnShowAutomationStatus.ButtonText = "Automation ON";
                    btnShowAutomationStatus.BackgroundColor = Color.Yellow;
                    btnShowAutomationStatus.TextColor = Color.Black;
                    foreach (TabPage tabPage in tabControlManualAutomation.TabPages)
                    {
                        DisableControls(tabPage);
                    }
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Turn automation ON exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutomationOFF()
        {
            try
            {
                pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
                if (ConnectionPLC == 0)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("AM", "start")), Convert.ToInt32(ini.Read("AM", "bit")));

                    isAutomation = false;
                    btnShowAutomationStatus.ButtonText = "Automation OFF";
                    btnShowAutomationStatus.BackgroundColor = Color.Red;
                    btnShowAutomationStatus.TextColor = Color.White;
                    foreach (TabPage tabPage in tabControlManualAutomation.TabPages)
                    {
                        EnableControls(tabPage);
                    }
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Turn automation OFF exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawSetPoint()
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            SubMethods.DrawSetPointRectangle(
    SubMethods.String2Axis(pLC.ReadRealToString(db, Convert.ToInt32(ini.Read("P1X", "start")))),
    SubMethods.String2Axis(pLC.ReadRealToString(db, Convert.ToInt32(ini.Read("P1Y", "start")))),
    SubMethods.String2Axis(pLC.ReadRealToString(db, Convert.ToInt32(ini.Read("P2X", "start")))),
    SubMethods.String2Axis(pLC.ReadRealToString(db, Convert.ToInt32(ini.Read("P2Y", "start")))),
    pictureBoxCordinateShow);
        }


        private void SaveSetting2PLC()
        {
            try
            {
                txbManualSpeed.Text = Settings.Default.manualSpeed.ToString();
                txbXSpeed.Text = Settings.Default.xAxisSpeed.ToString();
                txbYSpeed.Text = Settings.Default.yAxisSpeed.ToString();
                txbZSpeed.Text = Settings.Default.zAxisSpeed.ToString();
                txbSpinSpeed.Text = Settings.Default.spinSpeed.ToString();
                txbMoveRange.Text = Settings.Default.moveRange.ToString();
                txbNumberOfLayers.Text = Settings.Default.numberOfLayers.ToString();

                pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
                if (ConnectionPLC == 0)
                {
                    pLC.WriteRealtoPLC(Settings.Default.manualSpeed, db, Convert.ToInt32(ini.Read("ManualSpeed", "start")), 2);
                    pLC.WriteRealtoPLC(Settings.Default.xAxisSpeed, db, Convert.ToInt32(ini.Read("XS", "start")), 2);
                    pLC.WriteRealtoPLC(Settings.Default.yAxisSpeed, db, Convert.ToInt32(ini.Read("YS", "start")), 2);
                    pLC.WriteRealtoPLC(Settings.Default.zAxisSpeed, db, Convert.ToInt32(ini.Read("ZS", "start")), 2);
                    pLC.WriteRealtoPLC(Settings.Default.spinSpeed, db, Convert.ToInt32(ini.Read("MotorSpeed", "start")), 2);
                    pLC.WriteRealtoPLC(Settings.Default.moveRange, db, Convert.ToInt32(ini.Read("L1", "start")), 2);
                    pLC.WriteDinttoPLC(Settings.Default.numberOfLayers, db, Convert.ToInt32(ini.Read("L2", "start")), 4);
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Save setting to PLC exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSettingSpeedFloat(TextBox textBox, Label label, bool isSpeed, string propertyName)
        {
            bool isPass = false;
            if (float.TryParse(textBox.Text.Trim(), out float result))
            {
                if (isSpeed)
                {
                    if (result > 0 && result <= 200)
                        isPass = true;
                }
                else
                {
                    isPass = true;
                }

                if (isPass)
                {
                    Properties.Settings.Default[propertyName] = result;
                    Settings.Default.Save();
                    SaveSetting2PLC();
                    label.Focus();
                }
                else
                {
                    CTMessageBox.Show("Speed must be greater than 0(mm/s) and smaller or equal 200(mm/s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                }
            }
            else
            {
                CTMessageBox.Show("Speed value is not in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
        }

        private void SaveSettingMoveRange(TextBox textBox, Label label, string propertyName)
        {
            bool isPass = false;
            if (float.TryParse(textBox.Text.Trim(), out float result))
            {
                if (result > 0 && result <= 750)
                    isPass = true;

                if (isPass)
                {
                    Properties.Settings.Default[propertyName] = result;
                    Settings.Default.Save();
                    SaveSetting2PLC();
                    label.Focus();
                }
                else
                {
                    CTMessageBox.Show("Move range must be greater than 0mm and smaller or equal 750mm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                }
            }
            else
            {
                CTMessageBox.Show("Move range value is not in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
        }

        private void SaveSettingLayers(TextBox textBox, Label label, string propertyName)
        {
            bool isPass = false;
            if (int.TryParse(textBox.Text.Trim(), out int result))
            {
                if (result > 0 && result <= 500)
                    isPass = true;

                if (isPass)
                {
                    Properties.Settings.Default[propertyName] = result;
                    Settings.Default.Save();
                    SaveSetting2PLC();
                    label.Focus();
                }
                else
                {
                    CTMessageBox.Show("Number of layers must be greater than 0 and smaller or equal 500", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                }
            }
            else
            {
                CTMessageBox.Show("Number of layers value is not in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
        }

        private void LoadBackgroundWorker()
        {
            // this timer calls bgWorker again and again after regular intervals
            tmrCallBgWorker = new System.Windows.Forms.Timer();//Timer for do task
            tmrCallBgWorker.Tick += new EventHandler(timer_nextRun_Tick);
            tmrCallBgWorker.Interval = 200; //3600000 = 1 hour;

            // this is our worker
            bgWorker = new BackgroundWorker();

            // work happens in this method
            bgWorker.DoWork += new DoWorkEventHandler(BW_DoWork);
            bgWorker.ProgressChanged += BW_ProgressChanged;
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            bgWorker.WorkerReportsProgress = true;

            tmrCallBgWorker.Start();
        }
        #endregion

        private void timer_nextRun_Tick(object sender, EventArgs e)
        {
            if (Monitor.TryEnter(lockObject))
            {
                try
                {
                    // if bgworker is not busy the call the worker
                    if (!bgWorker.IsBusy)
                    {
                        bgWorker.RunWorkerAsync();
                    }
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
            else
            {
                // as the bgworker is busy we will start a timer that will try to call the bgworker again after some time
                tmrEnsureWorkerGetsCalled = new System.Threading.Timer(new TimerCallback(tmrEnsureWorkerGetsCalled_Callback), null, 0, 10);
            }
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
                if (ConnectionPLC == 0)
                {
                    CX = pLC.ReadRealToString(db, Convert.ToInt32(ini.Read("CX", "start")));
                    CY = pLC.ReadRealToString(db, Convert.ToInt32(ini.Read("CY", "start")));
                    CZ = pLC.ReadRealToString(db, Convert.ToInt32(ini.Read("CZ", "start")));

                    //errorMsgCode = Convert.ToInt32(pLC.ReadIntToString(db, Convert.ToInt32(ini.Read("ErrorMsg", "start"))));
                }
                bgWorker.ReportProgress(0);
            }
            catch (Exception ex)
            {
                SystemLog.Output(SystemLog.MSG_TYPE.Err, "Read speed and temperature error:", ex.Message);
            }
        }

        private void BW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //
            //Logic update here
            //

            //Lấy vị trí hiện tại của máy
            SubMethods.DrawDotAndSquare(SubMethods.String2Axis(CX), SubMethods.String2Axis(CY), pictureBoxCordinateShow);
            DrawSetPoint();
            lbXAxisValue.Text = CX;
            lbYAxisValue.Text = CY;
            lbZAxisValue.Text = CZ;

            if (errorMsgCode != 0)
            {

            }
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) { }

        void tmrEnsureWorkerGetsCalled_Callback(object obj)
        {
            // this timer was started as the bgworker was busy before now it will try to call the bgworker again
            if (Monitor.TryEnter(lockObject))
            {
                try
                {
                    if (!bgWorker.IsBusy)
                    {
                        bgWorker.RunWorkerAsync();
                    }
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
                tmrEnsureWorkerGetsCalled = null;
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Exit the program ?\r\nThis will stop the machine and turn off automation mode.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
                if (ConnectionPLC == 0)
                {
                    pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Stop", "start")), Convert.ToInt32(ini.Read("Stop", "bit")));
                    Thread.Sleep(200);
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Stop", "start")), Convert.ToInt32(ini.Read("Stop", "bit")));
                    pLC.Diconnect();
                }
                ClearMemory.CleanMemoryCompletely();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmrCallBgWorker != null) //Release BG worker
            {
                tmrCallBgWorker.Stop();
                tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
                bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
                bgWorker.ProgressChanged -= BW_ProgressChanged;
                bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            }
        }

        private void btnSetPointNo1_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            //Trigger true để set point 1 cho vị trí hiện tại rồi vẽ lại khung set point
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Set_Point1", "start")), Convert.ToInt32(ini.Read("Set_Point1", "bit")));
                Thread.Sleep(200);
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Set_Point1", "start")), Convert.ToInt32(ini.Read("Set_Point1", "bit")));
                CTMessageBox.Show("Set new point 1 successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSetPointNo2_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            //Trigger true để set point 2 cho vị trí hiện tại rồi vẽ lại khung set point
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Set_Point2", "start")), Convert.ToInt32(ini.Read("Set_Point2", "bit")));
                Thread.Sleep(200);
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Set_Point2", "start")), Convert.ToInt32(ini.Read("Set_Point2", "bit")));
                CTMessageBox.Show("Set new point 2 successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReturnToORG_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            //Trigger true để cho máy về vị trí origin đã lưu trên PLC
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Return_ORG", "start")), Convert.ToInt32(ini.Read("Return_ORG", "bit")));
                Thread.Sleep(200);
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Return_ORG", "start")), Convert.ToInt32(ini.Read("Return_ORG", "bit")));
            }
        }

        private void btnSetNewORG_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Do you want to set the machine current location to origin position ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
                //Trigger true để set vị trí ORG mới trên PLC
                if (ConnectionPLC == 0)
                {
                    pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Set_ORG", "start")), Convert.ToInt32(ini.Read("Set_ORG", "bit")));
                    Thread.Sleep(200);
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Set_ORG", "start")), Convert.ToInt32(ini.Read("Set_ORG", "bit")));
                    CTMessageBox.Show("New origin point set successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnStopMachine_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            //Trigger true để dừng máy
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Stop", "start")), Convert.ToInt32(ini.Read("Stop", "bit")));
                Thread.Sleep(200);
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Stop", "start")), Convert.ToInt32(ini.Read("Stop", "bit")));
            }
        }

        private void btnStartMachine_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            //Trigger true để khởi động máy
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Start", "start")), Convert.ToInt32(ini.Read("Start", "bit")));
                Thread.Sleep(200);
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Start", "start")), Convert.ToInt32(ini.Read("Start", "bit")));
            }
        }

        private void btnMainSetting_Click(object sender, EventArgs e)
        {
            PasswordConfirm passwordConfirm = new PasswordConfirm();
            passwordConfirm.FormClosed += settingPasswordFormClosed;
            passwordConfirm.ShowDialog();
        }

        private void settingPasswordFormClosed(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= settingPasswordFormClosed;
            if (isConfirmed)
            {
                isConfirmed = false;
                SettingWindow settingWindow = new SettingWindow();
                settingWindow.FormClosed += settingFormClosed;
                settingWindow.ShowDialog();
            }
        }
        private void settingFormClosed(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= settingFormClosed;
            this.BeginInvoke(new EventHandler(MainWindow_Load));
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Reset", "start")), Convert.ToInt32(ini.Read("Reset", "bit")));
                Thread.Sleep(200);
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Reset", "start")), Convert.ToInt32(ini.Read("Reset", "bit")));
                CTMessageBox.Show("Successfully reset PLC!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowAutomationStatus_Click(object sender, EventArgs e)
        {
            if (isAutomation)
            {
                AutomationOFF();
            }
            else
            {
                AutomationON();
            }
        }

        private void txbManualSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbXSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbYSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbZSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbSpinSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbMoveRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbNumberOfLayers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void xuiSwitchMotorState_SwitchStateChanged(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                if (xuiSwitchMotorState.SwitchState == XanderUI.XUISwitch.State.On /*&& motorStatus*/)
                {
                    pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("Motor", "start")), Convert.ToInt32(ini.Read("Motor", "bit")));
                }
                else if (xuiSwitchMotorState.SwitchState == XanderUI.XUISwitch.State.Off /*&& !motorStatus*/)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("Motor", "start")), Convert.ToInt32(ini.Read("Motor", "bit")));
                }
            }
        }

        private void txbManualSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSettingSpeedFloat(txbManualSpeed, lbSP1, true, "manualSpeed");
            }
        }

        private void txbManualSpeed_Leave(object sender, EventArgs e)
        {
            SaveSettingSpeedFloat(txbManualSpeed, lbSP1, true, "manualSpeed");
        }

        private void txbXSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSettingSpeedFloat(txbXSpeed, lbUS1, true, "xAxisSpeed");
            }
        }

        private void txbXSpeed_Leave(object sender, EventArgs e)
        {
            SaveSettingSpeedFloat(txbXSpeed, lbUS1, true, "xAxisSpeed");
        }

        private void txbYSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSettingSpeedFloat(txbYSpeed, lbUS1, true, "yAxisSpeed");
            }
        }

        private void txbYSpeed_Leave(object sender, EventArgs e)
        {
            SaveSettingSpeedFloat(txbYSpeed, lbUS1, true, "yAxisSpeed");
        }

        private void txbZSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSettingSpeedFloat(txbZSpeed, lbUS1, true, "zAxisSpeed");
            }
        }

        private void txbZSpeed_Leave(object sender, EventArgs e)
        {
            SaveSettingSpeedFloat(txbZSpeed, lbUS1, true, "zAxisSpeed");
        }

        private void txbSpinSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSettingSpeedFloat(txbSpinSpeed, lbUS1, true, "spinSpeed");
            }
        }

        private void txbSpinSpeed_Leave(object sender, EventArgs e)
        {
            SaveSettingSpeedFloat(txbSpinSpeed, lbUS1, true, "spinSpeed");
        }

        private void txbMoveRange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSettingMoveRange(txbMoveRange, lbUS1, "moveRange");
            }
        }

        private void txbMoveRange_Leave(object sender, EventArgs e)
        {
            SaveSettingMoveRange(txbMoveRange, lbUS1, "moveRange");
        }

        private void txbNumberOfLayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveSettingLayers(txbNumberOfLayers, lbUS1, "numberOfLayers");
            }
        }

        private void txbNumberOfLayers_Leave(object sender, EventArgs e)
        {
            SaveSettingLayers(txbNumberOfLayers, lbUS1, "numberOfLayers");
        }

        private void btnX_Decrease_MouseDown(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("XD", "start")), Convert.ToInt32(ini.Read("XD", "bit")));
                btnX_Decrease.ButtonImage = Properties.Resources.left_x_arrow;
                btnX_Decrease.Refresh();
            }
        }

        private void btnX_Decrease_MouseUp(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("XD", "start")), Convert.ToInt32(ini.Read("XD", "bit")));
                btnX_Decrease.ButtonImage = Properties.Resources.x_decrease;
                btnX_Decrease.Refresh();
            }
        }

        private void btnX_Increase_MouseDown(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("XI", "start")), Convert.ToInt32(ini.Read("XI", "bit")));
                btnX_Increase.ButtonImage = Properties.Resources.right_x_arrow;
                btnX_Increase.Refresh();
            }
        }

        private void btnX_Increase_MouseUp(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("XI", "start")), Convert.ToInt32(ini.Read("XI", "bit")));
                btnX_Increase.ButtonImage = Properties.Resources.x_increase;
                btnX_Increase.Refresh();
            }
        }

        private void btnY_Decrease_MouseDown(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("YD", "start")), Convert.ToInt32(ini.Read("YD", "bit")));
                btnY_Decrease.ButtonImage = Properties.Resources.up_y_arrow;
                btnY_Decrease.Refresh();
            }
        }

        private void btnY_Decrease_MouseUp(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("YD", "start")), Convert.ToInt32(ini.Read("YD", "bit")));
                btnY_Decrease.ButtonImage = Properties.Resources.y_decrease;
                btnY_Decrease.Refresh();
            }
        }

        private void btnY_Increase_MouseDown(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("YI", "start")), Convert.ToInt32(ini.Read("YI", "bit")));
                btnY_Increase.ButtonImage = Properties.Resources.down_y_arrow;
                btnY_Increase.Refresh();
            }
        }

        private void btnY_Increase_MouseUp(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("YI", "start")), Convert.ToInt32(ini.Read("YI", "bit")));
                btnY_Increase.ButtonImage = Properties.Resources.y_increase;
                btnY_Increase.Refresh();
            }
        }

        private void btnZ_Decrease_MouseDown(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("ZD", "start")), Convert.ToInt32(ini.Read("ZD", "bit")));
                btnZ_Decrease.ButtonImage = Properties.Resources.up_z_arrows;
                btnZ_Decrease.Refresh();
            }
        }

        private void btnZ_Decrease_MouseUp(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("ZD", "start")), Convert.ToInt32(ini.Read("ZD", "bit")));
                btnZ_Decrease.ButtonImage = Properties.Resources.z_decrease;
                btnZ_Decrease.Refresh();
            }
        }

        private void btnXLock_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                if (!isXLock)
                {
                    pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("XLock", "start")), Convert.ToInt32(ini.Read("XLock", "bit")));
                    btnXLock.BackgroundColor = Color.Gray;
                    isXLock = true;
                }
                else
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("XLock", "start")), Convert.ToInt32(ini.Read("XLock", "bit")));
                    btnXLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isXLock = false;
                }
                if (isYLock)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("YLock", "start")), Convert.ToInt32(ini.Read("YLock", "bit")));
                    btnYLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isYLock = false;
                }
                if (isZLock)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("ZLock", "start")), Convert.ToInt32(ini.Read("ZLock", "bit")));
                    btnZLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isZLock = false;
                }

            }
        }

        private void btnSetZero_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("SetZeroPoint", "start")), Convert.ToInt32(ini.Read("SetZeroPoint", "bit")));
                Thread.Sleep(200);
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("SetZeroPoint", "start")), Convert.ToInt32(ini.Read("SetZeroPoint", "bit")));
            }
        }

        private void btnYLock_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                if (isXLock)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("XLock", "start")), Convert.ToInt32(ini.Read("XLock", "bit")));
                    btnXLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isXLock = false;
                }
                if (!isYLock)
                {
                    pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("YLock", "start")), Convert.ToInt32(ini.Read("YLock", "bit")));
                    btnYLock.BackgroundColor = Color.Gray;
                    isYLock = true;
                }
                else
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("YLock", "start")), Convert.ToInt32(ini.Read("YLock", "bit")));
                    btnYLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isYLock = false;
                }
                if (isZLock)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("ZLock", "start")), Convert.ToInt32(ini.Read("ZLock", "bit")));
                    btnZLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isZLock = false;
                }

            }
        }

        private void btnZLock_Click(object sender, EventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                if (isXLock)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("XLock", "start")), Convert.ToInt32(ini.Read("XLock", "bit")));
                    btnXLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isXLock = false;
                }
                if (isYLock)
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("YLock", "start")), Convert.ToInt32(ini.Read("YLock", "bit")));
                    btnYLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isYLock = false;
                }
                if (!isZLock)
                {
                    pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("ZLock", "start")), Convert.ToInt32(ini.Read("ZLock", "bit")));
                    btnZLock.BackgroundColor = Color.Gray;
                    isZLock = true;
                }
                else
                {
                    pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("ZLock", "start")), Convert.ToInt32(ini.Read("ZLock", "bit")));
                    btnZLock.BackgroundColor = Color.FromArgb(192, 192, 0);
                    isZLock = false;
                }
            }
        }

        private void btnZ_Increase_MouseDown(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(true, db, Convert.ToInt32(ini.Read("ZI", "start")), Convert.ToInt32(ini.Read("ZI", "bit")));
                btnZ_Increase.ButtonImage = Properties.Resources.down_z_arrow;
                btnZ_Increase.Refresh();
            }
        }

        private void btnZ_Increase_MouseUp(object sender, MouseEventArgs e)
        {
            pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
            if (ConnectionPLC == 0)
            {
                pLC.WriteBoolToPLC(false, db, Convert.ToInt32(ini.Read("ZI", "start")), Convert.ToInt32(ini.Read("ZI", "bit")));
                btnZ_Increase.ButtonImage = Properties.Resources.z_increase;
                btnZ_Increase.Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the rectangle coordinates
            int x = Math.Min(SubMethods.startPoint.X, SubMethods.endPoint.X);
            int y = Math.Min(SubMethods.startPoint.Y, SubMethods.endPoint.Y);
            int width = Math.Abs(SubMethods.startPoint.X - SubMethods.endPoint.X);
            int height = Math.Abs(SubMethods.startPoint.Y - SubMethods.endPoint.Y);

            // Draw the rectangle on PictureBox
            e.Graphics.DrawRectangle(Pens.Yellow, x, y, width, height);

            // Define the text to be drawn
            string textP1 = "P1";
            string textP2 = "P2";

            // Define the font and brush for drawing text
            Font font = new Font("Arial", 8);
            Brush brush = Brushes.Yellow;

            // Calculate the position for the text (next to the point)
            Point textPositionP1 = new Point(SubMethods.startPoint.X + 1, SubMethods.startPoint.Y + 1);
            Point textPositionP2 = new Point(SubMethods.endPoint.X - 15, SubMethods.endPoint.Y - 15);

            // Draw the text next to the point
            e.Graphics.DrawString(textP1, font, brush, textPositionP1);
            e.Graphics.DrawString(textP2, font, brush, textPositionP2);

            // Draw trail line
            for (int i = 1; i < SubMethods.trailPoints.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Aqua, SubMethods.trailPoints[i - 1], SubMethods.trailPoints[i]);
            }

            // Draw dot
            int dotSize = 5; // Size of the dot
            e.Graphics.FillEllipse(Brushes.White, SubMethods.dotPoint.X - dotSize / 2, SubMethods.dotPoint.Y - dotSize / 2, dotSize, dotSize);

            // Draw square surrounding the dot
            int x_m = SubMethods.dotPoint.X - SubMethods.squareSize / 2;
            int y_m = SubMethods.dotPoint.Y - SubMethods.squareSize / 2;
            e.Graphics.DrawRectangle(Pens.White, x_m, y_m, SubMethods.squareSize, SubMethods.squareSize);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            isAutomation = false;

            if (!int.TryParse(Settings.Default.plcDatabase, out db) || String.IsNullOrEmpty(Settings.Default.plcIP))
            {
                CTMessageBox.Show("Please config all setting first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BeginInvoke(new EventHandler(btnMainSetting_Click));
            }
            else
            {
                pLC = new PLCConnector(Settings.Default.plcIP, 0, 0, out ConnectionPLC);
                //Vẽ set point đã set ở PLC
                if (ConnectionPLC == 0)
                {
                    isXLock = false;
                    isYLock = false;
                    isZLock = false;

                    AutomationOFF();
                    SaveSetting2PLC();

                    DrawSetPoint();

                    if (tmrCallBgWorker != null) //Release BG worker
                    {
                        tmrCallBgWorker.Stop();
                        tmrCallBgWorker.Tick -= new EventHandler(timer_nextRun_Tick);
                        bgWorker.DoWork -= new DoWorkEventHandler(BW_DoWork);
                        bgWorker.ProgressChanged -= BW_ProgressChanged;
                        bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
                    }
                    else
                    {
                        LoadBackgroundWorker();
                    }
                }
                else
                {
                    DialogResult dialogResult = CTMessageBox.Show("Can NOT connect to PLC! Check setting and try again.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Retry)
                    {
                        this.BeginInvoke(new EventHandler(btnMainSetting_Click));
                    }
                    else
                    {
                        ClearMemory.CleanMemoryCompletely();
                    }
                }
            }
        }
    }
}
