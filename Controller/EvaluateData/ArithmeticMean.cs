//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ArithmeticMean.cs
//Datum:        12.04.2020
//Beschreibung: Berechnet das Arithmetische Mittel für einen übergebenen Parameter
//              Mapping: 0 = Lufttemperatur; 1 = Luftdruck; 2 = Luftfeuchtigkeit
//              return -1 heißt, dass der EvaluationParameter fehlerhaft war
//Aenderungen:  12.04.2020 Erstellung

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
