namespace WinFormsApp1
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
            this.plusOne = new System.Windows.Forms.Button();
            this.minusOne = new System.Windows.Forms.Button();
            this.counterDisplay = new System.Windows.Forms.Label();
            this.randomColorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plusOne
            // 
            this.plusOne.Location = new System.Drawing.Point(463, 168);
            this.plusOne.Name = "plusOne";
            this.plusOne.Size = new System.Drawing.Size(75, 23);
            this.plusOne.TabIndex = 0;
            this.plusOne.Text = "PlusOne";
            this.plusOne.UseVisualStyleBackColor = true;
            this.plusOne.Click += new System.EventHandler(this.plusOne_Click);
            // 
            // minusOne
            // 
            this.minusOne.Location = new System.Drawing.Point(261, 168);
            this.minusOne.Name = "minusOne";
            this.minusOne.Size = new System.Drawing.Size(75, 23);
            this.minusOne.TabIndex = 1;
            this.minusOne.Text = "MinusOne";
            this.minusOne.UseVisualStyleBackColor = true;
            this.minusOne.Click += new System.EventHandler(this.minusOne_Click);
            // 
            // counterDisplay
            // 
            this.counterDisplay.AutoSize = true;
            this.counterDisplay.Location = new System.Drawing.Point(395, 120);
            this.counterDisplay.Name = "counterDisplay";
            this.counterDisplay.Size = new System.Drawing.Size(13, 15);
            this.counterDisplay.TabIndex = 2;
            this.counterDisplay.Text = "0";
            // 
            // randomColorBtn
            // 
            this.randomColorBtn.Location = new System.Drawing.Point(330, 259);
            this.randomColorBtn.Name = "randomColorBtn";
            this.randomColorBtn.Size = new System.Drawing.Size(137, 23);
            this.randomColorBtn.TabIndex = 3;
            this.randomColorBtn.Text = "Random BG Color";
            this.randomColorBtn.UseVisualStyleBackColor = true;
            this.randomColorBtn.Click += new System.EventHandler(this.randomColorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randomColorBtn);
            this.Controls.Add(this.counterDisplay);
            this.Controls.Add(this.minusOne);
            this.Controls.Add(this.plusOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button plusOne;
        public Button minusOne;
        public Label counterDisplay;
        private Button randomColorBtn;
    }
}