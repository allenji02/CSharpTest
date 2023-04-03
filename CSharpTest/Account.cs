namespace CSharpTest
{
    internal class Account
    {
        private int creditNo;
        private decimal balance;

        public Account()
        {
            Random r = new Random();
            creditNo = r.Next(100000, 500000);
            balance = 100;
        }

        public decimal Balance { get => balance; }
        public int CreditNo { get => creditNo; }

        public bool Withdraw(decimal money, out string message)
        {
            if (money < 0)
            {
                message = "操作失败！\n输入金额不正确！";
                return false;
            }
            else if (balance >= money)
            {
                balance -= money;
                message = "操作成功！\n取款" + money + "元";
                return true;
            }
            else
            {
                message = "操作失败！\n余额不足！";
                return false;
            }
        }

        public decimal Deposit(decimal money)
        {
            balance += money;
            return balance;
        }
    }
}
