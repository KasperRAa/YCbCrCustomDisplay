using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    internal class ConversionConstants
    {
        public readonly string Name;
        public readonly int R;
        public readonly int G;
        public readonly int B;

        public ConversionConstants(int r, int g, int b, string name)
        {
            R = r;
            G = g;
            B = b;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
