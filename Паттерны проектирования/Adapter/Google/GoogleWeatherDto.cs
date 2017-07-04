using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Google
{
    public sealed class GoogleWeatherDto
    {
        public float Temper { get; set; }

        public float Press { get; set; }

        public float Humid { get; set; }
    }
}
