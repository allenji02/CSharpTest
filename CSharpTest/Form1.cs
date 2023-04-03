namespace CSharpTest
{
    public partial class Form1 : Form
    {
        Time time = new Time();
        public Form1()
        {
            InitializeComponent();
            UpdateForm();
        }

        private void UpdateForm()
        {
            hourTextBox.Text = time.Hour.ToString();
            minuteTextBox.Text = time.Minute.ToString();
            secondTextBOX.Text = time.Second.ToString();
        }

        private void incrButton_Click(object sender, EventArgs e)
        {
            time.IncrSecond();
            UpdateForm();
        }
    }
}