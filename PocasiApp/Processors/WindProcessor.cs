using Newtonsoft.Json;
using PocasiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace PocasiApp.Processors
{
    public class WindProcessor
    {
        public static async Task<WindPropModel> LoadWindValues()
        {

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(GetUrl.Url()))
            {
                if (response.IsSuccessStatusCode)
                {
                    WindModel windValuesObject = await response.Content.ReadAsAsync<WindModel>();
                    return windValuesObject.Wind;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
