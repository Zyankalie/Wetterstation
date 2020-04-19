using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void AddRecord(ref Record[] WeatherData, ref Record NewEntry, ref int Position)
        {
            if (Position == -1)
            {
                WeatherData[FindUpperBorder(ref WeatherData)] = NewEntry;
            }
            else
            {
                FreeASpot(ref WeatherData, Position - 1);
                WeatherData[Position - 1] = NewEntry;
            }
        }
    }
}
