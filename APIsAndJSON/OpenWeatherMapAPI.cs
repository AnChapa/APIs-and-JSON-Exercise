using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public async Task GetWeatherSA()
        {
            using (var client = new HttpClient())
            {
                var weatherMapURL = "https://api.openweathermap.org/data/2.5/weather?lat=29.4252&lon=-98.4946&appid=89c1a003323177c0db1f4c2881c568f4&units=imperial";
                var weatherResponse = await client.GetStringAsync(weatherMapURL);

                var tempSA = JObject.Parse(weatherResponse)["main"]["temp"].Value<double>();

                Console.WriteLine($"Current Temperature in San Antonio: {tempSA}°F");
            }
        }
    }
}
