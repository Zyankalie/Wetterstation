//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ShowSomeMenu.cs
//Datum:        10.04.2020
//Beschreibung: Erhält eine Headline und ein String-Array mit Menüpunkten
//              Auswahl über Pfeiltasten/Entertaste.
//              Nach Auswahl gibt Funktion als int die Position des ausgewählten 
//              Menüpunkts zurück. (Fängt bei 0 an)
//Aenderungen:  10.04.2020 Erstellung
using System;

namespace Wetterstation
{
    partial class main
    {
        static int ShowSomeMenu(ref string[] menuPoints, string headline)
        {

            int curItem = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                Console.Clear();
                Console.WriteLine(headline + "\n");

                for (int counter = 0; counter < menuPoints.Length; counter++)
                {
                    WriteWithColor((curItem == counter) ? ConsoleColor.Green : ConsoleColor.White, menuPoints[counter]);
                }

                Console.WriteLine("\n\nNavigieren können Sie mit den Pfeiltasten.\nBestätigen Sie Ihre Eingabe mit der return-Taste.");
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    curItem++;
                    if (curItem > menuPoints.Length - 1) 
                        curItem = 0;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    curItem--;
                    if (curItem < 0) 
                        curItem = menuPoints.Length - 1;
                }
                else
                {
                    //Nichts
                }
            } while (key.Key != ConsoleKey.Enter);
            return curItem;
        }
    }
}