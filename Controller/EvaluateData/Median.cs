//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Median.cs
//Datum:        12.04.2020
//Beschreibung: Berechnet den Median für einen übergebenen Parameter
//              Mapping: 0 = Lufttemperatur; 1 = Luftdruck; 2 = Luftfeuchtigkeit
//              return -1 heißt, dass der EvaluationParameter fehlerhaft war
//Aenderungen:  12.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static double Median(ref Record[] weatherData, int evaluationParameter)
        {
            Defragment(ref weatherData);
            BubbleSort(ref weatherData, evaluationParameter + 1, true);
            int i = FindUpperBorder(ref weatherData);
            if (evaluationParameter == 0)
            {
                return weatherData[i / 2].airTemperature;
            }
            else if (evaluationParameter == 1)
            {
                return weatherData[i / 2].airPressure;
            }
            else if (evaluationParameter == 2)
            {
                return weatherData[i / 2].humidity;
            }
            else
            {
                return -1;
            }
        }
    }
}
