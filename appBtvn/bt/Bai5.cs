using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBtvn.bt
{
    internal class Bai5
    {
        private int a1, b1, c1, a2, b2, c2;
        private Label label;

        public Bai5(int a1, int b1, int c1, int a2, int b2, int c2, Label label)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
            this.label = label;
            Const.setLabel(label, 0, 100, 100, 50);
        }

        public Bai5(Label label)
        {
            this.label = label;
            Const.setLabel(label, 0, 100, 100, 50);
        }

        public void setA1(int a1)
        {
            this.a1 = a1;
        }
        public void setA2(int a1)
        {
            this.a2 = a1;
        }
        public void setB1(int a1)
        {
            this.b1 = a1;
        }
        public void setC1(int a1)
        {
            this.c1 = a1;
        }
        public void setB2(int a1)
        {
            this.b2 = a1;
        }
        public void setC2(int a1)
        {
            this.c2 = a1;
        }
        public void show()
        {
            this.label.Text = ptBN2A(this.a1, this.b1, this.c1, this.a2, this.b2, this.c2);
        }
        public Label GetLabel()
        {
            return this.label;
        }
        private string ptBN2A(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            int D = a1 * b2 - a2 * b1;
            int Dx = c1 * b2 - c2 * b1;
            int Dy = a1 * c2 - a2 * c1;

            if (D == 0)
            {
                if (Dx + Dy == 0)
                {
                    return ("Vo so nghiem");
                }
                else return ("Vo nghiem");
            }
            else
            {
                return ("x: " + (Dx / D) + ", y: " + (Dy / D));
            }
        }
    }
}
