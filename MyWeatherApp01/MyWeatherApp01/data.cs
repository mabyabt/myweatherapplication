using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeatherApp01
{
    class data
    {
        private static string weather;


        public  data(string input) {

            weather = input;

        }

        public static void setData(string input) {

            weather = input;

        }
        public static string getData() {

            return weather;

        }
    }
}
