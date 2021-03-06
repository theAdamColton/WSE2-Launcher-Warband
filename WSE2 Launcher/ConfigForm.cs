using ConfigController;
using System;
using System.IO;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    public partial class ConfigForm : Form
    {
        private RglSettings rglSettings;

        public ConfigForm(RglSettings rglSettings)
        {
            this.rglSettings = rglSettings;

            InitializeComponent();
            InitializeUI();
        }

        // Language settings are handled as a special case
        private string _lang_path = Path.Combine(new string[] { Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "Roaming", "Mount&Blade Warband WSE2", "language.txt" });

        /// <summary>
        /// All of the UI elements should be initialized to their value in the RglSettings Settings object,
        /// as read from the ini file.
        /// </summary>
        private void InitializeUI()
        {
            languageBox.Items.AddRange(new string[] { "en", });
            if (File.Exists(_lang_path))
            {
                languageBox.SelectedItem = File.ReadAllText(_lang_path).Replace("\n", "");
            }

            hideBloodBox.Checked = !rglSettings.bBlood.Get();
            disableSoundBox.Checked = !rglSettings.bSound.Get();
            disableMusicBox.Checked = !rglSettings.bMusic.Get();
            windowedBox.Checked = rglSettings.bWindowed.Get();
            disableIntroBox.Checked = rglSettings.bDisableIntro.Get();
            enableFpsCount.Checked = rglSettings.bShowFrameRate.Get();
            disableDistanceFilterCheckBox.Checked = !rglSettings.bDistanceFilter.Get();
            disableOcclusionFilterCheckBox.Checked = !rglSettings.bOcclusionFilter.Get();
            disableHrtfCheckBox.Checked = !rglSettings.bHrtfFilter.Get();
        }

        /// <summary>
        /// Allows moving the window by holding down the mouse button
        /// </summary>
        /// <param name="m"></param>
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
            Cancel_Click(sender, e);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            rglSettings.WriteSettings();

            // TODO language settings are handled as a special case
            // Tries to write to \AppData\Roaming\Mount&Blade Warband WSE2\language.txt
            Console.WriteLine("Writing to lang file {0} {1}", _lang_path, languageBox.SelectedItem);
            if (File.Exists(_lang_path))
            {
                File.WriteAllText(_lang_path, languageBox.SelectedItem.ToString());
            }

            closeButton_Click(sender, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hideBloodBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bBlood.Set(!hideBloodBox.Checked);
        }

        private void windowedBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bWindowed.Set(windowedBox.Checked);
        }

        private void disableIntroBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bDisableIntro.Set(disableIntroBox.Checked);
        }

        private void enableFpsCounter_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bShowFrameRate.Set(enableFpsCount.Checked);
        }

        private void disableSoundBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bSound.Set(!disableSoundBox.Checked);
        }

        private void disableMusicBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bMusic.Set(!disableMusicBox.Checked);
        }

        private void disableDistanceFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bDistanceFilter.Set(!disableDistanceFilterCheckBox.Checked);
        }

        private void disableOcclusionFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bOcclusionFilter.Set(!disableOcclusionFilterCheckBox.Checked);
        }

        private void disableHrtfCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rglSettings.bHrtfFilter.Set(!disableHrtfCheckBox.Checked);
        }
    }
}
