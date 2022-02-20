using ConfigController;
using System;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    public partial class ConfigForm : Form
    {
        private RglConfig config;

        public ConfigForm(RglConfig conf)
        {
            InitializeComponent();

            languageBox.Items.AddRange(new string[] { "Cesky", "English", "Deutsch", "Espanol", "Francais", "Magyar", "Polski", "Russkiy", "Turkce" });

            // Here is where you could set the custom path of the rgl_config.txt
            // By default it is ~/Documents/Mount&Blade....
            this.config = conf;
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
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hideBloodBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
