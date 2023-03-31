namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double c = Double.Parse(cTextBox.Text);
            double f = 9.0 / 5 * c + 32;
            fTextBox.Text = f.ToString();
        }
    }
}