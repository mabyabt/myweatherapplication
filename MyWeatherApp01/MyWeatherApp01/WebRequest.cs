using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeatherApp01
{
    class WebRequest
    {
        private string urlFirst = "https://api.openweathermap.org/data/2.5/weather?q=";
        private string apiKey = "2b8c4f840e3bb8352ca8c2d767e82d17";
        private string urlCenter = "&appid=";
        private string urlEnd = "&mode=xml";
        

        public  string getUrl(string city) {
             string finishedUrl ;

            return finishedUrl= urlFirst+city+urlCenter+apiKey+urlEnd;
        }


    }
}
