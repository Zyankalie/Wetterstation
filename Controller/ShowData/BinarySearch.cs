using System;

namespace Wetterstation
{
    partial class main
    {
        static int BinarySearch(ref Record[] WeatherData, int SearchParameter, string SearchValue)
        {
            Defragment(ref WeatherData);
            BubbleSort(ref WeatherData, SearchParameter, true);
            int Pivot = -1;
            int LowerLimit = 0;
            int UpperLimit = FindUpperBorder(ref WeatherData);
            int Pos = -1;

            if (SearchParameter == 0)
            {
                while (UpperLimit >= LowerLimit)
                {
                    Pivot = LowerLimit + ((UpperLimit - LowerLimit) / 2);
                    if (WeatherData[Pivot].Date == SearchValue)
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (CompareDates(SearchValue, WeatherData[Pivot].Date))
                    {
                        LowerLimit = Pivot + 1;
                    }
                    else //(CompareDates(SearchValue, Wetterdaten[Pivot].Datum, false))
                    {
                        UpperLimit = Pivot - 1;
                    }
                }                
            }
            else if (SearchParameter == 1)
            {
                while (UpperLimit >= LowerLimit)
                {
                    Pivot = LowerLimit + ((UpperLimit - LowerLimit) / 2);
                    if (WeatherData[Pivot].AirTemperature == Convert.ToDouble(SearchValue))
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (Convert.ToDouble(SearchValue) > WeatherData[Pivot].AirTemperature)
                    {
                        LowerLimit = Pivot + 1;
                    }
                    else if (Convert.ToDouble(SearchValue) < WeatherData[Pivot].AirTemperature)
                    {
                        UpperLimit = Pivot - 1;
                    }
                }
            }
            else if (SearchParameter == 2)
            {
                while (UpperLimit >= LowerLimit)
                {
                    Pivot = LowerLimit + ((UpperLimit - LowerLimit) / 2);
                    if (WeatherData[Pivot].AirPressure == Convert.ToInt32(SearchValue))
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (Convert.ToInt32(SearchValue) > WeatherData[Pivot].AirPressure)
                    {
                        LowerLimit = Pivot + 1;
                    }
                    else if (Convert.ToInt32(SearchValue) < WeatherData[Pivot].AirPressure)
                    {
                        UpperLimit = Pivot - 1;
                    }
                }
            }
            else if (SearchParameter == 3)
            {
                while (UpperLimit >= LowerLimit)
                {
                    Pivot = LowerLimit + ((UpperLimit - LowerLimit) / 2);
                    if (WeatherData[Pivot].Humidity == Convert.ToInt32(SearchValue))
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (Convert.ToInt32(SearchValue) > WeatherData[Pivot].Humidity)
                    {
                        LowerLimit = Pivot + 1;
                    }
                    else if (Convert.ToInt32(SearchValue) < WeatherData[Pivot].Humidity)
                    {
                        UpperLimit = Pivot - 1;
                    }
                }
            }
            else
            {
                //Nichts
            }
            return Pos;
        }
    }
}