using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void AddRecord(ref Datensatz[] Wetterdaten, ref Datensatz NewEntry, ref int Position)
        {
            if (Position == -1)
            {
                Wetterdaten[FindUpperBorder(ref Wetterdaten)] = NewEntry;
            }
            else
            {
                FreeASpot(ref Wetterdaten, Position - 1);
                Wetterdaten[Position - 1] = NewEntry;
            }
        }
    }
}
