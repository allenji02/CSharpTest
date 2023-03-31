namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] nums = new double[5];
        int idx = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            double input = double.Parse(inputTextBox.Text);
            nums[idx] = input;
            preSortTextBox.Text += input + " ";
            idx++;
            idxLabel.Text = "请输入第 " + (idx + 1) + " 个数字";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            Array.Sort(nums);
            foreach (int i in nums)
            {
                afterSortTextBox.Text += i + " ";
            }
        }
    }
}