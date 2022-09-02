namespace appBtvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] listName()
        {
            string[] list = new string[20];
            for (int i = 0; i < 20; i++)
            {
                list[i] = "Bai " + i + 1;
            }
            return list;
        }
    }

}