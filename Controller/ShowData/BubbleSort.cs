using System;

namespace Wetterstation
{
    partial class main
    {
        static void BubbleSort(ref Datensatz[] Wetterdaten, int Parameter, bool AscDesc)
        {
            bool Swaped = true;
            Defragment(ref Wetterdaten);
            int UpperBorder = FindUpperBorder(ref Wetterdaten);

            if (Parameter == 0)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (CompareDates(Wetterdaten[index1].Datum, Wetterdaten[index1 - 1].Datum))
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (CompareDates(Wetterdaten[index1 - 1].Datum, Wetterdaten[index1].Datum))
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
            else if (Parameter == 1)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (Wetterdaten[index1].Lufttemperatur < Wetterdaten[index1 - 1].Lufttemperatur && AscDesc)
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (Wetterdaten[index1].Lufttemperatur > Wetterdaten[index1 - 1].Lufttemperatur && AscDesc)
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
            else if (Parameter == 2)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (Wetterdaten[index1].Luftdruck < Wetterdaten[index1 - 1].Luftdruck && AscDesc)
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (Wetterdaten[index1].Luftdruck > Wetterdaten[index1 - 1].Luftdruck && AscDesc)
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
            else if (Parameter == 3)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (Wetterdaten[index1].Luftfeuchtigkeit < Wetterdaten[index1 - 1].Luftfeuchtigkeit)
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (Wetterdaten[index1].Luftfeuchtigkeit > Wetterdaten[index1 - 1].Luftfeuchtigkeit)
                            {
                                Swap(ref Wetterdaten, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
