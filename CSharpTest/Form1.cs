namespace CSharpTest
{
    public partial class Form1 : Form
    {
        StudentList studentList;

        public Form1()
        {
            studentList = new StudentList();
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            studentList.Add(
                new Student(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    int.Parse(ageTextBox.Text)
                ));
            idTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            ageTextBox.Text = String.Empty;
            outputTextBox.Text += "添加成功\n";
        }

        private void sortByIDButton_Click(object sender, EventArgs e)
        {
            studentList.students.Sort((a, b) => { return a.id - b.id; });
            outputTextBox.Text = String.Empty;
            foreach (Student s in studentList.students)
            {
                outputTextBox.Text += s.ToString() + "\n";
            }
        }

        private void sortByAgeButton_Click(object sender, EventArgs e)
        {
            studentList.students.Sort((a, b) => { return b.age - a.age; });
            outputTextBox.Text = String.Empty;
            foreach (Student s in studentList.students)
            {
                outputTextBox.Text += s.ToString() + "\n";
            }
        }

        private void getByNameButton_Click(object sender, EventArgs e)
        {
            Student? s = studentList.students.Find(
                (a) => { return a.name == nameTextBox.Text; });
            if (s != null)
            {
                outputTextBox.Text = s.ToString();
                return;
            }
            outputTextBox.Text = "未找到该姓名的学生";
        }

        private void getByIndexButton_Click(object sender, EventArgs e)
        {
            Student? s = studentList[int.Parse(indexTextBox.Text)];
            if (s != null)
            {
                outputTextBox.Text = s.ToString();
                return;
            }
            outputTextBox.Text = "未找到该位学生";
        }
    }
}