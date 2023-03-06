using System.Collections.Immutable;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Windows.Forms.VisualStyles;
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
            timer1.Interval = (6 * 1000);
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        public async void timer1_Tick(object sender, EventArgs e)
        {
            PocasiApp.Functions.LoadAll(labelTemperature, labelHumidity, labelFeelsLike, labelCurrentCity, label5, pictureBox1, this);

        }

        public async void getDataButton_Click(object sender, EventArgs e)
        {
            PocasiApp.Functions.LoadAll(labelTemperature, labelHumidity, labelFeelsLike, labelCurrentCity, label5, pictureBox1, this);

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
            PocasiApp.Functions.LoadAll(labelTemperature, labelHumidity, labelFeelsLike, labelCurrentCity, label5, pictureBox1, this);

        }



        private void comboCityName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PocasiApp.GetUrl.CITY = comboCityName.Text;
        }



        private void labelTemperature_Click(object sender, EventArgs e)
        {

        }

            async void comboCityName_TextChanged(object sender, EventArgs e)
            {
                PocasiApp.Functions.LoadAll(labelTemperature, labelHumidity, labelFeelsLike, labelCurrentCity, label5, pictureBox1, this);

        }
    
    }
}