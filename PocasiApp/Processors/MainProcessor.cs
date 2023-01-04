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
    public class MainProcessor
    {
        public static async Task<TempValuesModel> LoadTempValues()
        {

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(GetUrl.Url()))
            {
                if (response.IsSuccessStatusCode)
                {
                    MainModel tempValuesObject = await response.Content.ReadAsAsync<MainModel>();
                    return tempValuesObject.Main;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
