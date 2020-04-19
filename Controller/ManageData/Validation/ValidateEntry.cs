using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static int ValidateEntry(ref Record[] WeatherData, ref Record Entry)
        {
            int result = 0;
            Defragment(ref WeatherData);
            if (WeatherData[WeatherData.Length - 1].Date == "  .  .    ")
            {
                if (!DateValidation(Entry.Date))
                {
                    result += 2;
                }
                if (!AirTemperatureValidation(Entry.AirTemperature))
                {
                    result += 4;
                }

                if (!AirPressureValidation(Entry.AirPressure))
                {
                    result += 8;
                }
                if (!HumidityValidation(Entry.Humidity))
                {
                    result += 16;
                }
            }
            else
            {
                return result += 32;
            }
            return result;
        }
    }
}
