//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        GeometricMean.cs
//Datum:        12.04.2020
//Beschreibung: Berechnet das geometrische Mittel für einen übergebenen Parameter
//              Mapping: 0 = Lufttemperatur; 1 = Luftdruck; 2 = Luftfeuchtigkeit
//              return -1 heißt, dass der EvaluationParameter fehlerhaft war
//Aenderungen:  12.04.2020 Erstellung

namespace Wetterstation
{
    partial class main
    {
        static double GeometricMean(ref Record[] WeatherData, int EvaluationParameter)
        {
            double Mittel = 1;
            int i = 0;
            int UpperBorder = FindUpperBorder(ref WeatherData);
            if (EvaluationParameter == 0)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel * WeatherData[i].AirTemperature;
                }
                return NthRoot(Mittel, i);
            }
            else if (EvaluationParameter == 1)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel * WeatherData[i].AirPressure;
                }
                return NthRoot(Mittel, i);
            }
            else if (EvaluationParameter == 2)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel * WeatherData[i].Humidity;
                }
                return NthRoot(Mittel, i);
            }
            else
            {
                return -1;
            }
        }
    }
}
