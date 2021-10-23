
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
            this.ButtonsContainer = new System.Windows.Forms.SplitContainer();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PaletteLabel = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.DitherPicture = new System.Windows.Forms.Button();
            this.LoadPicture = new System.Windows.Forms.Button();
            this.DitheringProgressBar = new System.Windows.Forms.ProgressBar();
            this.PicturesContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.DitheredPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsContainer)).BeginInit();
            this.ButtonsContainer.Panel1.SuspendLayout();
            this.ButtonsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.ButtonsPanel.Controls.Add(this.ButtonsContainer);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 357);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(800, 93);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.ButtonsContainer.Name = "ButtonsContainer";
            // 
            // ButtonsContainer.Panel1
            // 
            this.ButtonsContainer.Panel1.Controls.Add(this.TimeoutLabel);
            this.ButtonsContainer.Panel1.Controls.Add(this.DitheringProgressBar);
            this.ButtonsContainer.Panel1.Controls.Add(this.PowerLabel);
            this.ButtonsContainer.Panel1.Controls.Add(this.SaveButton);
            this.ButtonsContainer.Panel1.Controls.Add(this.PaletteLabel);
            this.ButtonsContainer.Panel1.Controls.Add(this.treeView1);
            this.ButtonsContainer.Panel1.Controls.Add(this.trackBar1);
            this.ButtonsContainer.Panel1.Controls.Add(this.DitherPicture);
            this.ButtonsContainer.Panel1.Controls.Add(this.LoadPicture);
            this.ButtonsContainer.Size = new System.Drawing.Size(800, 93);
            this.ButtonsContainer.SplitterDistance = 395;
            this.ButtonsContainer.SplitterWidth = 10;
            this.ButtonsContainer.TabIndex = 0;
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(127, 48);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(67, 15);
            this.PowerLabel.TabIndex = 8;
            this.PowerLabel.Text = "Мощность";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(208, 18);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // PaletteLabel
            // 
            this.PaletteLabel.AutoSize = true;
            this.PaletteLabel.Location = new System.Drawing.Point(12, 48);
            this.PaletteLabel.Name = "PaletteLabel";
            this.PaletteLabel.Size = new System.Drawing.Size(54, 15);
            this.PaletteLabel.TabIndex = 7;
            this.PaletteLabel.Text = "Палитра";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(12, 66);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(109, 15);
            this.treeView1.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(127, 66);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(83, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 100;
            // 
            // DitherPicture
            // 
            this.DitherPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DitherPicture.FlatAppearance.BorderSize = 0;
            this.DitherPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DitherPicture.Location = new System.Drawing.Point(127, 18);
            this.DitherPicture.Name = "DitherPicture";
            this.DitherPicture.Size = new System.Drawing.Size(75, 23);
            this.DitherPicture.TabIndex = 4;
            this.DitherPicture.Text = "Дизеринг";
            this.DitherPicture.UseVisualStyleBackColor = false;
            // 
            // LoadPicture
            // 
            this.LoadPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LoadPicture.FlatAppearance.BorderSize = 0;
            this.LoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPicture.Location = new System.Drawing.Point(12, 18);
            this.LoadPicture.Name = "LoadPicture";
            this.LoadPicture.Size = new System.Drawing.Size(109, 23);
            this.LoadPicture.TabIndex = 3;
            this.LoadPicture.Text = "Выбрать файл...";
            this.LoadPicture.UseVisualStyleBackColor = false;
            // 
            // DitheringProgressBar
            // 
            this.DitheringProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DitheringProgressBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DitheringProgressBar.ForeColor = System.Drawing.Color.DarkSalmon;
            this.DitheringProgressBar.Location = new System.Drawing.Point(261, 66);
            this.DitheringProgressBar.Name = "DitheringProgressBar";
            this.DitheringProgressBar.Size = new System.Drawing.Size(131, 15);
            this.DitheringProgressBar.TabIndex = 5;
            this.DitheringProgressBar.Visible = false;
            // 
            // PicturesContainer
            // 
            this.PicturesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
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
            this.PicturesContainer.Panel1.Controls.Add(this.OriginalPictureBox);
            this.PicturesContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // PicturesContainer.Panel2
            // 
            this.PicturesContainer.Panel2.AllowDrop = true;
            this.PicturesContainer.Panel2.AutoScroll = true;
            this.PicturesContainer.Panel2.BackColor = System.Drawing.Color.White;
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
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            // 
            // DitheredPictureBox
            // 
            this.DitheredPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.DitheredPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DitheredPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DitheredPictureBox.Location = new System.Drawing.Point(0, 0);
            this.DitheredPictureBox.Name = "DitheredPictureBox";
            this.DitheredPictureBox.Size = new System.Drawing.Size(395, 357);
            this.DitheredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DitheredPictureBox.TabIndex = 1;
            this.DitheredPictureBox.TabStop = false;
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(301, 26);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(0, 15);
            this.TimeoutLabel.TabIndex = 9;
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
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "Дизеринг изображения";
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsContainer.Panel1.ResumeLayout(false);
            this.ButtonsContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsContainer)).EndInit();
            this.ButtonsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.PicturesContainer.Panel1.ResumeLayout(false);
            this.PicturesContainer.Panel1.PerformLayout();
            this.PicturesContainer.Panel2.ResumeLayout(false);
            this.PicturesContainer.Panel2.PerformLayout();
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
        private System.Windows.Forms.Button LoadPicture;
        private System.Windows.Forms.SplitContainer ButtonsContainer;
        private System.Windows.Forms.Button DitherPicture;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ProgressBar DitheringProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label PaletteLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label TimeoutLabel;
    }
}

