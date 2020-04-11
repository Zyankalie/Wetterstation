using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void DeleteRecord(ref Datensatz[] Wetterdaten, int Pos)
        {
            Wetterdaten[Pos].Datum = "  .  .    ";
            Wetterdaten[Pos].Lufttemperatur = 0.0;
            Wetterdaten[Pos].Luftdruck = 0;
            Wetterdaten[Pos].Luftfeuchtigkeit = 0;
        }
    }
}
