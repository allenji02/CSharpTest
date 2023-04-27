using System.Collections;

namespace CSharpTest
{
    public partial class Form1 : Form
    {
        ArrayList teachers;

        public Form1()
        {
            teachers = new ArrayList();
            InitializeComponent();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            teachers.Add(new Teacher(nameTextBox.Text, titleTextBox.Text));
            nameTextBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
        }

        private void traverseButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = string.Empty;
            foreach (Teacher t in teachers)
            {
                outputTextBox.Text += t.ToString() + "\n";
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            teachers.Insert(int.Parse(indexTextBox.Text),
                new Teacher(nameTextBox.Text, titleTextBox.Text));
            nameTextBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
            indexTextBox.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            teachers.RemoveAt(int.Parse(indexTextBox.Text));
            indexTextBox.Text = string.Empty;
        }
    }
}