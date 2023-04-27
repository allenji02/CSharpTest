namespace CSharpTest
{
    internal class Teacher
    {
        String name;
        String title;

        public Teacher(String name, String title)
        {
            this.name = name;
            this.title = title;
        }

        public override string ToString()
        {
            return "姓名：" + this.name + "，职称：" + this.title;
        }
    }
}
