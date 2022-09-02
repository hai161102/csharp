using appBtvn.bt;

namespace appBtvn
{
    public partial class Form1 : Form
    {
        Bai1 bai1;
        Bai2 bai2;
        Bai4 bai4;
        Bai5 bai5;
        private Panel panel;
        private static int bigCase;
        public static int CASE_CONDITION = 1000;
        public static int CASE_LOOP = 1001;

        public Form1()
        {
            InitializeComponent();
        }

        private void conditionButton_Click(object sender, EventArgs e)
        {
            loopPanel.Hide();
            conditionPanel.Show();
            
        }

        private void loopButton_Click(object sender, EventArgs e)
        {
            conditionPanel.Hide();
            loopPanel.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (bigCase == CASE_CONDITION)
            {
                loopPanel.Hide();
                setupPanel(20, 20, conditionPanel.Width - 40, conditionPanel.Height - 40, 20, conditionPanel);

            }
            else if (bigCase == CASE_LOOP)
            {
                conditionPanel.Hide();
                setupPanel(20, 20, loopPanel.Width - 40, loopPanel.Height - 40, 20, loopPanel);
            }
            else this.Close();
            bigCase = -1;

        }

        private void onButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char indexText = button.Text[button.Text.Length - 1];
            int index = int.Parse(indexText.ToString());
            bigCase = conditionPanel.Visible ? CASE_CONDITION : CASE_LOOP;
            showBai(index, bigCase);
        }

        private void showBai(int index, int bigCase)
        {
            if (bigCase == CASE_CONDITION)
            {
                switch (index)
                {
                    case 1:
                        conditionPanel.Controls.Clear();
                        panel = panelBai1(20, 20, conditionPanel.Width - 40, conditionPanel.Height - 40);
                        conditionPanel.Controls.Add(panel);
                        
                        break;
                    case 2:
                        conditionPanel.Controls.Clear();
                        panel = panelBai2(20, 20, conditionPanel.Width - 40, conditionPanel.Height - 40, 2);
                        conditionPanel.Controls.Add(panel);

                        break;

                    case 4:
                        conditionPanel.Controls.Clear();
                        panel = panelBai2(20, 20, conditionPanel.Width - 40, conditionPanel.Height - 40, 4);
                        conditionPanel.Controls.Add(panel);

                        break;
                    case 5:
                        conditionPanel.Controls.Clear();
                        panel = panelBai5(20, 20, conditionPanel.Width - 40, conditionPanel.Height - 40);
                        conditionPanel.Controls.Add(panel);
                        panel.Controls.RemoveByKey("output_label");
                        bai5 = new Bai5(new Label());
                        break;
                    default:
                        break;
                }
            }
            if (bigCase == CASE_LOOP)
            {

            }
        }
        private void OnInputChangeB1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            panel.Controls.RemoveByKey("output_label");
            Label label = new Label();
            label.SetBounds(0, 50, 100, 20);
            label.Name = "output_label";
            if (textBox.Text != "")
            {
                bai1 = new Bai1(textBox.Text[0], label);
                bai1.giaiBaiToan();
                panel.Controls.Add(bai1.GetLabel());
            }
            
        }
        private void OnInputChangeB2(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            panel.Controls.RemoveByKey("output_label");
            if (textBox.Text != "")
            {
                bai2 = new Bai2(textBox.Text, new Label());
                bai2.show();
                panel.Controls.Add(bai2.GetLabel());
            }

        }
        private void OnInputChangeB4(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            panel.Controls.RemoveByKey("output_label");
            if (textBox.Text != "")
            {
                bai4 = new Bai4(textBox.Text, new Label());
                bai4.show();
                panel.Controls.Add(bai4.GetLabel());
            }
        }
        private void OnInputChangeB5C2(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            try
            {
                if (textBox.Text != null)
                {
                    bai5.setC2(int.Parse(textBox.Text));
                    bai5.show();
                    panel.Controls.Add(bai5.GetLabel());
                }
            }
            catch (Exception)
            {

            }
        }

        private void OnInputChangeB5B2(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text != null)
                {
                    bai5.setB2(int.Parse(textBox.Text));
                }
            }
            catch (Exception)
            {

            }
        }

        private void OnInputChangeB5A2(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text != null)
                {
                    bai5.setA2(int.Parse(textBox.Text));
                }
            }
            catch (Exception)
            {

            }
        }

        private void OnInputChangeB5C1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text != null)
                {
                    bai5.setC1(int.Parse(textBox.Text));
                }
            }
            catch (Exception)
            {

            }
        }

        private void OnInputChangeB5B1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text != null)
                {
                    bai5.setB1(int.Parse(textBox.Text));
                }
            }
            catch (Exception)
            {

            }
        }

        private void OnInputChangeB5A1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text != null)
                {
                    bai5.setA1(int.Parse(textBox.Text));
                }
            }
            catch (Exception)
            {

            }
        }

    }

}