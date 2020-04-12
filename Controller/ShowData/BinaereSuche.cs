using System;

namespace Wetterstation
{
    partial class main
    {
        static int BinaereSuche(ref Datensatz[] Wetterdaten, int Parameter, string SearchValue)
        {
            Defragment(ref Wetterdaten);
            BubbleSort(ref Wetterdaten, Parameter, true);
            int Pivot = -1;
            int UntereGrenze = 0;
            int ObereGrenze = FindUpperBorder(ref Wetterdaten);
            int Pos = -1;

            if (Parameter == 0)
            {
                while (ObereGrenze >= UntereGrenze)
                {
                    Pivot = UntereGrenze + ((ObereGrenze - UntereGrenze) / 2);
                    if (Wetterdaten[Pivot].Datum == SearchValue)
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (CompareDates(SearchValue, Wetterdaten[Pivot].Datum))
                    {
                        UntereGrenze = Pivot + 1;
                    }
                    else //(CompareDates(SearchValue, Wetterdaten[Pivot].Datum, false))
                    {
                        ObereGrenze = Pivot - 1;
                    }
                }                
            }
            else if (Parameter == 1)
            {
                while (ObereGrenze >= UntereGrenze)
                {
                    Pivot = UntereGrenze + ((ObereGrenze - UntereGrenze) / 2);
                    if (Wetterdaten[Pivot].Lufttemperatur == Convert.ToDouble(SearchValue))
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (Convert.ToDouble(SearchValue) > Wetterdaten[Pivot].Lufttemperatur)
                    {
                        UntereGrenze = Pivot + 1;
                    }
                    else if (Convert.ToDouble(SearchValue) < Wetterdaten[Pivot].Lufttemperatur)
                    {
                        ObereGrenze = Pivot - 1;
                    }
                }
            }
            else if (Parameter == 2)
            {
                while (ObereGrenze >= UntereGrenze)
                {
                    Pivot = UntereGrenze + ((ObereGrenze - UntereGrenze) / 2);
                    if (Wetterdaten[Pivot].Luftdruck == Convert.ToInt32(SearchValue))
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (Convert.ToInt32(SearchValue) > Wetterdaten[Pivot].Luftdruck)
                    {
                        UntereGrenze = Pivot + 1;
                    }
                    else if (Convert.ToInt32(SearchValue) < Wetterdaten[Pivot].Luftdruck)
                    {
                        ObereGrenze = Pivot - 1;
                    }
                }
            }
            else if (Parameter == 3)
            {
                while (ObereGrenze >= UntereGrenze)
                {
                    Pivot = UntereGrenze + ((ObereGrenze - UntereGrenze) / 2);
                    if (Wetterdaten[Pivot].Luftfeuchtigkeit == Convert.ToInt32(SearchValue))
                    {
                        Pos = Pivot;
                        break;
                    }
                    else if (Convert.ToInt32(SearchValue) > Wetterdaten[Pivot].Luftfeuchtigkeit)
                    {
                        UntereGrenze = Pivot + 1;
                    }
                    else if (Convert.ToInt32(SearchValue) < Wetterdaten[Pivot].Luftfeuchtigkeit)
                    {
                        ObereGrenze = Pivot - 1;
                    }
                }
            }
            else
            {
                //Nichts
            }
            return Pos;
        }
    }
}