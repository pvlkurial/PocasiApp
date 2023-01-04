using Newtonsoft.Json;
using PocasiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace PocasiApp.Processors
{
    public static class WeatherProcessor
    {
        public static async Task<Weather> LoadWeather()
        {

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(GetUrl.Url()))
            {

                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    MainWeatherModel? weather = JsonConvert.DeserializeObject<MainWeatherModel>(result);
                    return weather.weather[0];

                }
                else
                {
                    return null;
                }
            }

        }
    }
}
