namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(moneyText.Text);
            int year = Convert.ToInt32(yearText.Text);
            double rate = Convert.ToDouble(rateText.Text) / 100;
            double interest = money * rate * year;
            interestText.Text = interest.ToString();
            double total = money + interest;
            totalText.Text = total.ToString();
        }
    }
}