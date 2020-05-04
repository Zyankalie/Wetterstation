//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ShowSortingStatistics.cs
//Datum:        04.05.2020
//Beschreibung: Ausgabemaske für Statistiken bzgl. Soriteralgorithmen
//Aenderungen:  04.05.2020 Erstellung

using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowSortingStatistics(int swapCounter, int ifCounter, double timeElapsed, int arrayAccessCounter, string sortingAlgorithm)
        {
            Console.Clear();
            Console.WriteLine("Sortierung durch " + sortingAlgorithm + " abgeschlossen.");
            Console.WriteLine();
            Console.WriteLine("Statistiken:");
            Console.WriteLine("Anzahl Tausche: " + swapCounter);
            Console.WriteLine("Anzahl Vergleiche: " + ifCounter);
            Console.WriteLine("Vergangene Zeit: " + timeElapsed + "[ms] => " + timeElapsed / 1000 + "[s]");
            Console.WriteLine("Anzahl Lesezugriffe: " + arrayAccessCounter);
            Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight - 2);
            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
            Console.ReadKey(true);
        }
    }
}
