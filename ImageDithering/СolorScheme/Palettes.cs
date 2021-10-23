using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace ImageDithering
{
    public sealed class Palettes: IEnumerable<Palette>
    {
        public static IEnumerable<Palette> _palettes = new Palette[]{
            new Palette("Solar Eclipse", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(255, 252, 254)),
                    Color.FromArgb(255,  Color.FromArgb(255, 194, 0)),
                    Color.FromArgb(255,  Color.FromArgb(255, 42, 0)),
                    Color.FromArgb(255,  Color.FromArgb(17, 7, 10)), }),

            new Palette("Monochrome",new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(255, 255,255)),
                    Color.FromArgb(255,  Color.FromArgb(0,0, 0)),}),

            new Palette("Gray 4", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(255, 255,255)),
                    Color.FromArgb(255,  Color.FromArgb(103, 103, 103)),
                    Color.FromArgb(255,  Color.FromArgb(182, 182, 182)),
                    Color.FromArgb(255,  Color.FromArgb(0,0,0,0)), }),

            new Palette("Lemon Lime GB", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(0xcdb81b)),
                    Color.FromArgb(255,  Color.FromArgb(0xafb525)),
                    Color.FromArgb(255,  Color.FromArgb(0x87b133)),
                    Color.FromArgb(255,  Color.FromArgb(0x5fad41)),}),

            new Palette("Pollen 8", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(0x73464C)),
                    Color.FromArgb(255,  Color.FromArgb(0xAB5675)),
                    Color.FromArgb(255,  Color.FromArgb(0xEE6A7C)),
                    Color.FromArgb(255,  Color.FromArgb(0xFFA7A5)),
                    Color.FromArgb(255,  Color.FromArgb(0xFFE07E)),
                    Color.FromArgb(255,  Color.FromArgb(0xFFE7D6)),
                    Color.FromArgb(255,  Color.FromArgb(0x72DCBB)),
                    Color.FromArgb(255,  Color.FromArgb(0x34ACBA)),}),

            new Palette("PC 88", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(0x0000DB)),
                    Color.FromArgb(255,  Color.FromArgb(0x00B6DB)),
                    Color.FromArgb(255,  Color.FromArgb(0x00DB6D)),
                    Color.FromArgb(255,  Color.FromArgb(0xFFB600)),
                    Color.FromArgb(255,  Color.FromArgb(0xFF926D)),
                    Color.FromArgb(255,  Color.FromArgb(0xDB0000)),
                    Color.FromArgb(255,  Color.FromArgb(0xDBDBDB)),
                    Color.FromArgb(255,  Color.FromArgb(0x000000)), }),

            new Palette("Pico 8", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(0x00000)),
                    Color.FromArgb(255,  Color.FromArgb(0xD2B53)),
                    Color.FromArgb(255,  Color.FromArgb(0xE2553)),
                    Color.FromArgb(255,  Color.FromArgb(0x08751)),
                    Color.FromArgb(255,  Color.FromArgb(0xB5236)),
                    Color.FromArgb(255,  Color.FromArgb(0xF574F)),
                    Color.FromArgb(255,  Color.FromArgb(0x2C3C7)),
                    Color.FromArgb(255,  Color.FromArgb(0xFF1E8)),
                    Color.FromArgb(255,  Color.FromArgb(0xF004D)),
                    Color.FromArgb(255,  Color.FromArgb(0xFA300)),
                    Color.FromArgb(255,  Color.FromArgb(0xFEC27)),
                    Color.FromArgb(255,  Color.FromArgb(0x0E436)),
                    Color.FromArgb(255,  Color.FromArgb(0x9ADFF)),
                    Color.FromArgb(255,  Color.FromArgb(0x3769C)),
                    Color.FromArgb(255,  Color.FromArgb(0xF77A8)),
                    Color.FromArgb(255,  Color.FromArgb(0xFCCAA)), }),

            new Palette("Apple II Lo Res", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(0x000000)),
                    Color.FromArgb(255,  Color.FromArgb(0x515c16)),
                    Color.FromArgb(255,  Color.FromArgb(0x843d52)),
                    Color.FromArgb(255,  Color.FromArgb(0xea7d27)),
                    Color.FromArgb(255,  Color.FromArgb(0x514888)),
                    Color.FromArgb(255,  Color.FromArgb(0xe85def)),
                    Color.FromArgb(255,  Color.FromArgb(0xf5b7c9)),
                    Color.FromArgb(255,  Color.FromArgb(0x006752)),
                    Color.FromArgb(255,  Color.FromArgb(0x00c82c)),
                    Color.FromArgb(255,  Color.FromArgb(0x919191)),
                    Color.FromArgb(255,  Color.FromArgb(0xc9d199)),
                    Color.FromArgb(255,  Color.FromArgb(0x00a6f0)),
                    Color.FromArgb(255,  Color.FromArgb(0x98dbc9)),
                    Color.FromArgb(255,  Color.FromArgb(0xc8c1f7)),
                    Color.FromArgb(255,  Color.FromArgb(0xffffff)), }),

            new Palette("Commodore 64", new Color[]{
                    Color.FromArgb(255,  Color.FromArgb(0x000000)),
                    Color.FromArgb(255,  Color.FromArgb(0x626262)),
                    Color.FromArgb(255,  Color.FromArgb(0x898989)),
                    Color.FromArgb(255,  Color.FromArgb(0xadadad)),
                    Color.FromArgb(255,  Color.FromArgb(0xffffff)),
                    Color.FromArgb(255,  Color.FromArgb(0x9f4e44)),
                    Color.FromArgb(255,  Color.FromArgb(0xcb7e75)),
                    Color.FromArgb(255,  Color.FromArgb(0x6d5412)),
                    Color.FromArgb(255,  Color.FromArgb(0xa1683c)),
                    Color.FromArgb(255,  Color.FromArgb(0xc9d487)),
                    Color.FromArgb(255,  Color.FromArgb(0x9ae29b)),
                    Color.FromArgb(255,  Color.FromArgb(0x5cab5e)),
                    Color.FromArgb(255,  Color.FromArgb(0x6abfc6)),
                    Color.FromArgb(255,  Color.FromArgb(0x887ecb)),
                    Color.FromArgb(255,  Color.FromArgb(0x50459b)),
                    Color.FromArgb(255,  Color.FromArgb(0xa057a3)), }),

            new Palette("Funky Future",new Color[]
                {
                    Color.FromArgb(255,  Color.FromArgb(0x2b0f54)),
                    Color.FromArgb(255,  Color.FromArgb(0xab1f65)),
                    Color.FromArgb(255,  Color.FromArgb(0xff4f69)),
                    Color.FromArgb(255,  Color.FromArgb(0xfff7f8)),
                    Color.FromArgb(255,  Color.FromArgb(0xff8142)),
                    Color.FromArgb(255,  Color.FromArgb(0xffda45)),
                    Color.FromArgb(255,  Color.FromArgb(0x3368dc)),
                    Color.FromArgb(255,  Color.FromArgb(0x49e7ec)),
                }),

            new Palette("ArgeeBey",  new Color[]
                {
                    Color.FromArgb(255,  Color.FromArgb(0x000000)),
                    Color.FromArgb(255,  Color.FromArgb(0x1f246a)),
                    Color.FromArgb(255,  Color.FromArgb(0x8a1181)),
                    Color.FromArgb(255,  Color.FromArgb(0xd14444)),
                    Color.FromArgb(255,  Color.FromArgb(0x2ca53e)),
                    Color.FromArgb(255,  Color.FromArgb(0x68cbcb)),
                    Color.FromArgb(255,  Color.FromArgb(0xe3c72d)),
                    Color.FromArgb(255,  Color.FromArgb(0xffffff)),
                }),

            new Palette("FuzzyFour", new Color[]
                {
                    Color.FromArgb(255,  Color.FromArgb(0x302387)),
                    Color.FromArgb(255,  Color.FromArgb(0xff3796)),
                    Color.FromArgb(255,  Color.FromArgb(0x00faac)),
                    Color.FromArgb(255,  Color.FromArgb(0xfffdaf)),
                }),

            new Palette("Ceral GB",new Color[]
                {
                    Color.FromArgb(255,  Color.FromArgb(0x2b061e)),
                    Color.FromArgb(255,  Color.FromArgb(0x875053)),
                    Color.FromArgb(255,  Color.FromArgb(0xd8c86e)),
                    Color.FromArgb(255,  Color.FromArgb(0xffeed6)),
                }),

            new Palette("HUC 16", new Color[]
                {
                    Color.FromArgb(255,  Color.FromArgb(0xffffff)),
                    Color.FromArgb(255,  Color.FromArgb(0xffcc4e)),
                    Color.FromArgb(255,  Color.FromArgb(0xfa7033)),
                    Color.FromArgb(255,  Color.FromArgb(0xe52f1b)),
                    Color.FromArgb(255,  Color.FromArgb(0x000000)),
                    Color.FromArgb(255,  Color.FromArgb(0x371b14)),
                    Color.FromArgb(255,  Color.FromArgb(0x733525)),
                    Color.FromArgb(255,  Color.FromArgb(0xfaa1b2)),
                    Color.FromArgb(255,  Color.FromArgb(0x9a8aa6)),
                    Color.FromArgb(255,  Color.FromArgb(0x227d66)),
                    Color.FromArgb(255,  Color.FromArgb(0x787878)),
                    Color.FromArgb(255,  Color.FromArgb(0x293a72)),
                    Color.FromArgb(255,  Color.FromArgb(0x6ea763)),
                    Color.FromArgb(255,  Color.FromArgb(0x244e32)),
                }),

            new Palette("ASPIRIA-32", new Color[]
                {
                    Color.FromArgb(255,  Color.FromArgb(0x141415)),
                    Color.FromArgb(255,  Color.FromArgb(0x53545a)),
                    Color.FromArgb(255,  Color.FromArgb(0x787981)),
                    Color.FromArgb(255,  Color.FromArgb(0xa9a9b1)),
                    Color.FromArgb(255,  Color.FromArgb(0xffffff)),
                    Color.FromArgb(255,  Color.FromArgb(0x2a0707)),
                    Color.FromArgb(255,  Color.FromArgb(0x681717)),
                    Color.FromArgb(255,  Color.FromArgb(0xd16363)),
                    Color.FromArgb(255,  Color.FromArgb(0x6a3b19)),
                    Color.FromArgb(255,  Color.FromArgb(0xa34f12)),
                    Color.FromArgb(255,  Color.FromArgb(0xd7864a)),
                    Color.FromArgb(255,  Color.FromArgb(0x8c6315)),
                    Color.FromArgb(255,  Color.FromArgb(0xc69933)),
                    Color.FromArgb(255,  Color.FromArgb(0xdbbc4a)),
                    Color.FromArgb(255,  Color.FromArgb(0xeeda8c)),
                    Color.FromArgb(255,  Color.FromArgb(0x052d18)),
                    Color.FromArgb(255,  Color.FromArgb(0x115924)),
                    Color.FromArgb(255,  Color.FromArgb(0x3db335)),
                    Color.FromArgb(255,  Color.FromArgb(0x85dd65)),
                    Color.FromArgb(255,  Color.FromArgb(0x0f573d)),
                    Color.FromArgb(255,  Color.FromArgb(0x24846e)),
                    Color.FromArgb(255,  Color.FromArgb(0x41afa8)),
                    Color.FromArgb(255,  Color.FromArgb(0x7cdfd9)),
                    Color.FromArgb(255,  Color.FromArgb(0x0a163b)),
                    Color.FromArgb(255,  Color.FromArgb(0x17266b)),
                    Color.FromArgb(255,  Color.FromArgb(0x2e349a)),
                    Color.FromArgb(255,  Color.FromArgb(0x4d4ac7)),
                    Color.FromArgb(255,  Color.FromArgb(0x47176b)),
                    Color.FromArgb(255,  Color.FromArgb(0x602e9a)),
                    Color.FromArgb(255,  Color.FromArgb(0x6c4ac7)),
                    Color.FromArgb(255,  Color.FromArgb(0x8e8bea)),
                })
        };

        public static IEnumerable<string> GetNames()
            => _palettes.Select(x => x.Name);

        public static Palette GetByName(string name)
            => _palettes.FirstOrDefault(x => x.Name == name);

        public  IEnumerator<Palette> GetEnumerator()
            => _palettes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => _palettes.GetEnumerator();
    }
}
