using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {

        static void Main(string[] args)
        {
            WeatherConditions weatherConditions = new WeatherConditions();
            weatherConditions.GetForecast();
            System.Threading.Thread.Sleep(1000);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
