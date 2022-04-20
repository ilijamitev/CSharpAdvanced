namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            counterDisplay.Text = counter.ToString();



        }



        int counter = 0;
        List<Color> colors = new List<Color>() { Color.Brown, Color.SandyBrown, Color.SeaGreen, Color.AliceBlue, Color.Bisque, Color.Aquamarine, Color.Azure, Color.Cyan, Color.Tan, Color.ForestGreen, Color.FloralWhite, Color.LavenderBlush, Color.Maroon, Color.SeaShell, Color.DarkOrchid, Color.OrangeRed };

        private void minusOne_Click(object sender, EventArgs e)
        {
            counterDisplay.Text = $"{--counter}";
        }

        private void plusOne_Click(object sender, EventArgs e)
        {
            counterDisplay.Text = $"{++counter}";
        }

        private void randomColorBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNum = random.Next(colors.Count);
            BackColor = colors[randomNum];
            randomColorBtn.Text = colors[randomNum].ToString();
        }
    }
}