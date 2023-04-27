namespace CSharpTest
{
    internal class StudentList
    {
        public List<Student> students;

        public StudentList()
        {
            students = new List<Student>();
        }

        public Student this[int index] => students[index];

        public void Add(Student student)
        {
            students.Add(student);
        }
    }
}
