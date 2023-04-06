namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pupilButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            double chinese = double.Parse(chineseOrRequiredTextBox.Text);
            double math = double.Parse(mathOrOptionalTextBox.Text);
            Pupil pupil = new Pupil(name, age, chinese, math);
            outputTextBox.Text += pupil.ToString() + "\n";
        }

        private void seniorButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            double chinese = double.Parse(chineseOrRequiredTextBox.Text);
            double math = double.Parse(mathOrOptionalTextBox.Text);
            double engish = double.Parse(englishTextBox.Text);
            Senior senior = new Senior(name, age, chinese, math, engish);
            outputTextBox.Text += senior.ToString() + "\n";
        }

        private void undergraduateButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            double required = double.Parse(chineseOrRequiredTextBox.Text);
            double optional = double.Parse(mathOrOptionalTextBox.Text);
            Undergraduate undergraduate = new Undergraduate(name, age, required, optional);
            outputTextBox.Text += undergraduate.ToString() + "\n";
        }
    }
}