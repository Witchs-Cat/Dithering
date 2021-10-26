namespace ImageDithering.Dissipator
{
    public sealed class PrimitiveDissipator : IErrorDissipator
    {
        private PixelError[] _currentLine;
        public void DissipateError(int x, int y, PixelError pixelError)
        {
            // 0
            _currentLine[x + 1].R += pixelError.R;
            _currentLine[x + 1].G += pixelError.G;
            _currentLine[x + 1].B += pixelError.B;
        }

        public PixelError GetPixelError(int x, int y)
            => _currentLine[x];

        public void CreateEmptyMap(int width, int height)
        {
            _currentLine = new PixelError[width+1];
        }

        public void ShiftLines()
        {
            _currentLine = new PixelError[_currentLine.Length];
        }
    }
}