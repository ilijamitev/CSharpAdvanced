namespace WinFormsApp
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
            this.myFirstLabel = new System.Windows.Forms.Label();
            this.addOne = new System.Windows.Forms.Button();
            this.removeOne = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myFirstLabel
            // 
            this.myFirstLabel.AutoSize = true;
            this.myFirstLabel.Location = new System.Drawing.Point(326, 90);
            this.myFirstLabel.Name = "myFirstLabel";
            this.myFirstLabel.Size = new System.Drawing.Size(38, 15);
            this.myFirstLabel.TabIndex = 0;
            this.myFirstLabel.Text = "label1";
            this.myFirstLabel.Click += new System.EventHandler(this.myFirstLabel_Click);
            // 
            // addOne
            // 
            this.addOne.Location = new System.Drawing.Point(357, 132);
            this.addOne.Name = "addOne";
            this.addOne.Size = new System.Drawing.Size(75, 23);
            this.addOne.TabIndex = 1;
            this.addOne.Text = "AddOne";
            this.addOne.UseVisualStyleBackColor = true;
            this.addOne.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeOne
            // 
            this.removeOne.Location = new System.Drawing.Point(250, 132);
            this.removeOne.Name = "removeOne";
            this.removeOne.Size = new System.Drawing.Size(88, 23);
            this.removeOne.TabIndex = 2;
            this.removeOne.Text = "RemoveOne";
            this.removeOne.UseVisualStyleBackColor = true;
            this.removeOne.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(278, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "changeLetterCase";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 23);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.removeOne);
            this.Controls.Add(this.addOne);
            this.Controls.Add(this.myFirstLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label myFirstLabel;
        public Button addOne;
        public Button removeOne;
        public CheckBox checkBox1;
        public TextBox textBox1;
    }
}