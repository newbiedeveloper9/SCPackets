using System;
using Network.Attributes;
using SharpDj.Common.Helpers;

namespace SCPackets.Models
{
    public class Color
    {
        public byte[] RGB { get; private set; } = new byte[3];

        public Color SetColor(byte[] rgb)
        {
            RGB = rgb;

            return this;
        }

        public Color SetColor(string hex)
        {
            RGB = HexHelper.StringToByteArray(hex);

            return this;
        }

        public string GetHex => HexHelper.BytesToString(RGB);

        public override string ToString()
        {
            return GetHex;
        }
    }
}
