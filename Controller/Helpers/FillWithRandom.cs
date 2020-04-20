//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        FillWithRandom.cs
//Datum:        14.04.2020
//Beschreibung: Füllt das Array mit n zufälligen und validen Einträgen.
//Aenderungen:  14.04.2020 Erstellung
using System;

namespace Wetterstation
{
    partial class main
    {
        static Random r = new Random();
        static void FillWithRandom(ref Record[] WeatherData, int NumberOfEntries)
        {
            for (int i = 0; i < WeatherData.Length; i++)
            {
                if (i < NumberOfEntries)
                {
                    WeatherData[i] = CreateValidRandomEntry();
                }
                else
                {
                    WeatherData[i] = new Record { Date = "  .  .    ", AirTemperature = 0.0d, AirPressure = 0, Humidity = 0 };
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
            int nPressure = r.Next(700, 1080);
            //Humidity
            int nHumidity = r.Next(0, 100);
            return new Record { Date = nDate, AirTemperature = nTemperature, AirPressure = nPressure, Humidity = nHumidity };
        }
    }
}
