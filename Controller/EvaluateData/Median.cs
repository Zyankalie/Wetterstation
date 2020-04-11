using System;

namespace Wetterstation
{
    partial class main
    {
        static double Median(ref Datensatz[] Wetterdaten, int Parameter)
        {
            Defragment(ref Wetterdaten);
            BubbleSort(ref Wetterdaten, Parameter + 1);
            int i = 0;

            for (i = 0; i < Wetterdaten.Length && Wetterdaten[i].Datum != "  .  .    "; i++)
            { }
            if (Parameter == 0)
            {
                return Wetterdaten[i / 2].Lufttemperatur;
            }
            else if (Parameter == 1)
            {
                return Wetterdaten[i / 2].Luftdruck;
            }
            else if (Parameter == 2)
            {
                return Wetterdaten[i / 2].Luftfeuchtigkeit;
            }
            else
            {
                return -1;
            }
        }
    }
}
