using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void AddRecord(ref Datensatz[] Wetterdaten, string date, double temperature, int pressure, int humidity)
        {
            Datensatz NewEntry = new Datensatz { Datum = date, Lufttemperatur = temperature, Luftdruck = pressure, Luftfeuchtigkeit = humidity };
            if (ValidateEntry(ref Wetterdaten, NewEntry) == 4)
            {
                for (int i = 0; i < Wetterdaten.Length; i++)
                {
                    if (Wetterdaten[i].Datum == "  .  .    ")
                    {
                        Wetterdaten[i] = NewEntry;
                        break;
                    }
                    else
                    {
                        //Nichts
                    }
                }
            }
        }
    }
}
