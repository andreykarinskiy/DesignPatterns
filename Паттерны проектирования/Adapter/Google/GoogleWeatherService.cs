using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Google
{
    public sealed class GoogleWeatherService
    {
        public GoogleWeatherService(string url)
        {
        }

        public GoogleWeatherDto[] GetWeather(float x, float y, DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }
    }
}
