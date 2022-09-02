using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBtvn.bt
{
    internal class Bai1
    {
        private char inputChar;
        private Label label;

        public Bai1(char inputChar, Label label)
        {
            this.inputChar = inputChar;
            this.label = label;
        }

        public Label GetLabel()
        {
            return label;
        }

        public void giaiBaiToan()
        {
            label.Text = findSyntax(inputChar) ? "This is a char" : "This is not a char";
        }

        private bool findSyntax(char text)
        {

            char[] chars = { 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N',
        'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'x', 'X', 'y', 'Y', 'z', 'Z', 'w', 'W' };
            foreach (char i in chars)
            {
                if (text.Equals(i))
                {
                    return true;

                }
            }
            return false;

        }
    }
}
