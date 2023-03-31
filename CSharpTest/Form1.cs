namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(inputTextBox.Text);
            int res = 0;
            while (num > 0)
            {
                res = res * 10 + num % 10;
                num /= 10;
            }
            outputTextBox.Text = res.ToString();
        }
    }
}