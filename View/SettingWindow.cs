using robot_arm_automation.Controller.CustomControl;
using robot_arm_automation.Controller.IniFile;
using robot_arm_automation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace robot_arm_automation.View
{
    public partial class SettingWindow : Form
    {
        public static DataTable settingDT { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        IniFile ini = new IniFile(AppDomain.CurrentDomain.BaseDirectory + "\\data\\setting.ini");

        public SettingWindow()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void LoadNotSettingValue()
        {
            ComboBox notSettingList = new ComboBox();
            for (int i = 0; i < settingDT.Rows.Count; i++)
            {
                if (String.IsNullOrEmpty(ini.Read(settingDT.Rows[i]["value_member"].ToString(), "start")))
                {
                    notSettingList.Items.Add(settingDT.Rows[i]["display_member"].ToString());
                }
            }
            if (notSettingList.Items.Count > 0)
            {
                if (notSettingList.Items.Count > 1)
                {
                    lbSettingAnnounce.Text = "Có giá trị \"" + notSettingList.Items[0].ToString() + "\" và " + (notSettingList.Items.Count - 1) + " giá trị khác chưa được cài đặt!";
                }
                else
                {
                    lbSettingAnnounce.Text = "Có giá trị \"" + notSettingList.Items[0].ToString() + "\" chưa được cài đặt!";
                }
            }
            else
                lbSettingAnnounce.Text = String.Empty;
        }

        private void SaveOffset()
        {
            try
            {
                if (!String.IsNullOrEmpty(cbxPLCValueSetting.Text) && !String.IsNullOrEmpty(txbStartNo.Text) && !String.IsNullOrEmpty(txbBitNo.Text))
                {
                    DialogResult dialogResult = CTMessageBox.Show("Do you want to save \"" + cbxPLCValueSetting.SelectedValue.ToString() + "\" with \"" + txbStartNo.Text + "." + txbBitNo.Text + "\" offset ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ini.Write(cbxPLCValueSetting.SelectedValue.ToString(), "start", txbStartNo.Text);
                        ini.Write(cbxPLCValueSetting.SelectedValue.ToString(), "bit", txbBitNo.Text);
                        txbStartNo.Text = String.Empty;
                        txbBitNo.Text = String.Empty;
                        cbxPLCValueSetting.SelectedIndex = -1;
                        LoadNotSettingValue();
                        txbStartNo.Focus();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            InitSettingDT();
            lbSettingAnnounce.Text = String.Empty;
            txbPLCIP.Text = Settings.Default.plcIP;
            txbPLCDatabase.Text = Settings.Default.plcDatabase;

            cbxPLCValueSetting.DataSource = settingDT;
            cbxPLCValueSetting.ValueMember = "value_member";
            cbxPLCValueSetting.DisplayMember = "display_member";

            cbxPLCValueSetting.SelectedIndex = -1;

            LoadNotSettingValue();
        }
        private void InitSettingDT()
        {
            if (settingDT != null)
            {
                settingDT = null;
            }
            settingDT = new DataTable();
            DataColumn settingCol;

            settingCol = new DataColumn();
            settingCol.DataType = Type.GetType("System.String");
            settingCol.ColumnName = "value_member";
            settingDT.Columns.Add(settingCol);

            settingCol = new DataColumn();
            settingCol.DataType = Type.GetType("System.String");
            settingCol.ColumnName = "display_member";
            settingDT.Columns.Add(settingCol);

            settingDT.Rows.Add("AM", "Auto/ Manual");
            settingDT.Rows.Add("Start", "Start");
            settingDT.Rows.Add("Stop", "Stop");
            settingDT.Rows.Add("Reset", "Reset");
            settingDT.Rows.Add("Return_ORG", "Return_ORG- Return to Origin");
            settingDT.Rows.Add("Set_ORG", "Set_ORG - Set new origin point");
            settingDT.Rows.Add("Set_Point1", "Set_Point1 - Set base point 1");
            settingDT.Rows.Add("Set_Point2", "Set_Point2 - Set base point 2");
            settingDT.Rows.Add("XI", "Button_X+");
            settingDT.Rows.Add("XD", "Button_X-");
            settingDT.Rows.Add("YI", "Button_Y+");
            settingDT.Rows.Add("YD", "Button_Y-");
            settingDT.Rows.Add("ZI", "Button_Z+");
            settingDT.Rows.Add("ZD", "Button_Z-");
            settingDT.Rows.Add("Motor", "ON/OFF_Motor");

            settingDT.Rows.Add("XORG", "ORG_X_Position");
            settingDT.Rows.Add("YORG", "ORG_Y_Position");
            settingDT.Rows.Add("ZORG", "ORG_Z_Position");

            settingDT.Rows.Add("CX", "Current_X_Position");
            settingDT.Rows.Add("CY", "Current_Y_Position");
            settingDT.Rows.Add("CZ", "Current_Z_Position");

            settingDT.Rows.Add("P1X", "SetPoint1_X");
            settingDT.Rows.Add("P1Y", "SetPoint1_Y");
            settingDT.Rows.Add("P1Z", "SetPoint1_Z");

            settingDT.Rows.Add("P2X", "SetPoint2_X");
            settingDT.Rows.Add("P2Y", "SetPoint2_Y");
            settingDT.Rows.Add("P2Z", "SetPoint2_Z");

            //Setting variables
            settingDT.Rows.Add("ManualSpeed", "Manual_Speed");
            settingDT.Rows.Add("XS", "X_Speed");
            settingDT.Rows.Add("YS", "Y_Speed");
            settingDT.Rows.Add("ZS", "Z_Speed");
            settingDT.Rows.Add("MotorSpeed", "Motor_Speed");
            settingDT.Rows.Add("L1", "MoveRange_L1");
            settingDT.Rows.Add("L2", "NumLayer_L2");
            settingDT.Rows.Add("ErrorMsg", "Error Message");

            settingDT.Rows.Add("XLock", "X Axis");
            settingDT.Rows.Add("YLock", "Y Axis");
            settingDT.Rows.Add("ZLock", "Z Axis");
            settingDT.Rows.Add("SetZeroPoint", "Set Zero Point");
        }

        private void cbxPLCValueSetting_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                txbStartNo.Text = ini.Read(cbxPLCValueSetting.SelectedValue.ToString(), "start");
                txbBitNo.Text = ini.Read(cbxPLCValueSetting.SelectedValue.ToString(), "bit");
                txbStartNo.Focus();
            }
            catch (Exception) { throw; }
        }

        private void txbPLCIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbPLCDatabase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void txbStartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
                txbBitNo.Focus();
            }
        }

        private void txbBitNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                SaveOffset();
            }
        }

        private void cbxPLCValueSetting_MouseDown(object sender, MouseEventArgs e)
        {
            if(cbxPLCValueSetting.SelectedIndex != -1)
            {
                if (String.IsNullOrEmpty(ini.Read(cbxPLCValueSetting.SelectedValue.ToString(), "start")) || String.IsNullOrEmpty(ini.Read(cbxPLCValueSetting.SelectedValue.ToString(), "bit")))
                    SaveOffset();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!String.IsNullOrEmpty(txbPLCIP.Text.Trim()))
                Settings.Default.plcIP = txbPLCIP.Text.Trim();
            if (!String.IsNullOrEmpty(txbPLCDatabase.Text.Trim()))
                Settings.Default.plcDatabase = txbPLCDatabase.Text.Trim();
            Settings.Default.Save();

            SaveOffset();
        }
    }
}
