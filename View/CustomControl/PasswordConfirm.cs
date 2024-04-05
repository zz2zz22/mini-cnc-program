using robot_arm_automation.Controller.CustomControl;
using robot_arm_automation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace robot_arm_automation.View.CustomControl
{
    public partial class PasswordConfirm : Form
    {
        public PasswordConfirm()
        {
            InitializeComponent();
        }

        private void CheckPassword(string password)
        {
            if (password == "techlink@123")
            {
                MainWindow.isConfirmed = true;
                this.Close();
            }
            else
            {
                CTMessageBox.Show("WRONG PASSWORD !!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckPassword(txbPassword.Text.Trim());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CheckPassword(txbPassword.Text.Trim());
        }
    }
}
