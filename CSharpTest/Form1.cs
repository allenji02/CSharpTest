using System.Text;

namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] nums;

        private void inputButton_Click(object sender, EventArgs e)
        {
            nums = Array.ConvertAll(inputTextBox.Text.Split(','), double.Parse);
            preSortTextBox.Text = String.Join(" ", nums);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            Array.Sort(nums);
            afterSortTextBox.Text=String.Join(" ", nums);
        }
    }
}