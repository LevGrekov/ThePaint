using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaint
{
    internal class FiguresDrawer
    {
        private bool filling;
        public bool Filling
        {
            get => filling;
            set => filling = value;
        }
        private bool contour;
        public bool Contour
        {
            get => contour;
            set => contour = value;
        }

    }
}
