using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;


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
            try
            {
                WebRequest.getXml(requestUrl);
                string outText = data.getWeatherInfo();
                output.Text = outText;
                output.IsVisible = true;
                Console.WriteLine("Url link ::::::::" + requestUrl);
            }
            catch (Exception ex) {

                Debug.WriteLine("error::::" + ex);
                output.Text = "something went wrong ";
                output.IsVisible = true;
                output.TextColor = Color.Red;
            }
            
        }
    }
}
