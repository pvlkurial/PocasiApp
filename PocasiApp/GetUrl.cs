using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json.Serialization;
using System.IO;
using System.Security.Policy;

namespace PocasiApp
{
    public class GetUrl
    {
        public static string CITY = "London";
        public static string Url()
        {

            string API_KEY = "7c0f218eefc5ddf44f4aa241c38c1e14";
            string BASE_URL = "https://api.openweathermap.org/data/2.5/weather?";
            string urlstring = String.Format(BASE_URL + "appid=" + API_KEY + "&q=" + CITY);
            return urlstring;

        }
        //https://api.openweathermap.org/data/2.5/weather?appid=7c0f218eefc5ddf44f4aa241c38c1e14&q=London

    }
}

