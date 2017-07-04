using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IWeatherProvider
    {
        IEnumerable<WeatherInfo> GetWeather(float altitude, float longitude, DateTime from, DateTime to);
    }
}
