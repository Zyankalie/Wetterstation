﻿//Autor:        Jan-Lukas Spilles
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
            double mean = 0;
            int numberOfElements;
            int upperBorder = FindUpperBorder(ref weatherData);
            switch (evaluationParameter)
            {
                case 0:
                    for (numberOfElements = 0; numberOfElements < upperBorder; numberOfElements++)
                    {
                        mean += weatherData[numberOfElements].airTemperature;
                    }
                    break;
                case 1:
                    for (numberOfElements = 0; numberOfElements < upperBorder; numberOfElements++)
                    {
                        mean += weatherData[numberOfElements].airPressure;
                    }
                    break;
                case 2:
                    for (numberOfElements = 0; numberOfElements < upperBorder; numberOfElements++)
                    {
                        mean += weatherData[numberOfElements].humidity;
                    }
                    break;
                default: return -1;
            }
            return mean / numberOfElements;
        }
    }
}
