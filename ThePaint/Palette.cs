using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaint
{
    public static class Palette
    {
        private static Pen FirstPen = new Pen(Color.Black, 4);
        private static Pen SecondPen = new Pen(Color.White, 4);
        private static Pen LastUsedPen = new Pen(Color.Black, 4);

        private static Color CurrentMainColor = Color.Black;
        private static Color CurrentAdditionalColor = Color.White;
        private static int thickness = 4;

        private enum ColorOption
        {
            Main,
            Addictional
        }
    }
}
