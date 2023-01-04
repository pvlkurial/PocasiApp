using Newtonsoft.Json;
using static PocasiApp.GetUrl;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace PocasiApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
         
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ApiHelper.InitializeClient();
            Application.Run(new Form1());
            
        }
        
    }
}
