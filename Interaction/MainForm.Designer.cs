
namespace Interaction
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.TimeSpanLabel = new System.Windows.Forms.Label();
            this.PalettesComboBox = new System.Windows.Forms.ComboBox();
            this.DitheringProgressBar = new System.Windows.Forms.ProgressBar();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PaletteLabel = new System.Windows.Forms.Label();
            this.PowerTrackBar = new System.Windows.Forms.TrackBar();
            this.DitherPicture = new System.Windows.Forms.Button();
            this.LoadPicture = new System.Windows.Forms.Button();
            this.PicturesContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.DitheredPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenOriginalPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDitheredPictureDialog = new System.Windows.Forms.SaveFileDialog();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturesContainer)).BeginInit();
            this.PicturesContainer.Panel1.SuspendLayout();
            this.PicturesContainer.Panel2.SuspendLayout();
            this.PicturesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DitheredPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonsPanel.Controls.Add(this.TimeSpanLabel);
            this.ButtonsPanel.Controls.Add(this.PalettesComboBox);
            this.ButtonsPanel.Controls.Add(this.DitheringProgressBar);
            this.ButtonsPanel.Controls.Add(this.PowerLabel);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Controls.Add(this.PaletteLabel);
            this.ButtonsPanel.Controls.Add(this.PowerTrackBar);
            this.ButtonsPanel.Controls.Add(this.DitherPicture);
            this.ButtonsPanel.Controls.Add(this.LoadPicture);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 357);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(800, 93);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // TimeSpanLabel
            // 
            this.TimeSpanLabel.AutoSize = true;
            this.TimeSpanLabel.Location = new System.Drawing.Point(153, 67);
            this.TimeSpanLabel.Name = "TimeSpanLabel";
            this.TimeSpanLabel.Size = new System.Drawing.Size(119, 15);
            this.TimeSpanLabel.TabIndex = 2;
            this.TimeSpanLabel.Text = "Затрачено времени:";
            this.TimeSpanLabel.Visible = false;
            // 
            // PalettesComboBox
            // 
            this.PalettesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PalettesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PalettesComboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PalettesComboBox.FormattingEnabled = true;
            this.PalettesComboBox.Location = new System.Drawing.Point(154, 28);
            this.PalettesComboBox.Name = "PalettesComboBox";
            this.PalettesComboBox.Size = new System.Drawing.Size(117, 23);
            this.PalettesComboBox.TabIndex = 17;
            // 
            // DitheringProgressBar
            // 
            this.DitheringProgressBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DitheringProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DitheringProgressBar.ForeColor = System.Drawing.Color.DarkSalmon;
            this.DitheringProgressBar.Location = new System.Drawing.Point(0, 92);
            this.DitheringProgressBar.Name = "DitheringProgressBar";
            this.DitheringProgressBar.Size = new System.Drawing.Size(800, 1);
            this.DitheringProgressBar.TabIndex = 12;
            this.DitheringProgressBar.Visible = false;
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(274, 9);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(67, 15);
            this.PowerLabel.TabIndex = 16;
            this.PowerLabel.Text = "Мощность";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(12, 67);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Сохранить результат";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PaletteLabel
            // 
            this.PaletteLabel.AutoSize = true;
            this.PaletteLabel.Location = new System.Drawing.Point(154, 9);
            this.PaletteLabel.Name = "PaletteLabel";
            this.PaletteLabel.Size = new System.Drawing.Size(54, 15);
            this.PaletteLabel.TabIndex = 15;
            this.PaletteLabel.Text = "Палитра";
            // 
            // PowerTrackBar
            // 
            this.PowerTrackBar.Location = new System.Drawing.Point(269, 28);
            this.PowerTrackBar.Maximum = 1000;
            this.PowerTrackBar.Name = "PowerTrackBar";
            this.PowerTrackBar.Size = new System.Drawing.Size(83, 45);
            this.PowerTrackBar.SmallChange = 10;
            this.PowerTrackBar.TabIndex = 13;
            this.PowerTrackBar.TickFrequency = 100;
            this.PowerTrackBar.Value = 100;
            // 
            // DitherPicture
            // 
            this.DitherPicture.BackColor = System.Drawing.Color.RoyalBlue;
            this.DitherPicture.FlatAppearance.BorderSize = 0;
            this.DitherPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DitherPicture.Location = new System.Drawing.Point(12, 9);
            this.DitherPicture.Name = "DitherPicture";
            this.DitherPicture.Size = new System.Drawing.Size(135, 23);
            this.DitherPicture.TabIndex = 11;
            this.DitherPicture.Text = "Дизеринг";
            this.DitherPicture.UseVisualStyleBackColor = false;
            this.DitherPicture.Click += new System.EventHandler(this.DitherPicture_Click);
            // 
            // LoadPicture
            // 
            this.LoadPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LoadPicture.FlatAppearance.BorderSize = 0;
            this.LoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPicture.Location = new System.Drawing.Point(12, 38);
            this.LoadPicture.Name = "LoadPicture";
            this.LoadPicture.Size = new System.Drawing.Size(135, 23);
            this.LoadPicture.TabIndex = 9;
            this.LoadPicture.Text = "Выбрать файл...";
            this.LoadPicture.UseVisualStyleBackColor = false;
            this.LoadPicture.Click += new System.EventHandler(this.LoadPicture_Click);
            // 
            // PicturesContainer
            // 
            this.PicturesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PicturesContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.PicturesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicturesContainer.IsSplitterFixed = true;
            this.PicturesContainer.Location = new System.Drawing.Point(0, 0);
            this.PicturesContainer.Name = "PicturesContainer";
            // 
            // PicturesContainer.Panel1
            // 
            this.PicturesContainer.Panel1.AllowDrop = true;
            this.PicturesContainer.Panel1.AutoScroll = true;
            this.PicturesContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PicturesContainer.Panel1.Controls.Add(this.OriginalPictureBox);
            this.PicturesContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // PicturesContainer.Panel2
            // 
            this.PicturesContainer.Panel2.AllowDrop = true;
            this.PicturesContainer.Panel2.AutoScroll = true;
            this.PicturesContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PicturesContainer.Panel2.Controls.Add(this.DitheredPictureBox);
            this.PicturesContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicturesContainer.Size = new System.Drawing.Size(800, 357);
            this.PicturesContainer.SplitterDistance = 395;
            this.PicturesContainer.SplitterWidth = 10;
            this.PicturesContainer.TabIndex = 1;
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.OriginalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(395, 357);
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            // 
            // DitheredPictureBox
            // 
            this.DitheredPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DitheredPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DitheredPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DitheredPictureBox.Location = new System.Drawing.Point(0, 0);
            this.DitheredPictureBox.Name = "DitheredPictureBox";
            this.DitheredPictureBox.Size = new System.Drawing.Size(395, 357);
            this.DitheredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DitheredPictureBox.TabIndex = 1;
            this.DitheredPictureBox.TabStop = false;
            // 
            // OpenOriginalPictureDialog
            // 
            this.OpenOriginalPictureDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicturesContainer);
            this.Controls.Add(this.ButtonsPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "Дизеринг изображения";
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackBar)).EndInit();
            this.PicturesContainer.Panel1.ResumeLayout(false);
            this.PicturesContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturesContainer)).EndInit();
            this.PicturesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DitheredPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.SplitContainer PicturesContainer;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.PictureBox DitheredPictureBox;
        private System.Windows.Forms.ProgressBar DitheringProgressBar;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label PaletteLabel;
        private System.Windows.Forms.TrackBar PowerTrackBar;
        private System.Windows.Forms.Button DitherPicture;
        private System.Windows.Forms.Button LoadPicture;
        private System.Windows.Forms.OpenFileDialog OpenOriginalPictureDialog;
        private System.Windows.Forms.SaveFileDialog SaveDitheredPictureDialog;
        private System.Windows.Forms.ComboBox PalettesComboBox;
        private System.Windows.Forms.Label TimeSpanLabel;
    }
}

