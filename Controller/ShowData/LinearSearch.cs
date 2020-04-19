using System;

namespace Wetterstation
{
    partial class main
    {
        static int LinearSearch(ref Record[] WeatherData, int SearchParameter, string SearchValue)
        {
            int i = 0;
            if (SearchParameter == 0)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].Date == SearchValue)
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (SearchParameter == 1)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].AirTemperature== Convert.ToDouble(SearchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (SearchParameter == 2)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].AirPressure == Convert.ToInt32(SearchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (SearchParameter == 3)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].Humidity == Convert.ToInt32(SearchValue))
                    {
                        return i;
                    }
                    else 
                    { 
                        //Nichts                    
                    }
                }
            }
            else 
            {
                return -1;
            }
            return -1;
        }
    }
}