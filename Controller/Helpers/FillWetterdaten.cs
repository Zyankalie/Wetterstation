using System;
using System.Linq;

namespace Wetterstation
{
    partial class main
    {
        static Random r = new Random();
        static void FillWetterdaten(ref Datensatz[] Wetterdaten, int NumberOfEntries)
        {
            for (int i = 0; i < Wetterdaten.Length; i++)
            {
                if (i < NumberOfEntries)
                {
                    Wetterdaten[i] = CreateValidRandomEntry();
                }
                else
                {
                    Wetterdaten[i] = new Datensatz { Datum = "  .  .    ", Lufttemperatur = 0.0d, Luftdruck = 0, Luftfeuchtigkeit = 0 };
                }
            }

        }

        static Datensatz CreateValidRandomEntry()
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
            return new Datensatz { Datum = nDate, Lufttemperatur = nTemperature, Luftdruck = nPressure, Luftfeuchtigkeit = nHumidity };
        }
    }
}
