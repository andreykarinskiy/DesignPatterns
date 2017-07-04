using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Google
{
    public sealed class GoogleAdapter : IWeatherProvider
    {
        private readonly GoogleWeatherService adaptee;

        public GoogleAdapter()
        {
            // Почему?
            adaptee = new GoogleWeatherService("http://google.weather.com");
        }

        public IEnumerable<WeatherInfo> GetWeather(float altitude, float longitude, DateTime from, DateTime to)
        {
            // Получение данных из конкретного провайдера погоды.
            var googleWeathers = adaptee.GetWeather(x: altitude, y: longitude, fromTime: from, toTime: to);

            // Адаптация модели провайдера к абстрактной модели.
            foreach (var sourceDto in googleWeathers)
            {
                yield return new WeatherInfo
                {
                     Temperature = sourceDto.Temper,
                     Humidity = sourceDto.Humid,
                     Pressure = sourceDto.Press
                };
            }
        }
    }
}
