using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;

        public Colour()
        {
            colour = 0;
        }

        public Colour(byte r, byte g, byte b, byte a)
        {
            colour = (UInt32)(r << 24) + (UInt32)(g << 16) + (UInt32)(b << 8) + (UInt32)(a << 0);
        }

        public byte GetRed()
        {
            return (byte)(colour >> 24);
        }
        public void SetRed(byte r)
        {
            colour = (UInt32)r << 24;
        }

        public byte GetGreen()
        {
            return (byte)(colour >> 16);
        }
        public void SetGreen(byte g)
        {
            colour = (UInt32)g << 16;
        }

        public byte GetBlue()
        {
            return (byte)(colour >> 8);
        }
        public void SetBlue(byte b)
        {
            colour = (UInt32)b << 8;
        }

        public byte GetAlpha()
        {
            return (byte)(colour >> 0);
        }
        public void SetAlpha(byte a)
        {
            colour = (UInt32)a << 0;
        }
    }
}
