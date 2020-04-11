using System;

namespace Wetterstation
{
    partial class main
    {
        static int LineareSuche(ref Datensatz[] Wetterdaten, int Parameter, string SearchValue)
        {
            int i = 0;
            if (Parameter == 0)
            {
                for (i = 0; i < Wetterdaten.Length; i++)
                {
                    if (Wetterdaten[i].Datum == SearchValue)
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (Parameter == 1)
            {
                for (i = 0; i < Wetterdaten.Length; i++)
                {
                    if (Wetterdaten[i].Lufttemperatur== Convert.ToDouble(SearchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (Parameter == 2)
            {
                for (i = 0; i < Wetterdaten.Length; i++)
                {
                    if (Wetterdaten[i].Luftdruck == Convert.ToInt32(SearchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (Parameter == 3)
            {
                for (i = 0; i < Wetterdaten.Length; i++)
                {
                    if (Wetterdaten[i].Luftfeuchtigkeit == Convert.ToInt32(SearchValue))
                    {
                        return i;
                    }
                    else 
                    { 
                        //Nichts                    
                    }
                }
            }
            else 
            {
                return -1;
            }
            return -1;
        }
    }
}