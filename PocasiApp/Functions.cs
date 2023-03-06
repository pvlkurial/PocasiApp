using PocasiApp.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocasiApp
{
    public class Functions
    {
        public static double? KelvinToCelsiusRound(double? FirstTemp)
        {
            double? SecondTemp = Math.Round((double)(FirstTemp - 273.16));
            return SecondTemp;
        
        }



        public static async void LoadAll(Label label1, Label label2, Label label3, Label label4, Label label5, PictureBox pictureBox1, Form form1)
        {
            var tempInfo = await MainProcessor.LoadTempValues();
            label1.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Temp).ToString()}°C";
            label2.Text = tempInfo.Humidity.ToString();
            label3.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Feels_like).ToString()}°C";
            label4.Text = PocasiApp.GetUrl.CITY;
            var weatherInfo = await WeatherProcessor.LoadWeather();
            label5.Text = weatherInfo.main.ToString();

            switch (weatherInfo.main.ToString())
            {
                case "Clouds":
                    pictureBox1.Image = Properties.Resources.clouds;
                    form1.BackgroundImage = Properties.Resources.cloudy_skies_bg;
                    break;
                case "Rain":
                    pictureBox1.Image = Properties.Resources.rainy;
                    form1.BackgroundImage = Properties.Resources.rain_skies_bg;
                    break;
                case "Clear":
                    pictureBox1.Image = Properties.Resources.sun;
                    form1.BackgroundImage = Properties.Resources.clearskies;
                    break;
                case "Drizzle":
                    pictureBox1.Image = Properties.Resources.clouds_with_sun;
                    form1.BackgroundImage = Properties.Resources.drizzle_skies_bg;
                    break;
            }
        }

}
}
