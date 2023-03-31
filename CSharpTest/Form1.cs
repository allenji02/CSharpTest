using System.Text;

namespace CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i / 2; j++)
                    if (i % j == 0)
                        sum += j;
                if (sum == i)
                {
                    sb.Append(i + " 是一个完数：" + i + "=1");
                    for (int j = 2; j <= i / 2; j++)
                        if (i % j == 0)
                            sb.Append("+" + j);
                    sb.Append('\n');
                }
            }
            outputLabel.Text = sb.ToString();
        }
    }
}