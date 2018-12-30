using System;
using System.Collections.Generic;
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



        public static string getWeatherInfo() {
            XmlNodeList xnList = xmldata.SelectNodes("/current");


            foreach (XmlNode xn in xnList)
            {
              temp = xn["temperature"].Value;
                cloud = xn["weather"].Value;
               
            }



            string outWeather;
            outWeather = $"weather: {temp} {cloud}";
            



            return outWeather;
        }

    }
}
