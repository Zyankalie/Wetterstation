//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ShowFullData.cs
//Datum:        06.04.2020
//Beschreibung: Gibt das komplette Array graphisch in der Konsole aus.
//              Überladung mit zusätzlichem Integer: Dieser Wert wird in grün angezeigt, für Suchfunktionen.
//Aenderungen:  06.04.2020 Erstellung
//              10.04.2020 Zweite Methode mit Markieren von Eintrag
//              16.04.2020 Anzeigen von Pfeiltasten
using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowFullData(ref Record[] weatherData)
        {
            bool contentIsShown = true;
            int currPage = 0;
            string currData = "";
            DefragmentArray(ref weatherData);
            int numberPagesFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (weatherData[i].date != "  .  .    ")
                {
                    numberPagesFilled++;
                }
            }

            if (numberPagesFilled % 15 == 0)
            {
                numberPagesFilled /= 15;
            }
            else
            {
                numberPagesFilled /= 15;
                numberPagesFilled++;
            }


            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pos    Datum           Temperatur           Luftdruck           Luftfeuchtigkeit");
                Console.ForegroundColor = ConsoleColor.White;

                for (int PageContent = currPage * 15; (PageContent < (currPage * 15 + 15)) && (PageContent < 366); PageContent++)
                {
                    if (weatherData[PageContent].date != "  .  .    ")
                    {
                        currData += new string(' ', 3 - (PageContent + 1).ToString().Length) + (PageContent + 1)
                            + "    " + weatherData[PageContent].date
                        + new string(' ', 8 + (3 - weatherData[PageContent].airTemperature.ToString("N1").Length)) + weatherData[PageContent].airTemperature.ToString("N1") + "°C"
                        + new string(' ', 15 + (3 - weatherData[PageContent].airPressure.ToString().Length)) + weatherData[PageContent].airPressure + "HPa"
                        + new string(' ', 14 + (2 - weatherData[PageContent].humidity.ToString().Length)) + weatherData[PageContent].humidity + "%";
                        Console.WriteLine(currData);
                    }
                    currData = "";
                }

                Console.SetCursorPosition(0, Console.BufferHeight - 6);

                Console.Write("Schließen [esc]" + new string(' ', Console.BufferWidth - 28) + "Seite ");
                Console.Write("[" + (currPage + 1 > 9 ? "" : "0") + (currPage + 1) + "/" + (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");
                Console.WriteLine();
                Console.WriteLine(new string(' ', 25) + ((currPage == 0) ? new string(' ', 15) : "Vorherige Seite") + "     " + ((currPage == numberPagesFilled - 1) ? new string(' ', 13) : "Nächste Seite"));
                Console.WriteLine(new string(' ', 37) + ((currPage == 0) ? "   " : "<--") + "     " + ((currPage == numberPagesFilled - 1) ? "   " : "-->"));


                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key.ToString() == "LeftArrow")
                {
                    if (currPage != 0)
                    {
                        currPage--;
                    }
                }
                else if (key.Key.ToString() == "RightArrow")
                {
                    if (currPage < numberPagesFilled - 1)
                    {
                        currPage++;
                    }
                }
                else if (key.Key.ToString() == "Escape")
                {
                    contentIsShown = false;
                }
            } while (contentIsShown);
        }

        static void ShowFullData(ref Record[] weatherData, int searchedEntry)
        {
            bool contentIsShown = true;
            int currPage = searchedEntry / 15;
            string currData = "";
            DefragmentArray(ref weatherData);
            int numberPagesFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (weatherData[i].date != "  .  .    ")
                {
                    numberPagesFilled++;
                }
            }

            if (numberPagesFilled % 15 == 0)
            {
                numberPagesFilled /= 15;
            }
            else
            {
                numberPagesFilled /= 15;
                numberPagesFilled++;
            }

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pos    Datum           Temperatur           Luftdruck           Luftfeuchtigkeit");
                Console.ForegroundColor = ConsoleColor.White;
                for (int PageContent = currPage * 15; (PageContent < (currPage * 15 + 15)) && (PageContent < 366); PageContent++)
                {
                    if (weatherData[PageContent].date != "  .  .    ")
                    {
                        if (PageContent == searchedEntry)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        currData += new string(' ', 3 - (PageContent + 1).ToString().Length) + (PageContent + 1)
                            + "    " + weatherData[PageContent].date
                        + new string(' ', 8 + (3 - weatherData[PageContent].airTemperature.ToString("N1").Length)) + weatherData[PageContent].airTemperature.ToString("N1") + "°C"
                        + new string(' ', 15 + (3 - weatherData[PageContent].airPressure.ToString().Length)) + weatherData[PageContent].airPressure + "HPa"
                        + new string(' ', 14 + (2 - weatherData[PageContent].humidity.ToString().Length)) + weatherData[PageContent].humidity + "%";
                        Console.WriteLine(currData);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    currData = "";
                }

                Console.SetCursorPosition(0, Console.BufferHeight - 6);

                Console.Write("Schließen [esc]" + new string(' ', Console.BufferWidth - 28) + "Seite ");
                Console.Write("[" + (currPage + 1 > 9 ? "" : "0") + (currPage + 1) + "/" + (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");
                Console.WriteLine();
                Console.WriteLine(new string(' ', 25) + ((currPage == 0) ? new string(' ', 15) : "Vorherige Seite") + "     " + ((currPage == numberPagesFilled - 1) ? new string(' ', 13) : "Nächste Seite"));
                Console.WriteLine(new string(' ', 37) + ((currPage == 0) ? "   " : "<--") + "     " + ((currPage == numberPagesFilled - 1) ? "   " : "-->"));

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key.ToString() == "LeftArrow")
                {
                    if (currPage != 0)
                    {
                        currPage--;
                    }
                }
                else if (key.Key.ToString() == "RightArrow")
                {
                    if (currPage < numberPagesFilled - 1)
                    {
                        currPage++;
                    }
                }
                else if (key.Key.ToString() == "Escape")
                {
                    contentIsShown = false;
                }
            } while (contentIsShown);
        }
    }
}