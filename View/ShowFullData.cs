using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowFullData(ref Record[] WeatherData)
        {
            bool ContentIsShown = true;
            int currPage = 0;
            string currData = "";
            Defragment(ref WeatherData);
            int numberPagesFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (WeatherData[i].Date != "  .  .    ")
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
                    if (WeatherData[PageContent].Date != "  .  .    ")
                    {
                        currData += new string(' ', 3 - (PageContent + 1).ToString().Length) + (PageContent + 1)
                            + "    " + WeatherData[PageContent].Date
                        + new string(' ', 8 + (3 - WeatherData[PageContent].AirTemperature.ToString("N1").Length)) + WeatherData[PageContent].AirTemperature.ToString("N1") + "°C"
                        + new string(' ', 15 + (3 - WeatherData[PageContent].AirPressure.ToString().Length)) + WeatherData[PageContent].AirPressure + "HPa"
                        + new string(' ', 14 + (2 - WeatherData[PageContent].Humidity.ToString().Length)) + WeatherData[PageContent].Humidity + "%";
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
                    ContentIsShown = false;
                }
            } while (ContentIsShown);
        }

        static void ShowFullData(ref Record[] Wetterdaten, int SearchedEntry)
        {
            bool ContentIsShown = true;
            int currPage = SearchedEntry % 15;
            string currData = "";
            Defragment(ref Wetterdaten);
            int numberPagesFilled = 0;
            for (int i = 0; i < 366; i++)
            {
                if (Wetterdaten[i].Date != "  .  .    ")
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
                    if (Wetterdaten[PageContent].Date != "  .  .    ")
                    {
                        if (PageContent == SearchedEntry)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        currData += new string(' ', 3 - (PageContent + 1).ToString().Length) + (PageContent + 1)
                            + "    " + Wetterdaten[PageContent].Date
                        + new string(' ', 8 + (3 - Wetterdaten[PageContent].AirTemperature.ToString("N1").Length)) + Wetterdaten[PageContent].AirTemperature.ToString("N1") + "°C"
                        + new string(' ', 15 + (3 - Wetterdaten[PageContent].AirPressure.ToString().Length)) + Wetterdaten[PageContent].AirPressure + "HPa"
                        + new string(' ', 14 + (2 - Wetterdaten[PageContent].Humidity.ToString().Length)) + Wetterdaten[PageContent].Humidity + "%";
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
                    ContentIsShown = false;
                }
            } while (ContentIsShown);
        }
    }
}