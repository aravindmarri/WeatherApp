using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Interfaces;

namespace WeatherApp.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<IWeather>> getWeather();
    }
}
