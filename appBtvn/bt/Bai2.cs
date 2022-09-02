using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBtvn.bt
{
    internal class Bai2
    {
        private string number;
        private Label label;

        public Bai2(string number, Label label)
        {
            this.number = number;
            this.label = label;
            Const.setLabel(this.label);
        }

        public Label GetLabel()
        {
            return this.label;
        }
        public string getNumber()
        {
            return this.number;
        }
        public void show()
        {
            label.Text = whatIsNumber(number);
        }
        private string whatIsNumber(string numberTring)
        {
            string numberIs = "";

            int number;
            try
            {
                number = int.Parse(numberTring);
                if (number == 0)
                {
                    numberIs = "0";
                }
                else if (number > 0)
                {
                    numberIs = "pos";
                }
                else if (number < 0)
                {
                    numberIs = "nev";
                }
                else if (number % 2 == 0)
                {
                    numberIs = "chan";
                }
                else if (number % 2 != 0)
                {
                    numberIs = "le";
                }
            }
            catch (Exception)
            {
                numberIs = "it is not number";
            }
            
            return numberIs;
        }
    }
}
