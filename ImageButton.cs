using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    class ImageButton : Button
    {

        static Color selectedColor = Color.Black;
        static Color latentColor = Color.Red;

        public ImageButton()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.Text = null;
            this.BackgroundImage = Properties.Resources.closebutton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TabIndex = 0;
            this.TabStop = false;
            this.UseVisualStyleBackColor = false;
            this.Font = new System.Drawing.Font("Mordred", 12.25F, System.Drawing.FontStyle.Bold);
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
