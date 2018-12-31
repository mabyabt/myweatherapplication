using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Xml;

namespace MyWeatherApp01
{
    class WebRequest
    {
        private static string urlFirst = "https://api.openweathermap.org/data/2.5/weather?q=";
        private static string apiKey = "2b8c4f840e3bb8352ca8c2d767e82d17";
        private static string urlCenter = "&appid=";
        private static string urlEnd = "&mode=xml";

      
        public static string getUrl(string city) {
             string finishedUrl ;
            
            return finishedUrl= urlFirst+city+urlCenter+apiKey+urlEnd;
        }


        public static void getXml(string url) {
 
            string xmlStr;
           

                using (var wc = new WebClient())
                {
                    xmlStr = wc.DownloadString(url);
                }
                Debug.WriteLine("xmlStr:::::::::::::::" + xmlStr);


          


         //   string datastorage = GetXMLAsString(xmlDoc);
            data.setData(xmlStr);


        }



        private static string GetXMLAsString(XmlDocument myxml)
        {
            return myxml.OuterXml;
        }

    }
}
