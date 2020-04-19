using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void DeleteRecord(ref Record[] WeatherData, int Position)
        {
            WeatherData[Position].Date = "  .  .    ";
            WeatherData[Position].AirTemperature = 0.0;
            WeatherData[Position].AirPressure = 0;
            WeatherData[Position].Humidity = 0;
        }
    }
}
