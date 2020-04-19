using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void Swap(ref Record[] WeatherData, int elem1, int elem2)
        {
            Record tmp = new Record { 
                Date = WeatherData[elem1].Date, 
                AirTemperature = WeatherData[elem1].AirTemperature,
                AirPressure = WeatherData[elem1].AirPressure, 
                Humidity = WeatherData[elem1].Humidity
            };

            WeatherData[elem1].Date = WeatherData[elem2].Date;
            WeatherData[elem1].AirTemperature = WeatherData[elem2].AirTemperature;
            WeatherData[elem1].AirPressure = WeatherData[elem2].AirPressure;
            WeatherData[elem1].Humidity = WeatherData[elem2].Humidity;

            WeatherData[elem2].Date = tmp.Date;
            WeatherData[elem2].AirTemperature = tmp.AirTemperature;
            WeatherData[elem2].AirPressure = tmp.AirPressure;
            WeatherData[elem2].Humidity = tmp.Humidity;

        }
    }
}
