using System;

namespace Wetterstation
{
    partial class main
    {
        

        static void run()
        {
            Console.CursorVisible = false;
            Datensatz[] Wetterdaten = new Datensatz[366];
            for (int i = 0; i < Wetterdaten.Length; i++)
            {
                Wetterdaten[i].Datum = "11.11.1111";
                Wetterdaten[i].Lufttemperatur = 0.0d;
                Wetterdaten[i].Luftdruck = 0;
                Wetterdaten[i].Luftfeuchtigkeit = 0;
            }
            Wetterdaten[0].Datum = "19.11.1996";
            Wetterdaten[0].Lufttemperatur = 26.4;
            Wetterdaten[0].Luftdruck = 1000;
            Wetterdaten[0].Luftfeuchtigkeit = 43;

            Wetterdaten[22].Datum = "19.11.2020";
            Wetterdaten[22].Lufttemperatur = 26.4;
            Wetterdaten[22].Luftdruck = 1000;
            Wetterdaten[22].Luftfeuchtigkeit = 43;

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
