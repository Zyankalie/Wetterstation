//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        WriteWithColor.cs
//Datum:        04.05.2020
//Beschreibung: Schreibt eine Zeile in einer
//              übergebenen Farbe und setzt 
//              danach die Farbe wieder zurück.
//Aenderungen:  04.05.2020 Erstellung
using System;

namespace Wetterstation
{
    partial class main
    {
        static void WriteWithColor(ConsoleColor color, string format, params string[] text)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(format, text);
            Console.ForegroundColor = oldColor;
        }

        static void WriteWithColor(ConsoleColor color, params string[] text)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }
    }
}
