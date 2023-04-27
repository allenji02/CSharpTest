namespace CSharpTest
{
    internal abstract class Product
    {
        public string name;
        public abstract String Info();
    }

    class Electric : Product
    {
        public Electric(String name)
        {
            this.name = name;
        }

        public override string Info()
        {
            return this.name + "：我是电器，要用电";
        }
    }

    class Necessity : Product
    {
        public Necessity(String name)
        {
            this.name = name;
        }

        public override string Info()
        {
            return this.name + "：我是百货";
        }
    }

    class Clothing : Product
    {
        public Clothing(String name)
        {
            this.name = name;
        }

        public override string Info()
        {
            return this.name + "：我是衣服";
        }
    }
}
