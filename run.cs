using System;

namespace Wetterstation
{
    partial class main
    {
        

        static void run()
        {
            Console.CursorVisible = false;
            Datensatz[] Wetterdaten = new Datensatz[366];
            FillWetterdaten(ref Wetterdaten, 365);
            MainMenu(ref Wetterdaten);
        }
        struct Datensatz
        {
            public string Datum;
            public double Lufttemperatur;
            public int Luftdruck;
            public int Luftfeuchtigkeit;
        }
    }
    
}
