using System.Net;
using Newtonsoft.Json;
using Weather_App.Models;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public string apikey { get; set; } = "443310eda44a6ccac99dbfae70d44271";

        public Form1()
        {
            InitializeComponent();
        }



        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetHavaDurumu();
        }
        void GetHavaDurumu()
        {
            using (WebClient client = new WebClient())
            {
                var city = cityinput.Text;
                string url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&lang=tr&appid=" + apikey;
                var data = client.DownloadString(url);

                var jsondata = JsonConvert.DeserializeObject<Root>(data);
                var iconadres = "https://openweathermap.org/img/wn/" + jsondata.weather[0].icon + ".png";

                durumimage.ImageLocation = iconadres;
                detaytext.Text = jsondata.weather[0].description.ToString();
                durumtext.Text = jsondata.weather[0].main.ToString();

                var sicaklik = ((jsondata.main.temp - 32) / Convert.ToDouble("1.8"));
                sicakliktext.Text = Convert.ToInt32(sicaklik).ToString() + " 'C";
                var hissedilen = ((jsondata.main.feels_like - 32) / Convert.ToDouble("1.8"));
                hissedilentext.Text = Convert.ToInt32(hissedilen).ToString() + " 'C";

                ruzgarhizitext.Text = jsondata.wind.speed.ToString();
                basinctext.Text = jsondata.main.pressure.ToString();

                citytext.Text = jsondata.name.ToString();
                saat.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}