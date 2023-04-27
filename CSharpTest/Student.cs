namespace CSharpTest
{
    internal class Student
    {
        public int id;
        public String name;
        public int age;

        public Student(int id, String name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return "学号：" + this.id +
                "，姓名：" + this.name +
                "，年龄：" + this.age;
        }
    }
}
