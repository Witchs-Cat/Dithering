using FastBitmapLib;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;

namespace ImageDithering
{
    public class ImageDither
    {

        public event Action<long, long> RepainProgressEvent;
        public event Action<Bitmap, Bitmap> RepainCompletedEvent;

        private readonly Bitmap _originalImage;

        public ImageDither(Bitmap originalImage)
        {
            _originalImage = originalImage;
 
        }

        public ImageDither(Image originalImage) : this(new Bitmap(originalImage))
        { }

        public Bitmap RenderImage(Palette pallete, float power = 1, IErrorDissipator errorDissipator = null, CancellationToken cancellation = default)
        {
            int yMax = _originalImage.Height;
            int xMax = _originalImage.Width;

            Bitmap ditheredBitmap = new(xMax, yMax);
            using (FastBitmap fastOriginal = _originalImage.FastLock())
            {
                using (FastBitmap fastDitheredBitmap = ditheredBitmap.FastLock())
                {
                    ;
                    IErrorDissipator dissipator = (errorDissipator ?? new FloydSteinbergDissipator());
                    dissipator.CreateEmptyMap(xMax, yMax);

                    for (int y = 0; y < yMax; y++)
                    {
                        for (int x = 0; x < xMax; x++)
                        {
                            Color originalColor = fastOriginal.GetPixel(x, y);
                            dissipator.GetPixelError(x, y, out PixelError error);
                            Color sumColor = Color.FromArgb(
                                255,
                                ClipByte(originalColor.R + (int)(error.R * power)),
                                ClipByte(originalColor.G + (int)(error.G * power)),
                                ClipByte(originalColor.B + (int)(error.B * power)));

                            pallete.FindClosestColor(sumColor, out Color newColor);
                            PixelError newError = new(
                               sumColor.R - newColor.R,
                               sumColor.G - newColor.G,
                               sumColor.B - newColor.B);

                            dissipator.DissipateError(x, y, newError);
                            fastDitheredBitmap.SetPixel(x, y, newColor);
                        }
                        dissipator.ShiftLines();
                        RepainProgressEvent?.Invoke(Math.BigMul(xMax - 1, y), Math.BigMul(xMax, yMax));
                    }
                }
            }
            RepainCompletedEvent?.Invoke(_originalImage, ditheredBitmap);
            return ditheredBitmap;
        }

        public Task<Bitmap> RenderImageAsync(Palette pallete, float power = 1, IErrorDissipator errorDissipator = null, CancellationToken cancellation = default)
            => Task.Factory.StartNew(() => RenderImage(pallete, power, errorDissipator, cancellation));

        private static int ClipByte(int value)
        {
            if (value > 255)
                return 255;
            else if (value < 0)
                return 0;
            return value;
        }
    }
}
