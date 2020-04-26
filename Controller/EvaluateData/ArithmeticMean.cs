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
        static double ArithmeticMean(ref Record[] weatherData, int evaluationParameter)
        {
            double mittel = 0;
            int i = 0;
            int upperBorder = FindUpperBorder(ref weatherData);
            if (evaluationParameter == 0)
            {
                for (i = 0; i < upperBorder; i++)
                {
                    mittel = mittel + weatherData[i].airTemperature;
                }
                return mittel / i;
            }
            else if (evaluationParameter == 1)
            {
                for (i = 0; i < upperBorder; i++)
                {
                    mittel = mittel + weatherData[i].airPressure;
                }
                return mittel / i;
            }
            else if (evaluationParameter == 2)
            {
                for (i = 0; i < upperBorder; i++)
                {
                    mittel = mittel + weatherData[i].humidity;
                }
                return mittel / i;
            }
            else
            {
                return -1;
            }
        }
    }
}
