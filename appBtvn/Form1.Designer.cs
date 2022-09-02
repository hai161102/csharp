namespace appBtvn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conditionButton = new System.Windows.Forms.Button();
            this.loopButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.conditionPanel = new System.Windows.Forms.Panel();
            this.loopPanel = new System.Windows.Forms.Panel();
            this.labelCondition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conditionButton
            // 
            this.conditionButton.Location = new System.Drawing.Point(713, 12);
            this.conditionButton.Name = "conditionButton";
            this.conditionButton.Size = new System.Drawing.Size(75, 23);
            this.conditionButton.TabIndex = 0;
            this.conditionButton.Text = "Condition";
            this.conditionButton.UseVisualStyleBackColor = true;
            this.conditionButton.Click += new System.EventHandler(this.conditionButton_Click);
            // 
            // loopButton
            // 
            this.loopButton.Location = new System.Drawing.Point(713, 42);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(75, 23);
            this.loopButton.TabIndex = 1;
            this.loopButton.Text = "Loop";
            this.loopButton.UseVisualStyleBackColor = true;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);

            this.exitButton.Location = new System.Drawing.Point(713, 72);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // conditionPanel
            // 
            this.conditionPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.conditionPanel.Location = new System.Drawing.Point(12, 12);
            this.conditionPanel.Name = "conditionPanel";
            this.conditionPanel.Size = new System.Drawing.Size(700, 600);
            this.conditionPanel.TabIndex = 2;
            setupPanel(20, 20, conditionPanel.Width - 40, conditionPanel.Height - 40, 20, this.conditionPanel);
            // 
            // loopPanel
            // 
            this.loopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loopPanel.Location = new System.Drawing.Point(12, 12);
            this.loopPanel.Name = "loopPanel";
            this.loopPanel.Size = new System.Drawing.Size(700, 600);
            this.loopPanel.TabIndex = 3;
            setupPanel(20, 20, loopPanel.Width - 40, loopPanel.Height - 40, 12, this.loopPanel);
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.conditionPanel);
            this.Controls.Add(this.loopPanel);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.conditionButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CenterToScreen();
            this.ResumeLayout(false);

        }

        
        #endregion

        private Button conditionButton;
        private Button loopButton;
        private Button exitButton;
        private Panel conditionPanel;
        private Panel loopPanel;
        private Label labelCondition;


        private void setupPanel(int x, int y, int w, int h, int numberButton, Panel parent)
        {
            Panel panel = new Panel();
            panel.SetBounds(x, y, w, h);
            parent.Controls.Clear();
            int aHalf = numberButton / 2;
            int num = 0;
            for (int i = 0; i < aHalf; i++)
            {
                num++;
                string nameTitle = "Bai " + num;
                panel.Controls.Add(setupButton(0, i * 40, 100, 40, nameTitle));
            }
            for (int i = 0; i < aHalf; i++)
            {
                num++;
                string nameTitle = "Bai " + num;
                panel.Controls.Add(setupButton(panel.Width / 2, i * 40, 100, 40, nameTitle));
            }
            parent.Controls.Add(panel);
        }
        private Button setupButton(int x, int y, int w, int h, string name)
        {
            Button button = new Button();
            button.SetBounds(x, y, w, h);
            button.Text = name;
            button.BackColor = Color.White;
            button.Click += new System.EventHandler(this.onButtonClick);
            return button;
        }
        private Panel panelBai1(int x, int y, int w, int h)
        {
            Panel panel = new Panel();
            panel.SetBounds(x, y, w, h);

            Label labelInput = new Label();
            labelInput.Text = "Input char";
            labelInput.SetBounds(0, 0, 100, 20);
            labelInput.TextAlign = ContentAlignment.MiddleCenter;
            TextBox textBoxInput = new TextBox();
            textBoxInput.SetBounds(120, 0, 100, 20);
            textBoxInput.TextChanged += new System.EventHandler(this.OnInputChangeB1);

            //Button button = new Button();
            //button.Text = "Show";
            //button.SetBounds(240, 0, 100, 20);
            //button.Click += new System.EventHandler(this.OnShowB1);

            panel.Controls.Add(labelInput);
            panel.Controls.Add(textBoxInput);
            //panel.Controls.Add(button);
            return panel;
        }

        private Panel panelBai2(int x, int y, int w, int h, int bai)
        {
            Panel panel = new Panel();
            panel.SetBounds(x, y, w, h);

            Label labelInput = new Label();
            labelInput.Text = "Input number";
            labelInput.SetBounds(0, 0, 100, 20);
            labelInput.TextAlign = ContentAlignment.MiddleCenter;
            TextBox textBoxInput = new TextBox();
            textBoxInput.SetBounds(120, 0, 100, 20);
            if (bai == 2)
            {
                textBoxInput.TextChanged += new System.EventHandler(this.OnInputChangeB2);
            }
            if (bai == 4)
            {
                textBoxInput.TextChanged += new System.EventHandler(this.OnInputChangeB4);

            }

            //Button button = new Button();
            //button.Text = "Show";
            //button.SetBounds(240, 0, 100, 20);
            //button.Click += new System.EventHandler(this.OnShowB1);

            panel.Controls.Add(labelInput);
            panel.Controls.Add(textBoxInput);
            //panel.Controls.Add(button);
            return panel;
        }

        private Panel panelBai5(int x, int y, int w, int h)
        {
            Panel panel = new Panel();
            panel.SetBounds(x, y, w, h);

            TextBox a1TextBox = new TextBox();
            a1TextBox.SetBounds(0, 0, 50, 20);
            a1TextBox.TextChanged += new System.EventHandler(this.OnInputChangeB5A1);
            panel.Controls.Add(a1TextBox);

            Label a1Label = new Label();
            a1Label.Text = "x";
            a1Label.SetBounds(50, 0, 50, 20);
            a1Label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(a1Label);

            TextBox b1TextBox = new TextBox();
            b1TextBox.SetBounds(100, 0, 50, 20);
            b1TextBox.TextChanged += new System.EventHandler(this.OnInputChangeB5B1);
            panel.Controls.Add(b1TextBox);

            Label b1Label = new Label();
            b1Label.Text = "y";
            b1Label.SetBounds(150, 0, 50, 20);
            b1Label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(b1Label);

            TextBox c1TextBox = new TextBox();
            c1TextBox.SetBounds(200, 0, 50, 20);
            c1TextBox.TextChanged += new System.EventHandler(this.OnInputChangeB5C1);
            panel.Controls.Add(c1TextBox);

            Label c1Label = new Label();
            c1Label.Text = "z";
            c1Label.SetBounds(250, 0, 50, 20);
            c1Label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(c1Label);

            TextBox a2TextBox = new TextBox();
            a2TextBox.SetBounds(0, 70, 50, 20);
            a2TextBox.TextChanged += new System.EventHandler(this.OnInputChangeB5A2);
            panel.Controls.Add(a2TextBox);

            Label a2Label = new Label();
            a2Label.Text = "x";
            a2Label.SetBounds(50, 70, 50, 20);
            a2Label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(a2Label);

            TextBox b2TextBox = new TextBox();
            b2TextBox.SetBounds(100, 70, 50, 20);
            b2TextBox.TextChanged += new System.EventHandler(this.OnInputChangeB5B2);
            panel.Controls.Add(b2TextBox);

            Label b2Label = new Label();
            b2Label.Text = "y";
            b2Label.SetBounds(150, 70, 50, 20);
            b2Label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(b2Label);

            TextBox c2TextBox = new TextBox();
            c2TextBox.SetBounds(200, 70, 50, 20);
            c2TextBox.TextChanged += new System.EventHandler(this.OnInputChangeB5C2);
            panel.Controls.Add(c2TextBox);

            Label c2Label = new Label();
            c2Label.Text = "z";
            c2Label.SetBounds(250, 70, 50, 20);
            c2Label.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(c2Label);


            return panel;
        }

        
    }
}