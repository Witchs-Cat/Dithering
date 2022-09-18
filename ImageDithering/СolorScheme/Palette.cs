using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageDithering
{
    public sealed class Palette
    {
        public readonly string Name;
        public readonly IEnumerable<Color> Colors;
        
        public Palette(string name, IEnumerable<Color> colors)
        {
            Name = name;
            Colors = colors;
        }

        public void FindClosestColor(in Color inputColor, out Color resultColor)
        {            
            resultColor = default;
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
        }

        private static int CalcColorDist(in Color color1, in Color color2)
        {
            int distR = color1.R - color2.R;
            int distG = color1.G - color2.G;
            int distB = color1.B - color2.B;
            return distR*distR + distG*distG + distB*distB;
        }

    }
}