using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowFullData(ref Datensatz[] Wetterdaten)
        {
            bool ContentIsShown = true;
            int currPage = 0;
            string currData = "";
            Defragment(ref Wetterdaten);
            int numberPagesFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (Wetterdaten[i].Datum != "  .  .    ")
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
                Console.WriteLine("Datum            Lufttemperatur            Luftdruck            Luftfeuchtigkeit");
                Console.ForegroundColor = ConsoleColor.White;

                for (int PageContent = currPage * 15; (PageContent < (currPage * 15 + 15)) && (PageContent < 366); PageContent++)
                {
                    if (Wetterdaten[PageContent].Datum != "  .  .    ")
                    {
                        currData += Wetterdaten[PageContent].Datum
                        + new string(' ', 8 + (4 - Wetterdaten[PageContent].Lufttemperatur.ToString("N1").Length)) + Wetterdaten[PageContent].Lufttemperatur.ToString("N1") + "°C"
                        + new string(' ', 19 + (4 - Wetterdaten[PageContent].Luftdruck.ToString().Length)) + Wetterdaten[PageContent].Luftdruck + "HPa"
                        + new string(' ', 15 + (3 - Wetterdaten[PageContent].Luftfeuchtigkeit.ToString().Length)) + Wetterdaten[PageContent].Luftfeuchtigkeit + "%";
                        Console.WriteLine(currData);
                    }
                    currData = "";
                }

                Console.SetCursorPosition(0, Console.BufferHeight - 6);

                Console.Write("Schließen [esc]" + new string(' ', Console.BufferWidth - 28) + "Seite ");
                Console.Write("[" + (currPage + 1 > 9 ? "" : "0") + (currPage + 1) + "/" + (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");



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
                    ContentIsShown = false;
                }
            } while (ContentIsShown);
        }

        static void ShowFullData(ref Datensatz[] Wetterdaten, int SearchedEntry)
        {
            bool ContentIsShown = true;
            int currPage = 0;
            string currData = "";
            Defragment(ref Wetterdaten);
            int numberPagesFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (Wetterdaten[i].Datum != "  .  .    ")
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
                int counter = 1;
                for (int PageContent = currPage * 15; (PageContent < (currPage * 15 + 15)) && (PageContent < 366); PageContent++)
                {
                    if (Wetterdaten[PageContent].Datum != "  .  .    ")
                    {
                        if (PageContent == SearchedEntry)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        currData += new string(' ', 3 - (currPage * 15 + counter).ToString().Length) + (currPage * 15 + counter)
                            + "    " + Wetterdaten[PageContent].Datum
                        + new string(' ', 8 + (3 - Wetterdaten[PageContent].Lufttemperatur.ToString("N1").Length)) + Wetterdaten[PageContent].Lufttemperatur.ToString("N1") + "°C"
                        + new string(' ', 15 + (3 - Wetterdaten[PageContent].Luftdruck.ToString().Length)) + Wetterdaten[PageContent].Luftdruck + "HPa"
                        + new string(' ', 14 + (2 - Wetterdaten[PageContent].Luftfeuchtigkeit.ToString().Length)) + Wetterdaten[PageContent].Luftfeuchtigkeit + "%";
                        Console.WriteLine(currData);
                        Console.ForegroundColor = ConsoleColor.White;
                        counter++;
                    }
                    currData = "";
                }

                Console.SetCursorPosition(0, Console.BufferHeight - 6);

                Console.Write("Schließen [esc]" + new string(' ', Console.BufferWidth - 28) + "Seite ");
                Console.Write("[" + (currPage + 1 > 9 ? "" : "0") + (currPage + 1) + "/" + (numberPagesFilled > 9 ? "" : "0") + numberPagesFilled + "]");



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
                    ContentIsShown = false;
                }
            } while (ContentIsShown);
        }
    }
}