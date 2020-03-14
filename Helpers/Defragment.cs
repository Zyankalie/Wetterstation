using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void Defragment(ref Datensatz[] Wetterdaten)
        {
            bool WurdeGetauscht = true;
            while (WurdeGetauscht)
            {
                WurdeGetauscht = false;
                for (int i = 1; i < Wetterdaten.Length - 1; i++)
                {
                    if (Wetterdaten[i - 1].Datum == "  .  .    " && Wetterdaten[i].Datum != "  .  .    ")
                    {
                        WurdeGetauscht = true;
                        Swap(ref Wetterdaten, i, i - 1);
                    }
                }
            }

        }
    }
}
