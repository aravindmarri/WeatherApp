using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;
using WeatherApp.Interfaces;

namespace WeatherApp.Services
{
    //public class WeatherService : IWeatherService
    //{

    //    //public string APIOrigin = "https://api.weatherapi.com/v1/current.json";
    //    //public string APIKey = "f16f6372d6094dbd98a60343212909";
    //    //public async Task GetData(location, airData)
    //    //{
    //    //    string value = $"{APIOrigin}?Key={APIKey}&q={location}&aqi={airData}";
    //    //    var post = await _http.GetFromJsonAsync<IWeather>(value);
    //    //    //return await Http.GetFromJsonAsync <IWeather[]> (value);

    //    //}
    //    private readonly HttpClient httpClient;
    //    public WeatherService(HttpClient _httpClient)
    //    {
    //        this.httpClient = _httpClient;
    //    }
    //    //public  Task<IEnumerable<IWeather>> getWeather()
    //    //{
    //    //    return await httpClient.GetFromJsonAsync<IWeather>("http://api.weatherapi.com/v1/current.json?key=f16f6372d6094dbd98a60343212909&q=London&aqi=no");
    //    //}
    //}
}
