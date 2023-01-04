using System.Collections.Immutable;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Xml;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using PocasiApp.Processors;

namespace PocasiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelCurrentCity.Text = "NAN";
            labelCurrentCity.BackColor = Color.Transparent;
            labelCurrentCity.ForeColor = System.Drawing.Color.White;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = (6*1000);
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        public async void timer1_Tick(object sender, EventArgs e)
        {
            var tempInfo = await MainProcessor.LoadTempValues();
            labelTemperature.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Temp).ToString()}°C";
            labelHumidity.Text = tempInfo.Humidity.ToString();
            labelFeelsLike.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Feels_like).ToString()}°C";
            labelCurrentCity.Text = PocasiApp.GetUrl.CITY;
            var weatherInfo = await WeatherProcessor.LoadWeather();
            label5.Text = weatherInfo.main.ToString();

            switch (weatherInfo.main.ToString())
            {
                case "Clouds":
                    pictureBox1.Image = Properties.Resources.clouds;
                    BackgroundImage = Properties.Resources.cloudy_skies_bg;
                    break;
                case "Rain":
                    pictureBox1.Image = Properties.Resources.rainy;
                    BackgroundImage = Properties.Resources.rain_skies_bg;
                    break;
                case "Clear":
                    pictureBox1.Image = Properties.Resources.sun;
                    BackgroundImage = Properties.Resources.clearskies;
                    break;
                case "Drizzle":
                    pictureBox1.Image = Properties.Resources.clouds_with_sun;
                    BackgroundImage = Properties.Resources.drizzle_skies_bg;
                    break;
            }

        }
       
        public async void getDataButton_Click(object sender, EventArgs e)
        {
            var tempInfo = await MainProcessor.LoadTempValues();
            labelTemperature.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Temp).ToString()}°C";
            labelHumidity.Text = tempInfo.Humidity.ToString();
            labelFeelsLike.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Feels_like).ToString()}°C";
            labelCurrentCity.Text = PocasiApp.GetUrl.CITY;
        }

        

        private void getValueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            PocasiApp.GetUrl.CITY = comboCityName.Text;

        }

        private void typeCityName_TextChanged(object sender, EventArgs e)
        {
            
            comboCityName.Text = null;
        }
       
        private async void Form1_Load(object sender, EventArgs e)
        {
            var tempInfo = await MainProcessor.LoadTempValues();
            labelTemperature.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Temp).ToString()}°C";
            labelHumidity.Text = tempInfo.Humidity.ToString();
            labelFeelsLike.Text = $"{Functions.KelvinToCelsiusRound(tempInfo.Feels_like).ToString()}°C";
            labelCurrentCity.Text = PocasiApp.GetUrl.CITY;

        }

        private void comboCityName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PocasiApp.GetUrl.CITY = comboCityName.Text;
        }

       
    }
}