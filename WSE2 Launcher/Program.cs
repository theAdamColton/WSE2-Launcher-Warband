using System;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new LauncherForm());
            }
            catch (Exception e)
            {
                Console.WriteLine("Encountered error {0}", e);
                Console.ReadLine();
            }
        }
    }
}
