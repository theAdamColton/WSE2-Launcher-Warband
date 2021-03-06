
namespace WSE2_Launcher
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.gamePage = new System.Windows.Forms.TabPage();
            this.disableIntroBox = new System.Windows.Forms.CheckBox();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.enableFpsCount = new System.Windows.Forms.CheckBox();
            this.hideBloodBox = new System.Windows.Forms.CheckBox();
            this.videoPage = new System.Windows.Forms.TabPage();
            this.textureBox = new System.Windows.Forms.CheckBox();
            this.windowedBox = new System.Windows.Forms.CheckBox();
            this.audioPage = new System.Windows.Forms.TabPage();
            this.disableHrtfCheckBox = new System.Windows.Forms.CheckBox();
            this.disableDistanceFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.disableOcclusionFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.disableMusicBox = new System.Windows.Forms.CheckBox();
            this.disableSoundBox = new System.Windows.Forms.CheckBox();
            this.advancedPage = new System.Windows.Forms.TabPage();
            this.Cancel = new WSE2_Launcher.ImageButton();
            this.okButton = new WSE2_Launcher.ImageButton();
            this.closeButton = new WSE2_Launcher.ImageButton();
            this.settingsTabControl.SuspendLayout();
            this.gamePage.SuspendLayout();
            this.videoPage.SuspendLayout();
            this.audioPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.gamePage);
            this.settingsTabControl.Controls.Add(this.videoPage);
            this.settingsTabControl.Controls.Add(this.audioPage);
            this.settingsTabControl.Controls.Add(this.advancedPage);
            this.settingsTabControl.Location = new System.Drawing.Point(12, 49);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(438, 361);
            this.settingsTabControl.TabIndex = 1;
            // 
            // gamePage
            // 
            this.gamePage.Controls.Add(this.disableIntroBox);
            this.gamePage.Controls.Add(this.languageBox);
            this.gamePage.Controls.Add(this.languageLabel);
            this.gamePage.Controls.Add(this.enableFpsCount);
            this.gamePage.Controls.Add(this.hideBloodBox);
            this.gamePage.Location = new System.Drawing.Point(4, 22);
            this.gamePage.Name = "gamePage";
            this.gamePage.Padding = new System.Windows.Forms.Padding(3);
            this.gamePage.Size = new System.Drawing.Size(430, 335);
            this.gamePage.TabIndex = 0;
            this.gamePage.Text = "Game";
            this.gamePage.UseVisualStyleBackColor = true;
            // 
            // disableIntroBox
            // 
            this.disableIntroBox.AutoSize = true;
            this.disableIntroBox.Location = new System.Drawing.Point(38, 87);
            this.disableIntroBox.Name = "disableIntroBox";
            this.disableIntroBox.Size = new System.Drawing.Size(85, 17);
            this.disableIntroBox.TabIndex = 5;
            this.disableIntroBox.Text = "Disable Intro";
            this.disableIntroBox.UseVisualStyleBackColor = true;
            this.disableIntroBox.CheckedChanged += new System.EventHandler(this.disableIntroBox_CheckedChanged);
            // 
            // languageBox
            // 
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Location = new System.Drawing.Point(254, 141);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(121, 21);
            this.languageBox.TabIndex = 4;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(35, 141);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "Language:";
            // 
            // enableFpsCount
            // 
            this.enableFpsCount.AutoSize = true;
            this.enableFpsCount.Location = new System.Drawing.Point(38, 64);
            this.enableFpsCount.Name = "enableFpsCount";
            this.enableFpsCount.Size = new System.Drawing.Size(122, 17);
            this.enableFpsCount.TabIndex = 1;
            this.enableFpsCount.Text = "Enable FPS Counter";
            this.enableFpsCount.UseVisualStyleBackColor = true;
            this.enableFpsCount.CheckedChanged += new System.EventHandler(this.enableFpsCounter_CheckedChanged);
            // 
            // hideBloodBox
            // 
            this.hideBloodBox.AutoSize = true;
            this.hideBloodBox.Location = new System.Drawing.Point(38, 41);
            this.hideBloodBox.Name = "hideBloodBox";
            this.hideBloodBox.Size = new System.Drawing.Size(78, 17);
            this.hideBloodBox.TabIndex = 0;
            this.hideBloodBox.Text = "Hide Blood";
            this.hideBloodBox.UseVisualStyleBackColor = true;
            this.hideBloodBox.CheckedChanged += new System.EventHandler(this.hideBloodBox_CheckedChanged);
            // 
            // videoPage
            // 
            this.videoPage.Controls.Add(this.textureBox);
            this.videoPage.Controls.Add(this.windowedBox);
            this.videoPage.Location = new System.Drawing.Point(4, 22);
            this.videoPage.Name = "videoPage";
            this.videoPage.Padding = new System.Windows.Forms.Padding(3);
            this.videoPage.Size = new System.Drawing.Size(430, 335);
            this.videoPage.TabIndex = 1;
            this.videoPage.Text = "Video";
            this.videoPage.UseVisualStyleBackColor = true;
            // 
            // textureBox
            // 
            this.textureBox.AutoSize = true;
            this.textureBox.Location = new System.Drawing.Point(42, 103);
            this.textureBox.Name = "textureBox";
            this.textureBox.Size = new System.Drawing.Size(154, 17);
            this.textureBox.TabIndex = 6;
            this.textureBox.Text = "Load Textures On Demand";
            this.textureBox.UseVisualStyleBackColor = true;
            // 
            // windowedBox
            // 
            this.windowedBox.AutoSize = true;
            this.windowedBox.Location = new System.Drawing.Point(42, 79);
            this.windowedBox.Name = "windowedBox";
            this.windowedBox.Size = new System.Drawing.Size(102, 17);
            this.windowedBox.TabIndex = 3;
            this.windowedBox.Text = "Start Windowed";
            this.windowedBox.UseVisualStyleBackColor = true;
            this.windowedBox.CheckedChanged += new System.EventHandler(this.windowedBox_CheckedChanged);
            // 
            // audioPage
            // 
            this.audioPage.Controls.Add(this.disableHrtfCheckBox);
            this.audioPage.Controls.Add(this.disableDistanceFilterCheckBox);
            this.audioPage.Controls.Add(this.disableOcclusionFilterCheckBox);
            this.audioPage.Controls.Add(this.disableMusicBox);
            this.audioPage.Controls.Add(this.disableSoundBox);
            this.audioPage.Location = new System.Drawing.Point(4, 22);
            this.audioPage.Name = "audioPage";
            this.audioPage.Size = new System.Drawing.Size(430, 335);
            this.audioPage.TabIndex = 2;
            this.audioPage.Text = "Audio";
            this.audioPage.UseVisualStyleBackColor = true;
            // 
            // disableHrtfCheckBox
            // 
            this.disableHrtfCheckBox.AutoSize = true;
            this.disableHrtfCheckBox.Location = new System.Drawing.Point(42, 152);
            this.disableHrtfCheckBox.Name = "disableHrtfCheckBox";
            this.disableHrtfCheckBox.Size = new System.Drawing.Size(132, 17);
            this.disableHrtfCheckBox.TabIndex = 5;
            this.disableHrtfCheckBox.Text = "Disable HRTF Filtering";
            this.disableHrtfCheckBox.UseVisualStyleBackColor = true;
            this.disableHrtfCheckBox.CheckedChanged += new System.EventHandler(this.disableHrtfCheckBox_CheckedChanged);
            // 
            // disableDistanceFilterCheckBox
            // 
            this.disableDistanceFilterCheckBox.AutoSize = true;
            this.disableDistanceFilterCheckBox.Location = new System.Drawing.Point(42, 128);
            this.disableDistanceFilterCheckBox.Name = "disableDistanceFilterCheckBox";
            this.disableDistanceFilterCheckBox.Size = new System.Drawing.Size(131, 17);
            this.disableDistanceFilterCheckBox.TabIndex = 4;
            this.disableDistanceFilterCheckBox.Text = "Disable Distance Filter";
            this.disableDistanceFilterCheckBox.UseVisualStyleBackColor = true;
            this.disableDistanceFilterCheckBox.CheckedChanged += new System.EventHandler(this.disableDistanceFilterCheckBox_CheckedChanged);
            // 
            // disableOcclusionFilterCheckBox
            // 
            this.disableOcclusionFilterCheckBox.AutoSize = true;
            this.disableOcclusionFilterCheckBox.Location = new System.Drawing.Point(42, 57);
            this.disableOcclusionFilterCheckBox.Name = "disableOcclusionFilterCheckBox";
            this.disableOcclusionFilterCheckBox.Size = new System.Drawing.Size(141, 17);
            this.disableOcclusionFilterCheckBox.TabIndex = 3;
            this.disableOcclusionFilterCheckBox.Text = "Disable Audio Occlusion";
            this.disableOcclusionFilterCheckBox.UseVisualStyleBackColor = true;
            this.disableOcclusionFilterCheckBox.CheckedChanged += new System.EventHandler(this.disableOcclusionFilterCheckBox_CheckedChanged);
            // 
            // disableMusicBox
            // 
            this.disableMusicBox.AutoSize = true;
            this.disableMusicBox.Location = new System.Drawing.Point(42, 104);
            this.disableMusicBox.Name = "disableMusicBox";
            this.disableMusicBox.Size = new System.Drawing.Size(92, 17);
            this.disableMusicBox.TabIndex = 2;
            this.disableMusicBox.Text = "Disable Music";
            this.disableMusicBox.UseVisualStyleBackColor = true;
            this.disableMusicBox.CheckedChanged += new System.EventHandler(this.disableMusicBox_CheckedChanged);
            // 
            // disableSoundBox
            // 
            this.disableSoundBox.AutoSize = true;
            this.disableSoundBox.Location = new System.Drawing.Point(42, 80);
            this.disableSoundBox.Name = "disableSoundBox";
            this.disableSoundBox.Size = new System.Drawing.Size(95, 17);
            this.disableSoundBox.TabIndex = 1;
            this.disableSoundBox.Text = "Disable Sound";
            this.disableSoundBox.UseVisualStyleBackColor = true;
            this.disableSoundBox.CheckedChanged += new System.EventHandler(this.disableSoundBox_CheckedChanged);
            // 
            // advancedPage
            // 
            this.advancedPage.Location = new System.Drawing.Point(4, 22);
            this.advancedPage.Name = "advancedPage";
            this.advancedPage.Size = new System.Drawing.Size(430, 335);
            this.advancedPage.TabIndex = 3;
            this.advancedPage.Text = "Advanced";
            this.advancedPage.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.BackgroundImage = global::WSE2_Launcher.Properties.Resources.button_background;
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(330, 416);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(116, 38);
            this.Cancel.TabIndex = 0;
            this.Cancel.TabStop = false;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BackgroundImage = global::WSE2_Launcher.Properties.Resources.button_background;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.Black;
            this.okButton.Location = new System.Drawing.Point(12, 416);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(116, 38);
            this.okButton.TabIndex = 0;
            this.okButton.TabStop = false;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(377, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(53, 54);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WSE2_Launcher.Properties.Resources.config_border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 466);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.closeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "ConfigForm";
            this.settingsTabControl.ResumeLayout(false);
            this.gamePage.ResumeLayout(false);
            this.gamePage.PerformLayout();
            this.videoPage.ResumeLayout(false);
            this.videoPage.PerformLayout();
            this.audioPage.ResumeLayout(false);
            this.audioPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton closeButton;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage gamePage;
        private System.Windows.Forms.TabPage videoPage;
        private ImageButton okButton;
        private ImageButton Cancel;
        private System.Windows.Forms.TabPage audioPage;
        private System.Windows.Forms.TabPage advancedPage;
        private System.Windows.Forms.CheckBox enableFpsCount;
        private System.Windows.Forms.CheckBox hideBloodBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.CheckBox textureBox;
        private System.Windows.Forms.CheckBox windowedBox;
        private System.Windows.Forms.CheckBox disableMusicBox;
        private System.Windows.Forms.CheckBox disableSoundBox;
        private System.Windows.Forms.CheckBox disableIntroBox;
        private System.Windows.Forms.CheckBox disableOcclusionFilterCheckBox;
        private System.Windows.Forms.CheckBox disableDistanceFilterCheckBox;
        private System.Windows.Forms.CheckBox disableHrtfCheckBox;
    }
}