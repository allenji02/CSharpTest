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
            outputTextBox.Text += "\n" + "�����˻��ɹ����û�����Ϊ��"
                + account.CreditNo + "\n";
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            String msg;
            if (account == null)
                msg = "���ȴ����˻�";
            else if (withdrawTextBox.Text == "")
                msg = "������ȡ����";
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
            outputTextBox.Text += "\n" + "���ɹ���\n���Ϊ��" + res + "\n";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += "\n" + "���Ϊ��" + account.Balance + "\n";
        }

        private void createVIPButton_Click(object sender, EventArgs e)
        {
            account=new VIPAccount();
            outputTextBox.Text += "\n" + "���� VIP �˻��ɹ����û�����Ϊ��"
                + account.CreditNo + "\n";
        }
    }
}