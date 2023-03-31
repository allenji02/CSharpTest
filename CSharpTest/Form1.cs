namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddressBook ab = new AddressBook(
                nameTextBox.Text,
                phoneTextBox.Text,
                emailTextBox.Text);
            outputTextBox.Text = ab.ToString();
        }
    }
}