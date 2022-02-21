using System;
using System.Windows.Forms;
using ConfigController;
using IniParser;
using IniParser.Model;
using ModuleHelper;

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
            WarbandPath = @"C:\Program Files (x86)\Steam\steamapps\common\MountBlade Warband";


            // Initializes the modules select box
            ModuleEntry[] moduleEntries = ModuleList.GetModuleEntries(System.IO.Path.Combine(WarbandPath, "Modules"));
            moduleSelectBox.Items.AddRange(moduleEntries);
            if (moduleEntries.Length < 1)
            {
                MessageBox.Show(String.Format("No modules found in \"{0}\\{1}\"!", WarbandPath, "Modules"));
                Close();
            }

            // Sets the moduleSelectBox to default module, or Native
            string defaultModule = Settings.GetSettingOrDefault("Launcher", "default_module", "Native");
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
            if (!found) {
                i = 0;
            }

            moduleSelectBox.SelectedIndex = i;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            //support dragging the window
            if (m.Msg == ApiHelper.WM_NCHITTEST && (int)m.Result == ApiHelper.HTCLIENT)
            {
                m.Result = new IntPtr(ApiHelper.HTCAPTION);
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
            ConfigForm cf = new ConfigForm(Settings.Clone());
            cf.Show();
        }

        private void playLabel_Click(object sender, EventArgs e)
        {
            // Saves this module as the default module to launch
            ModuleEntry selected = (ModuleEntry)moduleSelectBox.SelectedItem;
            Settings.Data["Launcher"]["default_module"] = selected.Name;
            Settings.WriteSettings();
        }
    }
}
