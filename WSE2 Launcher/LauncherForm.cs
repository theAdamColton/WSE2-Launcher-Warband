using ConfigController;
using ModuleHelper;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WSE2_CLI_Options;

namespace WSE2_Launcher
{
    public partial class LauncherForm : Form
    {
        //private PerPixelAlphaForm background;
        private FormBackground background;
        private string WarbandPath;

        /// <summary>
        /// ReadSettings defaults to the conf file in Documents/Mount&Blade...
        /// </summary>
        private RglSettings Settings = RglLoader.ReadSettings();

        public LauncherForm()
        {
            InitializeComponent();

            //remove this form's background, because it causes weird graphics
            this.BackgroundImage = null;
            this.background = new FormBackground(Properties.Resources.background, this);

            // TODO set warband path to pwd ins
            string pwd = System.IO.Directory.GetCurrentDirectory();
            WarbandPath = pwd;

            if (!Directory.Exists(Path.Combine(WarbandPath, "Modules")))
            {
                MessageBox.Show("Could not find Modules directory. Are you sure that this launcher was placed in the Warband folder?");
            }


            // Initializes the modules select box
            ModuleEntry[] moduleEntries = ModuleList.GetModuleEntries(System.IO.Path.Combine(WarbandPath, "Modules"));
            moduleSelectBox.Items.AddRange(moduleEntries);
            if (moduleEntries.Length < 1)
            {
                MessageBox.Show(String.Format("No modules found in \"{0}\\{1}\"!", WarbandPath, "Modules"));
                Close();
            }

            // Sets the moduleSelectBox to default module, or Native
            string defaultModule = Settings.bDefaultModule.Get();
            InitializeModuleSelectBoxOrFirst(defaultModule);
        }

        private void InitializeModuleSelectBoxOrFirst(string defaultModule)
        {
            bool found = false;
            // Looks for defaultModule in moduleEntries
            int i = 0;
            foreach (ModuleEntry me in moduleSelectBox.Items)
            {
                if (me.Name == defaultModule)
                {
                    found = true;
                    break;
                }
                i++;
            }
            if (!found)
            {
                i = 0;
            }

            moduleSelectBox.SelectedIndex = i;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void configureLabel_Click(object sender, EventArgs e)
        {
            ConfigForm cf = new ConfigForm(Settings);
            cf.Show();
        }

        private void playLabel_Click(object sender, EventArgs e)
        {
            // Saves this module as the default module to launch
            ModuleEntry selected = (ModuleEntry)moduleSelectBox.SelectedItem;

            if (Settings.bDefaultModule.Get() != selected.ToString())
            {
                Settings.bDefaultModule.Set(selected.ToString());
                Settings.WriteSettings();
            }

            CLI_Options options = new CLI_Options();
            options.Module = selected.Name;
            options.IntroDisabled = Settings.bDisableIntro.Get();

            string cli_options = options.ToString();

            string bin_path = Path.Combine(WarbandPath, "mb_warband_wse2.exe");
            Console.WriteLine("Excecuting command {0} {1}", bin_path, cli_options);

            Process.Start(bin_path, cli_options);
            Close();
        }

        private void moduleSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // changes the image
            ModuleEntry selected = (ModuleEntry)moduleSelectBox.SelectedItem;
            modulePictureBox.Image = selected.GetBitmap();
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
