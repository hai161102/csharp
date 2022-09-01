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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.conditionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button conditionButton;
        private Button loopButton;
    }
}