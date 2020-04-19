using System;

namespace Wetterstation
{
    partial class main
    {
        static double Median(ref Record[] WeatherData, int EvaluationParameter)
        {
            Defragment(ref WeatherData);
            BubbleSort(ref WeatherData, EvaluationParameter + 1, true);
            int i = FindUpperBorder(ref WeatherData);
            if (EvaluationParameter == 0)
            {
                return WeatherData[i / 2].AirTemperature;
            }
            else if (EvaluationParameter == 1)
            {
                return WeatherData[i / 2].AirPressure;
            }
            else if (EvaluationParameter == 2)
            {
                return WeatherData[i / 2].Humidity;
            }
            else
            {
                return -1;
            }
        }
    }
}
