using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static int ValidateEntry(ref Datensatz[] Wetterdaten, ref Datensatz Entry)
        {
            int result = 0;
            Defragment(ref Wetterdaten);
            if (Wetterdaten[Wetterdaten.Length - 1].Datum == "  .  .    ")
            {
                if (!DateFits(Entry.Datum))
                {
                    result += 2;
                }
                if (!TemperatureFits(Entry.Lufttemperatur))
                {
                    result += 4;
                }

                if (!PressureFits(Entry.Luftdruck))
                {
                    result += 8;
                }
                if (!HumidityFits(Entry.Luftfeuchtigkeit))
                {
                    result += 16;
                }
            }
            else
            {
                return result += 32;
            }
            return result;
        }
    }
}
