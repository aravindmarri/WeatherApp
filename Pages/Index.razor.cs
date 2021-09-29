using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherApp.Interfaces;

namespace WeatherApp.Pages
{
    public partial class Index
    {
        private Weather customers;

        public string location { get; set; } = "Europe / London";
        public string airData { get; set; } = "no";

        //protected async void getAPI()
        //{
        //    customers = await Services.GetData;

        //}
        //public async Task<IEnumerable<Employee>> GetEmployees()
        //{
        //    return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        //}
        //protected override async Task OnInitializedAsync()
        //{
        //    WeatherData = new List<IWeather>();
        //    WeatherData = await Http.GetJsonAsync<List<IWeather>>("http://api.weatherapi.com/v1/current.json?key=f16f6372d6094dbd98a60343212909&q=London&aqi=no");
        //}
        //private IWeather[] todoItems;
        //protected override async Task OnInitializedAsync() =>
        //todoItems = await Http.GetFromJsonAsync<IWeather[]>("api/TodoItems");
    }
}
