using System.Drawing;
using System.Linq;

namespace ImageDithering
{
    internal class FloydSteinbergDissipator : IErrorDissipator
    {
        private PixelError[][] _errorMatrix;
        public void DissipateError(int x, int y, PixelError pixelError)
        {

            // [             *     7/16(0) ]
            // [ 3/16(1)  5/16(2)  1/16(3) ]
            // 0
            if (x + 1 < _errorMatrix[y].Length)
            {
                _errorMatrix[y][x + 1].R += pixelError.R * 7 / 16;
                _errorMatrix[y][x + 1].G += pixelError.G * 7 / 16;
                _errorMatrix[y][x + 1].B += pixelError.B * 7 / 16;
            }

            if (y + 1 >= _errorMatrix.Length)
            {
                return;
            }
            //1
            if ( x - 1 > 0)
            {
                _errorMatrix[y + 1][x - 1].R += pixelError.R * 3 / 16;
                _errorMatrix[y + 1][x - 1].G += pixelError.G * 3 / 16;
                _errorMatrix[y + 1][x - 1].B += pixelError.B * 3 / 16;
            }
            //2                                               
            _errorMatrix[y + 1][x].R += pixelError.R * 5 / 16;
            _errorMatrix[y + 1][x].G += pixelError.G * 5 / 16;
            _errorMatrix[y + 1][x].B += pixelError.B * 5 / 16;
            //3
            if (x + 1 < _errorMatrix[ y + 1].Length)
            {
                _errorMatrix[y + 1][x + 1].R += pixelError.R * 1 / 16;
                _errorMatrix[y + 1][x + 1].G += pixelError.G * 1 / 16;
                _errorMatrix[y + 1][x + 1].B += pixelError.B * 1 / 16;
            }
        }

        public PixelError GetPixelError(int x, int y)
        {
            if (!_errorMatrix.Any() || _errorMatrix.Length <= y || _errorMatrix[0].Length <= x)
                return new PixelError(255, 255, 255);

            return _errorMatrix[y][x];
        }

        public void Initialize(int width, int height)
        {
            _errorMatrix = new PixelError[height][];
            for (int _ = 0; _ < height; _++)
            {
                _errorMatrix[_] = new PixelError[width];
            }
        }
    }
}