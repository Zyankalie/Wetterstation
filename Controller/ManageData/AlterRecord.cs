using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void AlterRecord(ref Datensatz[] Wetterdaten, int Pos, Datensatz Altered)
        {
            if (ValidateEntry(ref Wetterdaten, Altered) == 4)
            {
                Wetterdaten[Pos] = Altered;
            }
        }
    }
}
