namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            myFirstLabel.Text = counter.ToString();
            textBox1.Text = "";
        }
        private void myFirstLabel_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myFirstLabel.Text = $"{++counter}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myFirstLabel.Text = $"{--counter}";
        }

        bool isTrue = true;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isTrue)
            {
                textBox1.Text = Text.ToLower();
                isTrue = !isTrue;
            }
            else
            {
                textBox1.Text = Text.ToUpper();
                isTrue = !isTrue;

            }

        }
    }
}