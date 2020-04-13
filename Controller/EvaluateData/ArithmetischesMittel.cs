using System;

namespace Wetterstation
{
    partial class main
    {
        static double ArithmetischesMittel(ref Datensatz[] Wetterdaten, int Parameter)
        {
            double Mittel = 0;
            int i = 0;
            int UpperBorder = FindUpperBorder(ref Wetterdaten);
            if (Parameter == 0)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel + Wetterdaten[i].Lufttemperatur;
                }
                return Mittel / i;
            }
            else if (Parameter == 1)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel + Wetterdaten[i].Luftdruck;
                }
                return Mittel / i;
            }
            else if (Parameter == 2)
            {
                for (i = 0; i < UpperBorder; i++)
                {
                    Mittel = Mittel + Wetterdaten[i].Luftfeuchtigkeit;
                }
                return Mittel / i;
            }
            else
            {
                return -1;
            }
        }
    }
}
