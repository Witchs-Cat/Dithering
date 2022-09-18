using System.Linq;


namespace ImageDithering.Dissipator
{
    /*
    [          *       2/4(0) ]
    [1/4(1)   1/4(2)          ]
    */
    public class SierraLiteDissipator : IErrorDissipator
    {
        private PixelError[] _currentLine;
        private PixelError[] _secondLine;
        public void DissipateError(int x, int y, in PixelError pixelError)
        {
            // 0
            _currentLine[x + 2].R += pixelError.R / 2;
            _currentLine[x + 2].G += pixelError.G / 2;
            _currentLine[x + 2].B += pixelError.B / 2;
            //2                                               
            _secondLine[x].R += pixelError.R / 4;
            _secondLine[x].G += pixelError.G / 4;
            _secondLine[x].B += pixelError.B / 4;
            //3
            _secondLine[x + 1].R += pixelError.R / 4;
            _secondLine[x + 1].G += pixelError.G / 4;
            _secondLine[x + 1].B += pixelError.B / 4;
        }

        public void GetPixelError(int x, int y, out PixelError error)
            => error = _currentLine[x + 1];

        public void CreateEmptyMap(int width, int height)
        {
            _currentLine = new PixelError[width + 2];
            _secondLine = new PixelError[width + 2];
        }

        public void ShiftLines()
        {
            _currentLine = _secondLine;
            _secondLine = new PixelError[_secondLine.Length];
        }
    }
}
