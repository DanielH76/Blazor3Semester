using BlazorTest1.Data.ApiData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorTest1.Services
{
    public class StormGlassService
    {
        public const string API_KEY = "8a9a7348-3bd2-11ec-b37c-0242ac130002-8a9a73ca-3bd2-11ec-b37c-0242ac130002";
        public const string BaseUrl = "https://api.stormglass.io/v2/weather/point?";

        public async Task<Root> Get(double lat, double lon)
        {
            using HttpClient client = new HttpClient();
            //long dateUnix = ((DateTimeOffset)date).ToUnixTimeSeconds();
            HttpResponseMessage response = await client.GetAsync($"{BaseUrl}lat={lat.ToString(System.Globalization.CultureInfo.InvariantCulture)}&lng={lon.ToString(System.Globalization.CultureInfo.InvariantCulture)}&start=2020-02-24&end=2020-02-25&params=wavePeriod,waveDirection,waveHeight,waterTemperature,currentDirection,currentSpeed&key={API_KEY}");
            if (!response.IsSuccessStatusCode)
            {
                string responseStringFucked = await response.Content.ReadAsStringAsync();
                return null;
            }

            string responseString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Root>(responseString);
        }
    }
    
}
