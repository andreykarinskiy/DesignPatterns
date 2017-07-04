using System;
using System.ComponentModel.Composition.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var catalog = new ApplicationCatalog();
            var container = new CompositionContainer(catalog);

            var converter = container.GetExportedValue<Converter>();
            var y = "1.5";
            var x = converter.Convert<float, string>(y);

            Console.ReadLine();
        }
    }
}
