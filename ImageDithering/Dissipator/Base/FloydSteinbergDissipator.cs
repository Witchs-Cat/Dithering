using System.Linq;

namespace ImageDithering
{
    // [             *     7/16(0) ]
    // [ 3/16(1)  5/16(2)  1/16(3) ]
    public sealed class FloydSteinbergDissipator : IErrorDissipator
    {
        private PixelError[] _currentLine;
        private PixelError[] _nextLine;
        public void DissipateError(int x, int y, PixelError pixelError)
        {
            // 0
            _currentLine[x + 2].R += pixelError.R * 7 / 16;
            _currentLine[x + 2].G += pixelError.G * 7 / 16;
            _currentLine[x + 2].B += pixelError.B * 7 / 16;
            //1
            _nextLine[x].R += pixelError.R * 3 / 16;
            _nextLine[x].G += pixelError.G * 3 / 16;
            _nextLine[x].B += pixelError.B * 3 / 16;
            //2                                               
            _nextLine[x + 1].R += pixelError.R * 5 / 16;
            _nextLine[x + 1].G += pixelError.G * 5 / 16;
            _nextLine[x + 1].B += pixelError.B * 5 / 16;
            //3
            _nextLine[x + 2].R += pixelError.R * 1 / 16;
            _nextLine[x + 2].G += pixelError.G * 1 / 16;
            _nextLine[x + 2].B += pixelError.B * 1 / 16;
        }

        public PixelError GetPixelError(int x, int y)
        =>_currentLine[x + 1];

        public void CreateEmptyMap(int width, int height)
        {
            _currentLine = new PixelError[width + 2];
            _nextLine = new PixelError[width + 2];
        }

        public void ShiftLines()
        {
            _currentLine = _nextLine;
            _nextLine = new PixelError[_nextLine.Length];
        }
    }
}