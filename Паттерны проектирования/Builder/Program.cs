using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var builder = new AddressBuilder();

            var address = builder
                .Country("Russia")
                .City("Spb")
                .Street("Medicov")
                .LivesAt(building: 10, apart: 365)
                .Actual()
                .Build();
        }
    }
}
