using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBtvn.bt
{
    internal class Bai4
    {
        private string number;
        private Label label;

        public Bai4(string number, Label label)
        {
            this.number = number;
            this.label = label;
            Const.setLabel(label);
        }

        public void show()
        {
            try
            {
                float x = float.Parse(number);
                this.label.Text = fourthA(x).ToString();
            }
            catch (Exception)
            {
                this.label.Text = "This is not Number";
            }
        }
        private float fourthA(float x)
        {
            if (x > 0)
            {
                if (x > -1 && x < 1)
                {
                    return 3 * x + 5;
                }
                return (float)(3 * x + Math.Sqrt(x));
            }
            else if (x <= 0)
            {
                if (x <= -1)
                {
                    return x * x + 2 * x - 1;
                }
                else if (x > -1 && x < 1)
                {
                    return 3 * x + 5;
                }
                else
                {
                    int k = 0;
                    float sum = 0;
                    float xMuK = x;
                    long g = 1;
                    float tmp = (float)(1.0 / g);
                    while (true)
                    {
                        sum += tmp;
                        k++;
                        xMuK = (float)Math.Pow(x, k);
                        g *= k;
                        tmp = xMuK / g;
                        if (tmp <= 0.0001)
                        {
                            break;
                        }
                    }
                    return (float)(sum + 4);
                }

            }


            return float.MaxValue;
        }

        public Label GetLabel()
        {
            return this.label;
        }
    }
}
