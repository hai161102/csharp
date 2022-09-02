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
            this.conditionPanel = new System.Windows.Forms.Panel();
            this.loopPanel = new System.Windows.Forms.Panel();
            this.labelCondition = new System.Windows.Forms.Label();
            this.conditionPanel.SuspendLayout();
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
            // 
            // loopButton
            // 
            this.loopButton.Location = new System.Drawing.Point(713, 41);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(75, 23);
            this.loopButton.TabIndex = 1;
            this.loopButton.Text = "Loop";
            this.loopButton.UseVisualStyleBackColor = true;
            // 
            // conditionPanel
            // 
            this.conditionPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.conditionPanel.Location = new System.Drawing.Point(12, 12);
            this.conditionPanel.Name = "conditionPanel";
            this.conditionPanel.Size = new System.Drawing.Size(695, 426);
            this.conditionPanel.TabIndex = 2;
            this.conditionPanel.Padding = new System.Windows.Forms.Padding(200);
            this.conditionPanel.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                string name = "Bai " + (i + 1);
                this.conditionPanel.Controls.Add(setupButton(20,
                           i * 20,
                           100,
                           20,
                            name));
            }
            // loopPanel
            // 
            this.loopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loopPanel.Location = new System.Drawing.Point(0, 0);
            this.loopPanel.Name = "loopPanel";
            this.loopPanel.Size = new System.Drawing.Size(695, 426);
            this.loopPanel.TabIndex = 3;
            this.loopPanel.Controls.Clear();
            for (int i = 0; i < 12; i++)
            {
                string name = "Bai " + (i + 1);
                this.conditionPanel.Controls.Add(setupButton(20,
                           i * 20,
                           100,
                           20,
                            name));
            }
            this.loopPanel.Visible = false;
            // 
            // labelCondition
            // 
            this.labelCondition.Location = new System.Drawing.Point(0, 0);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(100, 23);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Haha";
            this.labelCondition.ForeColor = Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conditionPanel);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.conditionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.conditionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button conditionButton;
        private Button loopButton;
        private Panel conditionPanel;
        private Panel loopPanel;
        private Label labelCondition;
        private Button setupButton(int x, int y, int w, int h, string name)
        {
            Button button = new Button();
            button.SetBounds(x, y, w, h);
            button.Text = name;
            button.BackColor = Color.White;
            return button;
        }

        
    }
}