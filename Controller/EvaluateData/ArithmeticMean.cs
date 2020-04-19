using System;

namespace Wetterstation
{
    partial class main
    {
        static double ArithmeticMean(ref Record[] WeatherData, int EvaluationParameter)
        {
            double Mittel = 0;
            int i = 0;
            int UpperBorder = FindUpperBorder(ref WeatherData);
            if (EvaluationParameter == 0)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel + WeatherData[i].AirTemperature;
                }
                return Mittel / i;
            }
            else if (EvaluationParameter == 1)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel + WeatherData[i].AirPressure;
                }
                return Mittel / i;
            }
            else if (EvaluationParameter == 2)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel + WeatherData[i].Humidity;
                }
                return Mittel / i;
            }
            else
            {
                return -1;
            }
        }
    }
}
