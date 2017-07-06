using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public sealed class Address
    {
        public Country Country { get; set; }

        public City City { get; set; }

        public Street Street { get; set; }

        public string Building { get; set; }

        public int Apartment { get; set; }

        public bool IsActual { get; set; }
    }
}
