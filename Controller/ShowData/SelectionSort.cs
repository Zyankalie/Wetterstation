using System;

namespace Wetterstation
{
    partial class main
    {
        static void SelectionSort(ref Datensatz[] Wetterdaten, int Parameter, bool AscDesc)
        {
            int pivot = -1;
            Defragment(ref Wetterdaten);
            int UpperBorder = FindUpperBorder(ref Wetterdaten);

            if (Parameter == 0)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if(CompareDates(Wetterdaten[innereSchleife].Datum, Wetterdaten[pivot].Datum))
                        {
                            pivot = innereSchleife;
                        }
                    }
                    Swap(ref Wetterdaten, aeussereSchleife, pivot);
                }
            }
            else if (Parameter == 1)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (Wetterdaten[innereSchleife].Lufttemperatur < Wetterdaten[pivot].Lufttemperatur && AscDesc)
                        {
                            pivot = innereSchleife;
                        }
                    }
                    Swap(ref Wetterdaten, aeussereSchleife, pivot);
                }
            }
            else if (Parameter == 2)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (Wetterdaten[innereSchleife].Luftdruck < Wetterdaten[pivot].Luftdruck && AscDesc)
                        {
                            pivot = innereSchleife;
                        }
                    }
                    Swap(ref Wetterdaten, aeussereSchleife, pivot);
                }
            }
            else if (Parameter == 3)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (Wetterdaten[innereSchleife].Luftfeuchtigkeit < Wetterdaten[pivot].Luftfeuchtigkeit && AscDesc)
                        {
                            pivot = innereSchleife;
                        }
                    }
                    Swap(ref Wetterdaten, aeussereSchleife, pivot);
                }
            }
            else
            {
                //Nichts
            }
        }
    }
}