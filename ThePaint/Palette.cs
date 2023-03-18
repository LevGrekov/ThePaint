using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaint
{
    public static class Palette
    {
        public static Pen LastUsedPen = new Pen(Color.Black, 4);
        public static Brush SolidBrush = new SolidBrush(CurrentAdditionalColor);


        public static Color CurrentMainColor = Color.Black;
        public static Color CurrentAdditionalColor = Color.White;

        public static int thickness = 4;

        public enum ColorOption
        {
            Main,
            Additional
        }
        public static ColorOption CurrentColor = ColorOption.Main;

        public static void FixCurrentPen(MouseEventArgs e)
        {
            //Фиксирование рабочего Карандаша 
            switch (e.Button)
            {
                case MouseButtons.Left:
                    LastUsedPen = new Pen(CurrentMainColor,thickness);
                    SolidBrush = new SolidBrush(CurrentAdditionalColor);
                    break;
                case MouseButtons.Right:
                    LastUsedPen = new Pen(CurrentAdditionalColor, thickness);
                    SolidBrush = new SolidBrush(CurrentMainColor);
                    break;
            }
            LastUsedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            LastUsedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }


    }
}
