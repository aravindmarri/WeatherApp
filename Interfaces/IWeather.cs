using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Interfaces
{
    public class IWeather
    {
        [JsonProperty("location")]
        public ILocation Location { get; set; }

        [JsonProperty("current")]
        public ICurrent Current { get; set; }

        //public Ilocation Location { get; set; }
        //public ICurrent Current { get; set; }
        //public float wind_mph { get; set; }
        //public float wind_kph { get; set; }
        //public float wind_degree { get; set; }
        //public string wind_dir { get; set; }
        //public float pressure_mb { get; set; }
        //public float pressure_in { get; set; }
        //public float precip_mm { get; set; }
        //public float precip_in { get; set; }
        //public int humidity { get; set; }
        //public int cloud { get; set; }
        //public float feelslike_c { get; set; }
        //public float feelslike_f { get; set; }
        //public float vis_km { get; set; }
        //public float vis_miles { get; set; }
        //public float uv { get; set; }
        //public float gust_mph { get; set; }
        //public float gust_kph { get; set; }
    }
}
