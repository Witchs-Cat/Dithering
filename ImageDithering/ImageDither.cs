using System;
using System.Drawing;
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

            Bitmap ditheredBitmap = new Bitmap(xMax, yMax);
            IErrorDissipator dissipator = (errorDissipator ?? new FloydSteinbergDissipator());
            dissipator.CreateEmptyMap(xMax, yMax);

            for (int y = 0; y < yMax; y++)
            {
                for (int x = 0; x < xMax; x++)
                {
                    if (cancellation.IsCancellationRequested)
                    {
                        throw new TaskCanceledException($"The {nameof(RenderImage)} has been canceled");
                    }

                    Color originalPixelColor = _originalImage.GetPixel(x, y);
                    PixelError pixelError = dissipator.GetPixelError(x, y);
                    Color sumColor = Color.FromArgb(
                        ClipByte(originalPixelColor.R + (int)(pixelError.R * power)),
                        ClipByte(originalPixelColor.G + (int)(pixelError.G * power)),
                        ClipByte(originalPixelColor.B + (int)(pixelError.B * power)));

                    Color newPixelColor = pallete.FindClosestColor(sumColor);
                    PixelError newPixelError = new PixelError(
                       originalPixelColor.R - newPixelColor.R,
                       originalPixelColor.G - newPixelColor.G,
                       originalPixelColor.B - newPixelColor.B);

                    dissipator.DissipateError(x, y, newPixelError);
                    ditheredBitmap.SetPixel(x, y, newPixelColor);
                }
                Task.Run(() => RepainProgressEvent?.Invoke(Math.BigMul(xMax - 1, y), Math.BigMul(xMax, yMax)));
            }
            Task.Run(() => RepainCompletedEvent?.Invoke(_originalImage, ditheredBitmap));
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
