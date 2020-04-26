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
                    if (curItem == counter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(menuPoints[counter]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(menuPoints[counter]);
                    }
                }

                Console.WriteLine("\n\nNavigieren können Sie mit den Pfeiltasten.\nBestätigen Sie Ihre Eingabe mit der return-Taste.");
                key = Console.ReadKey(true);
                if (key.Key.ToString() == "DownArrow")
                {
                    curItem++;
                    if (curItem > menuPoints.Length - 1) curItem = 0;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    curItem--;
                    if (curItem < 0) curItem = Convert.ToInt32(menuPoints.Length - 1);
                }
                else
                {
                    //Nichts
                }
            } while (key.Key.ToString() != "Enter");
            return curItem;
        }
    }
}