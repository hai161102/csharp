using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBtvn
{
    internal class Const
    {
        public static void setLabel(Label label)
        {
            label.SetBounds(0, 50, 100, 50);
            label.Name = "output_label";
            label.TextAlign = ContentAlignment.MiddleCenter;
        }
        public static void setLabel(Label label, int x, int y, int width, int height)
        {
            label.SetBounds(x, y, width, height);
            label.Name = "output_label";
            label.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
