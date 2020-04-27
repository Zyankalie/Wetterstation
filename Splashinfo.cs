//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Splashinfo.cs
//Datum:        19.04.2020
//Beschreibung: Gibt eine Splashinfo über das Projekt auf der Konsole aus
//Aenderungen:  19.04.2020 Erstellung
using System;
using System.Threading;

namespace Wetterstation
{
    partial class main
    {
        static void Splashinfo()
        {
            string[] titles = { "Projektname:", "Version:", "Datum:", "Autor:", "Klasse:" };
            string[] information = { "Wetterstation", "1.0", "06.04.2020", "Jan-Lukas Spilles", "IA119" };
            Console.CursorTop = 5;            
            for (int i = 0; i < information.Length; i++)
            {
                Console.CursorLeft = (Console.WindowWidth - 30) / 2;
                Console.WriteLine("{0,-10}{1,20}", titles[i], information[i]);
                Thread.Sleep(400);
            }
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.WindowHeight - 2);
            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
        }
    }
}