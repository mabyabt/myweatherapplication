using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeatherApp01
{
    class WebRequest
    {
        private string urlFirst = "https://api.openweathermap.org/data/2.5/weather?q=";
        private string apiKey = "____openweatherapi_key____";
        private string urlCenter = "&appid=";
        private string urlEnd = "&mode=xml";
        

        public  string getUrl(string city) {
             string finishedUrl ;

            return finishedUrl= urlFirst+city+urlCenter+apiKey+urlEnd;
        }


    }
}
