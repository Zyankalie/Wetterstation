//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ShowFullData.cs
//Datum:        06.04.2020
//Beschreibung: Gibt das komplette Array graphisch in der Konsole aus.
//              Überladung mit zusätzlichem Integer: Dieser Wert wird in grün angezeigt, für Suchfunktionen.
//Aenderungen:  06.04.2020 Erstellung
//              10.04.2020 Zweite Methode mit Markieren von Eintrag
//              16.04.2020 Anzeigen von Pfeiltasten
//              27.04.2020 Formatanpassungen
using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowFullData(ref Record[] weatherData)
        {
            bool contentIsShown = true;
            int currentPage = 0;

            int upperBorder = FindUpperBorder(ref weatherData);

            int numberPagesFilled = upperBorder;
            numberPagesFilled = numberPagesFilled % 15 == 0 ? numberPagesFilled / 15 : (numberPagesFilled / 15) + 1;

            do
            {
                Console.Clear();
                WriteWithColor(ConsoleColor.Blue, "{0,3}{1,9}{2,25}{3,16}{4,27}", "Pos", "Datum", "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit");

                for (int currentEntry = currentPage * 15; (currentEntry < ((currentPage * 15) + 15)) && (currentEntry < upperBorder); currentEntry++)
                {
                    Console.WriteLine("{0,-3}{1,14}{2,11}°C{3,18}HPa{4,16}%", currentEntry + 1, weatherData[currentEntry].date.ToString(), weatherData[currentEntry].airTemperature.ToString("N1"), weatherData[currentEntry].airPressure, weatherData[currentEntry].humidity);
                }

                Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight - 3);
                Console.Write("{0,38}{1,18}", (currentPage == 0) ? new string(' ', 15) : "Vorherige Seite", (currentPage == numberPagesFilled - 1) ? new string(' ', 13) : "Nächste Seite");
                Console.Write("\n");
                Console.Write("{0,15}{1,23}{2,8}{3,34}", "Schließen [esc]", (currentPage == 0) ? "   " : "<--", (currentPage == numberPagesFilled - 1) ? "   " : "-->", "Seite [" + (currentPage + 1 > 9 ? "" : "0") + (currentPage + 1) + "/" + (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (currentPage != 0)
                    {
                        currentPage--;
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (currentPage < numberPagesFilled - 1)
                    {
                        currentPage++;
                    }
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    contentIsShown = false;
                }
                else if (key.Key == ConsoleKey.Home)
                {
                    currentPage = 0;
                }
                else if (key.Key == ConsoleKey.End)
                {
                    currentPage = numberPagesFilled - 1;
                }
                else
                {
                    //Absolut gar nichts
                }
            } while (contentIsShown);
        }

        static void ShowFullData(ref Record[] weatherData, int searchedEntry)
        {
            bool contentIsShown = true;
            int currentPage = 0;

            int upperBorder = FindUpperBorder(ref weatherData);

            int numberPagesFilled = upperBorder;
            numberPagesFilled = numberPagesFilled % 15 == 0 ? numberPagesFilled / 15 : numberPagesFilled / 15 + 1;

            do
            {
                Console.Clear();
                WriteWithColor(ConsoleColor.Blue, "{0,3}{1,9}{2,25}{3,16}{4,27}", "Pos", "Datum", "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit");

                for (int currentEntry = currentPage * 15; (currentEntry < (currentPage * 15 + 15)) && (currentEntry < upperBorder); currentEntry++)
                {
                    WriteWithColor((currentEntry == searchedEntry) ? ConsoleColor.Green : ConsoleColor.White, "{0,-3}{1,14}{2,11}°C{3,18}HPa{4,16}%", (currentEntry + 1).ToString(), weatherData[currentEntry].date.ToString(), weatherData[currentEntry].airTemperature.ToString("N1"), weatherData[currentEntry].airPressure.ToString(), weatherData[currentEntry].humidity.ToString());
                }

                Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight - 3);
                Console.Write("{0,38}{1,18}", (currentPage == 0) ? new string(' ', 15) : "Vorherige Seite", (currentPage == numberPagesFilled - 1) ? new string(' ', 13) : "Nächste Seite");
                Console.Write("\n");
                Console.Write("{0,15}{1,23}{2,8}{3,34}", "Schließen [esc]", (currentPage == 0) ? "   " : "<--", (currentPage == numberPagesFilled - 1) ? "   " : "-->", "Seite [" + (currentPage + 1 > 9 ? "" : "0") + (currentPage + 1) + "/" + (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (currentPage != 0)
                    {
                        currentPage--;
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (currentPage < numberPagesFilled - 1)
                    {
                        currentPage++;
                    }
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    contentIsShown = false;
                }
                else if (key.Key == ConsoleKey.Home)
                {
                    currentPage = 0;
                }
                else if (key.Key == ConsoleKey.End)
                {
                    currentPage = numberPagesFilled - 1;
                }
                else
                {
                    //Absolut gar nichts
                }
            } while (contentIsShown);
        }
    }
}