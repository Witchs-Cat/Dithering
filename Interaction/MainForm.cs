using ImageDithering;
using ImageDithering.Dissipator;
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
        private Type[] _dissipators = new Type[] { typeof(FloydSteinbergDissipator), typeof(PrimitiveDissipator), typeof(SierraLiteDissipator) };

        public MainForm()
        {
            _tokenSource = new CancellationTokenSource();
            InitializeComponent();
            PalettesComboBox.Items.AddRange(Palettes.GetNames().ToArray());
            PalettesComboBox.SelectedIndex = 0;
            PalettesComboBox.Update();
            AlgorithmComboBox.Items.AddRange(_dissipators.Select(x => x.Name).ToArray());
            AlgorithmComboBox.SelectedIndex = 0;
            AlgorithmComboBox.Update();
        }

        private void LoadPicture_Click(object sender, EventArgs e)
        {
            OriginalPictureBox.Image?.Dispose();
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
                DitheredPictureBox.Image?.Dispose();
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
            
            int paletteIndex = PalettesComboBox.SelectedIndex;

            Bitmap originalImage = new Bitmap(OriginalPictureBox.Image);
            Palette palette = new Palettes().ElementAt((paletteIndex < 0)? 0: paletteIndex);
            float power = PowerTrackBar.Value / 100.0f;
            IErrorDissipator dissipator = DefineDissipator();

            ImageDither dither = new ImageDither(originalImage);
            dither.RepainProgressEvent += RepainProgres;
            dither.RepainCompletedEvent += OnRepainCompleted;
            DateTimeOffset startTime = DateTimeOffset.Now;
            dither.RenderImageAsync(palette, power, dissipator, cancellation: _tokenSource.Token)
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
                        originalImage.Dispose();
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
            DitheredPictureBox.Image.Save(stream, ImageFormat.Png);
        }

        public IErrorDissipator DefineDissipator()
        {
            int selectedIndex = AlgorithmComboBox.SelectedIndex;
            Type dissipatorType = _dissipators.ElementAt((selectedIndex < 0) ? 0 : selectedIndex);

            if (dissipatorType == typeof(FloydSteinbergDissipator))
                return new FloydSteinbergDissipator();
            if (dissipatorType == typeof(PrimitiveDissipator))
                return new PrimitiveDissipator();
            if (dissipatorType == typeof(SierraLiteDissipator))
                return new SierraLiteDissipator();
            return new SierraLiteDissipator();
        }

        public string GenerateRandomName()
        {
            string str = "";
            Random random = new Random();
            for (int _ = 0; _ < 6; _++)
            {
                str += (char)random.Next(65, 91);
            }
            return str.ToLower();
        }
    }
}
