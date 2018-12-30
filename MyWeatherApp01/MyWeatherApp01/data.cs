using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;

namespace MyWeatherApp01
{
    class data
    {
        private static string weather;
        private static XmlDocument xmldata = new XmlDocument();
      //  private static XmlNodeList xnList = xmldata.SelectNodes("/current");

        public  data(string input) {

            weather = input;

        }

        public static void setData(string input) {

          
            xmldata.LoadXml(input);
        }
        public static string getData() {

            return weather;

        }
        private static string temp;
        private static string wind;
        private static string cloud;

        private static float kelvinToCelsiu(string kelvin) {


            float cfok;

            double k = Convert.ToDouble(kelvin);

            cfok = (float)k - (float)273.15;

            return cfok;


        }

        public static string getWeatherInfo() {

            XmlNodeList temp0 = xmldata.GetElementsByTagName("temperature");
            XmlNodeList cloud0 = xmldata.GetElementsByTagName("clouds");

            temp = temp0[0].Attributes["value"].Value;

            cloud = cloud0[0].Attributes["name"].Value;



           // Debug.WriteLine("temp::::::_____:::::"+temp);

            string outWeather;
            outWeather = "weather: "+temp+" kelvin   \n in celsius: "+kelvinToCelsiu(temp)+ " \n" +cloud ;
            



            return outWeather;
        }

    }
}
