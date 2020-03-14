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

            int Entries = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Datum            Lufttemperatur            Luftdruck            Luftfeuchtigkeit");
                Console.ForegroundColor = ConsoleColor.White;
                for(int i = 0; i< 366;i++)
                {
                    if (Wetterdaten[i].Datum != "  .  .    ")
                    {
                        Entries++;                        
                    }
                }
                for (int PageContent = currPage * 15; (PageContent < (currPage * 15 + 15)) && (PageContent < 366); PageContent++)
                {
                    if (Wetterdaten[PageContent].Datum != "  .  .    ")
                    {
                        Entries++;
                        currData += Wetterdaten[PageContent].Datum
                        + new string(' ', 8 + (4 - Wetterdaten[PageContent].Lufttemperatur.ToString("N1").Length)) + Wetterdaten[PageContent].Lufttemperatur.ToString("N1") + "°C"
                        + new string(' ', 19 + (4 - Wetterdaten[PageContent].Luftdruck.ToString().Length)) + Wetterdaten[PageContent].Luftdruck + "HPa"
                        + new string(' ', 15 + (3 - Wetterdaten[PageContent].Luftfeuchtigkeit.ToString().Length)) + Wetterdaten[PageContent].Luftfeuchtigkeit + "%"
                        + "\n";
                        Console.WriteLine(currData);
                    }
                }
                if (currPage == 24)
                {
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nSchließen [esc]" + new string(' ', 53) + "Seite ");
                    Console.Write("[" + (currPage + 1) + "/" + 25 + "]");
                }
                else
                {
                    Console.Write("\n\n\n\n\n\nSchließen [esc]" + new string(' ', 53) + "Seite ");
                    Console.Write("[" + (currPage + 1) + "/" + 25 + "]");
                }

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
                    if (currPage < 24)
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