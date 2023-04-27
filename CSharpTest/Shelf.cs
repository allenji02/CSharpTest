using System.Text;

namespace CSharpTest
{
    internal class Shelf<T> where T : Product
    {
        public List<T> products;

        public Shelf()
        {
            this.products = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in products)
            {
                sb.AppendLine(item.Info());
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
