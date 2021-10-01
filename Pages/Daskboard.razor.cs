using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Pages
{
    public partial class Daskboard
    {
        public int hrs { get; set; } = DateTime.Now.Hour;
        public string Wishes { get; set; }
        public string Theme { get; set; } = "dayTheme";
        protected override void OnInitialized()
        {
            if (hrs > 0) Wishes = "Mornin' Sunshine!";
            if (hrs > 6) Wishes = "Good morning";
            if (hrs > 12) Wishes = "Good afternoon";
            if (hrs > 17) Wishes = "Good evening";
            if (hrs > 22) Wishes = "Too late, Go to bed!";
        }
    }
}
