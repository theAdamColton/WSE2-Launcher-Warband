
using System;
using System.Drawing;

namespace WSE2_Launcher
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.currentModLabel = new System.Windows.Forms.Label();
            this.moduleSelectBox = new System.Windows.Forms.ComboBox();
            this.playLabel = new WSE2_Launcher.MenuClickableLabel();
            this.minimizeButton = new WSE2_Launcher.ImageButton();
            this.closeButton = new WSE2_Launcher.ImageButton();
            this.cancelLabel = new WSE2_Launcher.MenuClickableLabel();
            this.configureLabel = new WSE2_Launcher.MenuClickableLabel();
            this.SuspendLayout();
            // 
            // currentModLabel
            // 
            this.currentModLabel.AutoSize = true;
            this.currentModLabel.Font = new System.Drawing.Font("Mordred", 18.25F, System.Drawing.FontStyle.Bold);
            this.currentModLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.currentModLabel.Location = new System.Drawing.Point(104, 179);
            this.currentModLabel.Name = "currentModLabel";
            this.currentModLabel.Size = new System.Drawing.Size(201, 29);
            this.currentModLabel.TabIndex = 1;
            this.currentModLabel.Text = "Current Module:";
            // 
            // moduleSelectBox
            // 
            this.moduleSelectBox.BackColor = System.Drawing.SystemColors.Window;
            this.moduleSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moduleSelectBox.Font = new System.Drawing.Font("Mordred", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleSelectBox.FormattingEnabled = true;
            this.moduleSelectBox.Location = new System.Drawing.Point(366, 179);
            this.moduleSelectBox.Name = "moduleSelectBox";
            this.moduleSelectBox.Size = new System.Drawing.Size(297, 25);
            this.moduleSelectBox.Sorted = true;
            this.moduleSelectBox.TabIndex = 2;
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.Font = new System.Drawing.Font("Mordred", 18.25F, System.Drawing.FontStyle.Bold);
            this.playLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playLabel.Location = new System.Drawing.Point(104, 256);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(52, 29);
            this.playLabel.TabIndex = 3;
            this.playLabel.Text = "Play";
            this.playLabel.Click += new System.EventHandler(this.playLabel_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Mordred", 12.25F, System.Drawing.FontStyle.Bold);
            this.minimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Location = new System.Drawing.Point(595, 48);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(39, 37);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Mordred", 12.25F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(640, 40);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(49, 51);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cancelLabel
            // 
            this.cancelLabel.AutoSize = true;
            this.cancelLabel.Font = new System.Drawing.Font("Mordred", 18.25F, System.Drawing.FontStyle.Bold);
            this.cancelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelLabel.Location = new System.Drawing.Point(104, 435);
            this.cancelLabel.Name = "cancelLabel";
            this.cancelLabel.Size = new System.Drawing.Size(87, 29);
            this.cancelLabel.TabIndex = 3;
            this.cancelLabel.Text = "Cancel";
            this.cancelLabel.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // configureLabel
            // 
            this.configureLabel.AutoSize = true;
            this.configureLabel.Font = new System.Drawing.Font("Mordred", 18.25F, System.Drawing.FontStyle.Bold);
            this.configureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.configureLabel.Location = new System.Drawing.Point(104, 343);
            this.configureLabel.Name = "configureLabel";
            this.configureLabel.Size = new System.Drawing.Size(121, 29);
            this.configureLabel.TabIndex = 3;
            this.configureLabel.Text = "Configure";
            this.configureLabel.Click += new System.EventHandler(this.configureLabel_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(201)))));
            this.BackgroundImage = global::WSE2_Launcher.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(834, 514);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cancelLabel);
            this.Controls.Add(this.configureLabel);
            this.Controls.Add(this.moduleSelectBox);
            this.Controls.Add(this.currentModLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LauncherForm";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(201)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentModLabel;
        private System.Windows.Forms.ComboBox moduleSelectBox;
        private MenuClickableLabel configureLabel;
        private MenuClickableLabel cancelLabel;
        private ImageButton closeButton;
        private ImageButton minimizeButton;
        private MenuClickableLabel playLabel;
    }
}

