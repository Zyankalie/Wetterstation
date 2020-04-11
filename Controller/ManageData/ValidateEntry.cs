using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static int ValidateEntry(ref Datensatz[] Wetterdaten, Datensatz Entry)
        {
            Defragment(ref Wetterdaten);
            if (Wetterdaten[Wetterdaten.Length - 1].Datum == "  .  .    ")
            {
                if (!DateFits(Entry.Datum))
                {
                    return 0;
                }
                else if (!TemperatureFits(Entry.Lufttemperatur))
                {
                    return 1;
                }

                else if (!PressureFits(Entry.Luftdruck))
                {
                    return 2;
                }
                else if (!HumidityFits(Entry.Luftfeuchtigkeit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
