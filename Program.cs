using doanwf.form;
using System;
using System.Windows.Forms;

namespace doanwf
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static extern bool SetProcessDPIAware();
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_TaoHoaDon());
        }
    }
}
