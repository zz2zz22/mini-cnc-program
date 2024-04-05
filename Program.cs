using robot_arm_automation.Controller.CustomControl;
using robot_arm_automation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robot_arm_automation
{
    internal static class Program
    {
        public static MainWindow main;
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    main = new MainWindow();
                    Application.Run(main);
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else
            {
                CTMessageBox.Show("Program is running.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
