﻿//Autor:        Jan-Lukas Spilles
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
        static double GeometricMean(ref Record[] weatherData, int evaluationParameter)
        {
            double mittel = 1;
            int i = 0;
            int upperBorder = FindUpperBorder(ref weatherData);
            if (evaluationParameter == 0)
            {
                for (i = 0; i < upperBorder; i++)
                {
                    mittel = mittel * weatherData[i].airTemperature;
                }
                return NthRoot(mittel, i);
            }
            else if (evaluationParameter == 1)
            {
                for (i = 0; i < upperBorder; i++)
                {
                    mittel = mittel * weatherData[i].airPressure;
                }
                return NthRoot(mittel, i);
            }
            else if (evaluationParameter == 2)
            {
                for (i = 0; i < upperBorder; i++)
                {
                    mittel = mittel * weatherData[i].humidity;
                }
                return NthRoot(mittel, i);
            }
            else
            {
                return -1;
            }
        }
    }
}
