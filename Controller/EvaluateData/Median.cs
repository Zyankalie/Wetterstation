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
            BubbleSort(ref weatherData, evaluationParameter + 1, true, out int swapCounter, out int ifCounter, out double timeElapsed, out int arrayAccessCounter);
            int upperBorder = FindUpperBorder(ref weatherData);
            switch (evaluationParameter)
            {
                case 0: return weatherData[upperBorder / 2].airTemperature;
                case 1: return weatherData[upperBorder / 2].airPressure;
                case 2: return weatherData[upperBorder / 2].humidity;
                default: return -1;
            }
        }
    }
}
