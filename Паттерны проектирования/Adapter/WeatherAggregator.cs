using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public sealed class WeatherAggregator : IWeatherProvider
    {
        public IEnumerable<WeatherInfo> GetWeather(float altitude, float longitude, DateTime @from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
