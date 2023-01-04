using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocasiApp.Models;

namespace PocasiApp.Processors
{
    public static class NameProcessor
    {
        public static async Task<NameModel> LoadName()
        {

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("https://api.openweathermap.org/data/2.5/weather?appid=7c0f218eefc5ddf44f4aa241c38c1e14"))
            {
                if (response.IsSuccessStatusCode)
                {
                    NameModel nameObject = await response.Content.ReadAsAsync<NameModel>();
                    return nameObject;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
