namespace CSharpTest
{
    internal abstract class Student
    {
        protected string name;
        protected int age;
        public static int cnt;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            cnt++;
        }
        public string Name { get { return name; } }
        public abstract double Average();
        public override string ToString()
        {
            return "总人数为：" + cnt + "；" + name + "，" + age;
        }
    }

    internal class Pupil : Student
    {
        protected double chinese;
        protected double math;
        public Pupil(string name, int age, double chinese, double math) : base(name, age)
        {
            this.chinese = chinese;
            this.math = math;
        }
        public override double Average()
        {
            return (chinese + math) / 2;
        }
        public override string ToString()
        {
            return base.ToString() + "；小学生" + "，平均成绩：" + Average();
        }
    }

    internal class Senior : Student
    {
        protected double chinese;
        protected double math;
        protected double english;
        public Senior(string name, int age, double chinese, double math, double english) : base(name, age)
        {
            this.chinese = chinese;
            this.math = math;
            this.english = english;
        }
        public override double Average()
        {
            return (chinese + math + english) / 3;
        }
        public override string ToString()
        {
            return base.ToString() + "；中学生" + "，平均成绩：" + Average();
        }
    }

    internal class Undergraduate : Student
    {
        protected double required;
        protected double optional;
        public Undergraduate(string name, int age, double required, double optional) : base(name, age)
        {
            this.required = required;
            this.optional = optional;
        }
        public override double Average()
        {
            return (required + optional) / 2;
        }
        public override string ToString()
        {
            return base.ToString() + "；大学生" + "，平均成绩：" + Average();
        }
    }
}
