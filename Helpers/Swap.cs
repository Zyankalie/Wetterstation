using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void Swap(ref Datensatz[] Wetterdaten, int elem1, int elem2)
        {
            Datensatz tmp = new Datensatz { 
                Datum = Wetterdaten[elem1].Datum, 
                Lufttemperatur = Wetterdaten[elem1].Lufttemperatur,
                Luftdruck = Wetterdaten[elem1].Luftdruck, 
                Luftfeuchtigkeit = Wetterdaten[elem1].Luftfeuchtigkeit
            };

            Wetterdaten[elem1].Datum = Wetterdaten[elem2].Datum;
            Wetterdaten[elem1].Lufttemperatur = Wetterdaten[elem2].Lufttemperatur;
            Wetterdaten[elem1].Luftdruck = Wetterdaten[elem2].Luftdruck;
            Wetterdaten[elem1].Luftfeuchtigkeit = Wetterdaten[elem2].Luftfeuchtigkeit;

            Wetterdaten[elem2].Datum = tmp.Datum;
            Wetterdaten[elem2].Lufttemperatur = tmp.Lufttemperatur;
            Wetterdaten[elem2].Luftdruck = tmp.Luftdruck;
            Wetterdaten[elem2].Luftfeuchtigkeit = tmp.Luftfeuchtigkeit;

        }
    }
}
