//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        FillWithRandom.cs
//Datum:        14.04.2020
//Beschreibung: Füllt das Array mit n zufälligen und validen Einträgen.
//Aenderungen:  14.04.2020 Erstellung
//TODO: Strukturell machen
using System;

namespace Wetterstation
{
    partial class main
    {
        static Random r = new Random();
        static void FillWithRandom(ref Record[] weatherData, int numberOfEntries)
        {
            for (int i = 0; i < weatherData.Length; i++)
            {
                if (i < numberOfEntries)
                {
                    weatherData[i] = CreateValidRandomEntry();
                }
                else
                {
                    weatherData[i] = new Record { date = "  .  .    ", airTemperature = 0.0d, airPressure = 0, humidity = 0 };
                }
            }

        }

        static Record CreateValidRandomEntry()
        {
            //Date
            DateTime start = new DateTime(1900, 1, 1);
            string nDate = start.AddDays(r.Next((DateTime.Today - start).Days)).Date.ToString().Substring(0, 10);
            //Temperature
            double nTemperature = r.NextDouble() * (60.0 - (-50.0)) + (-50.0);
            //Pressure
            uint nPressure = (uint)r.Next(700, 1080);
            //Humidity
            uint nHumidity = (uint)r.Next(0, 100);
            return new Record { date = nDate, airTemperature = nTemperature, airPressure = nPressure, humidity = nHumidity };
        }
    }
}
