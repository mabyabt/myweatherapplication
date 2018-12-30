using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWeatherApp01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private static string requestUrl;
        private void SubmitBtn_Clicked(object sender, EventArgs e)
        {


            requestUrl = WebRequest.getUrl(cityName.Text);
            WebRequest.getXml(requestUrl);
            string outText = data.getData();
            output.Text = outText;
            output.IsVisible = true;
            Console.WriteLine("Url link ::::::::"+ requestUrl);
        }
    }
}
