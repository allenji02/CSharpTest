namespace CSharpTest
{
    public partial class Form1 : Form
    {
        Shelf<Product> shelf;

        public Form1()
        {
            shelf = new Shelf<Product>();
            InitializeComponent();
        }

        private void necessityButton_Click(object sender, EventArgs e)
        {
            shelf.products.Add(new Necessity(nameTextBox.Text));
            nameTextBox.Text = string.Empty;
        }

        private void electricButton_Click(object sender, EventArgs e)
        {
            shelf.products.Add(new Electric(nameTextBox.Text));
            nameTextBox.Text = string.Empty;
        }

        private void clothingButton_Click(object sender, EventArgs e)
        {
            shelf.products.Add(new Clothing(nameTextBox.Text));
            nameTextBox.Text = string.Empty;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = shelf.ToString();
        }
    }
}