using System;

namespace Wetterstation
{
    partial class main
    {
        static double Median(ref Datensatz[] Wetterdaten, int Parameter)
        {
            Defragment(ref Wetterdaten);
            BubbleSort(ref Wetterdaten, Parameter + 1, true);
            int i = FindUpperBorder(ref Wetterdaten);
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
