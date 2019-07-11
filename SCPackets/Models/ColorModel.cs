using System;
using System.Windows.Media;
using Network.Attributes;

namespace SCPackets.Models
{
    public class ColorModel
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public ColorModel(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public ColorModel(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex))
                throw new ArgumentException(hex);

            var brush = (SolidColorBrush)(new BrushConverter().ConvertFrom(hex));

            if(brush?.Color == null)
                throw new ArgumentException(hex);

            R = brush.Color.R;
            G = brush.Color.G;
            B = brush.Color.B;
        }


        public override string ToString()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }

        [PacketIgnoreProperty]
        public string GetHex => ToString();
    }
}
