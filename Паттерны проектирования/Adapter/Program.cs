using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            IWeatherProvider weatherProvider = new WeatherAggregator();
        }
    }
}
