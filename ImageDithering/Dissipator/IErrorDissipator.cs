namespace ImageDithering
{
    public interface IErrorDissipator
    {
        public void CreateEmptyMap(int width, int height);
        public void GetPixelError(int x, int y, out PixelError error);
        public void DissipateError(int x, int y, in PixelError newColor);
        public void ShiftLines();
    }
}
