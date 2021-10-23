using System.Collections.Generic;
using System.Drawing;

namespace ImageDithering
{
    public abstract class BasePalette
    {
        public readonly string Name;
        public readonly IEnumerable<Color> Colors;
        public BasePalette(string name, IEnumerable<Color> colors)
        {
            Name = name;
            Colors = colors;
        }
        public abstract Color FindClosestColor(Color inputColor);
    }
}
