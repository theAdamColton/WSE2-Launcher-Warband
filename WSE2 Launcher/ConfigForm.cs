using ConfigController;
using System;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    public partial class ConfigForm : Form
    {
        private RglSettings Settings;

        public ConfigForm(RglSettings settings)
        {
            Settings = settings;

            InitializeComponent();
            InitializeUI();
        }

        /// <summary>
        /// All of the UI elements should be initialized to their value in the RglSettings Settings object,
        /// as read from the ini file.
        /// </summary>
        private void InitializeUI()
        {
            // TODO Languages
            //languageBox.Items.AddRange(new string[] { "Cesky", "English", "Deutsch", "Espanol", "Francais", "Magyar", "Polski", "Russkiy", "Turkce" });
            hideBloodBox.Checked = !Settings.bBlood.Get();
            disableSoundBox.Checked = !Settings.bSound.Get();
            disableMusicBox.Checked = !Settings.bMusic.Get();
            windowedBox.Checked = Settings.bWindowed.Get();
            disableIntroBox.Checked = Settings.bDisableIntro.Get();
            enableFpsCount.Checked = Settings.bShowFrameRate.Get();
            disableDistanceFilterCheckBox.Checked = !Settings.bDistanceFilter.Get();
            disableOcclusionFilterCheckBox.Checked = !Settings.bOcclusionFilter.Get();
            disableHrtfCheckBox.Checked = !Settings.bHrtfFilter.Get();
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
            Settings.WriteSettings();
            closeButton_Click(sender, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hideBloodBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bBlood.Set(!hideBloodBox.Checked);
        }

        private void windowedBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bWindowed.Set(windowedBox.Checked);
        }

        private void disableIntroBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bDisableIntro.Set(disableIntroBox.Checked);
        }

        private void enableFpsCounter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bShowFrameRate.Set(enableFpsCount.Checked);
        }

        private void disableSoundBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bSound.Set(!disableSoundBox.Checked);
        }

        private void disableMusicBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bMusic.Set(!disableMusicBox.Checked);
        }

        private void disableDistanceFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bDistanceFilter.Set(!disableDistanceFilterCheckBox.Checked);
        }

        private void disableOcclusionFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bOcclusionFilter.Set(!disableOcclusionFilterCheckBox.Checked);
        }

        private void disableHrtfCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bHrtfFilter.Set(!disableHrtfCheckBox.Checked);
        }
    }
}
