using System;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var str = new[] { "a", "b", "c", "d", "e", "f" };

            foreach (var c in str.AsRandom())
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
