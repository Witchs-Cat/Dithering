using System;
using System.Drawing;

namespace ImageDithering
{
    public sealed class Palette : BasePalette
    {
        public Palette(string name, params Color[] colors) : base(name, colors)
        { }

        public override Color FindClosestColor(Color inputColor)
        {            
            Color resultColor = default;
            int minDist = int.MaxValue;

            foreach (Color paletteColor in Colors)
            {
                int dist = CalcColorDist(paletteColor, inputColor);
                if (dist < minDist)
                {
                    minDist = dist;
                    resultColor = paletteColor;
                }
            }
            return resultColor;

        }

        private static int CalcColorDist(Color color1, Color color2)
        {
            int distR = color1.R - color2.R;
            int distG = color1.G - color2.G;
            int distB = color1.B - color2.B;
            return distR*distR + distG*distG + distB*distB;
        }

    }
}