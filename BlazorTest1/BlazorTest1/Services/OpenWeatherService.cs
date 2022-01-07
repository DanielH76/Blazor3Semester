using BlazorTest1.Data.ApiData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorTest1.Services
{
    public class OpenWeatherService
    {
        public const string API_KEY = "1c215863f25c6bbb0f765bf8f18fa029";
        public const string BaseUrl = "https://api.openweathermap.org/data/2.5/onecall?";

        public async Task<OpenWeatherRoot> Get(double lat, double lon, string exclude)
        {
            using HttpClient client = new HttpClient();
            //long dateUnix = ((DateTimeOffset)date).ToUnixTimeSeconds();
            HttpResponseMessage response = await client.GetAsync($"{BaseUrl}lat={lat.ToString(System.Globalization.CultureInfo.InvariantCulture)}&lon={lon.ToString(System.Globalization.CultureInfo.InvariantCulture)}&exclude={exclude}&units=metric&appid={API_KEY}");

            string responseString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<OpenWeatherRoot>(responseString);
        }
    }
}
