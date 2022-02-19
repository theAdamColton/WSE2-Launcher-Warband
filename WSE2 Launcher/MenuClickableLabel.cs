using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    class MenuClickableLabel : Label
    {
        static Color selectedColor = Color.Red;
        static Color latentColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

        public MenuClickableLabel()
        {
            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Mordred", 18.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = latentColor;
            this.Size = new System.Drawing.Size(52, 29);
            this.TabIndex = 3;
            this.Text = "ClickableLabel";
            this.MouseEnter += OnMEnter;
            this.MouseLeave += OnMLeave;
        }

        private void OnMEnter(object sender, EventArgs e)
        {
            this.ForeColor = selectedColor;
        }

        private void OnMLeave(object sender, EventArgs e)
        {
            this.ForeColor = latentColor;
        }
    }
}
