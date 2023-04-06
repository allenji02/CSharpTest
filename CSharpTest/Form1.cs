namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account account;

        private void createButton_Click(object sender, EventArgs e)
        {
            account = new Account();
            outputTextBox.Text += "\n" + "创建账户成功，用户卡号为："
                + account.CreditNo + "\n";
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            String msg;
            if (account == null)
                msg = "请先创建账户";
            else if (withdrawTextBox.Text == "")
                msg = "请输入取款金额";
            else
            {
                decimal money = decimal.Parse(withdrawTextBox.Text);
                account.Withdraw(money, out msg);
            }
            outputTextBox.Text += "\n" + msg + "\n";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal money = decimal.Parse(depositTextBox.Text);
            decimal res = account.Deposit(money);
            outputTextBox.Text += "\n" + "存款成功！\n余额为：" + res + "\n";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += "\n" + "余额为：" + account.Balance + "\n";
        }

        private void createVIPButton_Click(object sender, EventArgs e)
        {
            account=new VIPAccount();
            outputTextBox.Text += "\n" + "创建 VIP 账户成功，用户卡号为："
                + account.CreditNo + "\n";
        }
    }
}