﻿namespace ImageDithering
{
    public interface IErrorDissipator
    {
        public void Initialize(int width, int height);
        public PixelError GetPixelError(int x, int y);
        public void DissipateError(int x, int y, PixelError newColor); 
    }
}
