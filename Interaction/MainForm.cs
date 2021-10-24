﻿using ImageDithering;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interaction
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource _tokenSource;
        public MainForm()
        {
            _tokenSource = new CancellationTokenSource();
            InitializeComponent();
            PalettesComboBox.Items.AddRange(Palettes.GetNames().ToArray());
            PalettesComboBox.Update();
        }

        private void LoadPicture_Click(object sender, EventArgs e)
        {
            if (OpenOriginalPictureDialog.ShowDialog() != DialogResult.OK)
                return;
            using Stream fileStream = OpenOriginalPictureDialog.OpenFile();
            Image image = Image.FromStream(fileStream);
            OriginalPictureBox.Image = image;
            OriginalPictureBox.Update();
        }

        private void RepainProgres(long repaintedSquare, long totalSquare)
        {
            var newValue = Convert.ToInt32(Math.Round(repaintedSquare / (double)totalSquare * 100));
            DitheringProgressBar.Invoke((Action)(() =>
            {
                DitheringProgressBar.Value = newValue;
                DitheringProgressBar.Update();
            }));
        }
        private void OnRepainCompleted(Bitmap beforeImage, Bitmap afterImage)
        {

            DitheredPictureBox.Invoke((Action)(() =>
            {
                DitheredPictureBox.Image = afterImage;
                DitheredPictureBox.Update();
            }));
            DitheringProgressBar.Invoke((Action)(() =>
            {
                DitheringProgressBar.Visible = false;
                DitheringProgressBar.Update();
            }));
        }

        private void DitherPicture_Click(object sender, EventArgs e)
        {
            if (OriginalPictureBox.Image == null)
                return;

            TimeSpanLabel.Visible = false;
            TimeSpanLabel.Update();

            DitheringProgressBar.Visible = true;
            DitheringProgressBar.Update();

            _tokenSource.Cancel();
            _tokenSource = new CancellationTokenSource();

            DateTimeOffset startTime = DateTimeOffset.Now;
            int paletteIndex = PalettesComboBox.SelectedIndex;

            Bitmap originalImage = new Bitmap(OriginalPictureBox.Image);
            Palette palette = new Palettes().ElementAt((paletteIndex < 0)? 0: paletteIndex);
            float power = PowerTrackBar.Value / 100.0f;


            ImageDither dither = new ImageDither(originalImage);
            dither.RepainProgressEvent += RepainProgres;
            dither.RepainCompletedEvent += OnRepainCompleted;
            dither.RenderImageAsync(palette, power, cancellation: _tokenSource.Token)
                .ContinueWith(task =>
                    {
                        if (task.Status != TaskStatus.RanToCompletion)
                            return;
                        var timeSpan = DateTimeOffset.Now - startTime;
                        TimeSpanLabel.Invoke((Action)(() =>
                        {
                            TimeSpanLabel.Visible = true;
                            TimeSpanLabel.Text = $"{timeSpan.TotalSeconds} c.";
                            TimeSpanLabel.Update();
                        }));
                    });
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DitheredPictureBox.Image == null)
                return;

            SaveDitheredPictureDialog.FileName = GenerateRandomName();
            SaveDitheredPictureDialog.DefaultExt = ImageFormat.Jpeg.ToString();
            if (SaveDitheredPictureDialog.ShowDialog() != DialogResult.OK)
                return;

            using var stream = SaveDitheredPictureDialog.OpenFile();
            DitheredPictureBox.Image.Save(stream, ImageFormat.Jpeg);
        }

        public string GenerateRandomName()
        {
            string str = "";
            Random random = new Random();
            for (int _ = 0; _ < 40; _++)
            {
                str += (char)random.Next(65, 91);
            }
            return str;
        }
    }
}
