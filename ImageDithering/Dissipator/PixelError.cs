namespace ImageDithering
{
    public struct PixelError
    {
        public int R;
        public int G;
        public int B;

        public PixelError(int r, int g, int b)
        {
            this.R = r;
            this.B = b;
            this.G = g;
        }
    }
}