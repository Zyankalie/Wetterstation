using System;

namespace Wetterstation
{
    partial class main
    {
        static int ShowSomeMenu(ref string[] MenuPoints, string Headline)
        {

            int curItem = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                Console.Clear();
                Console.WriteLine(Headline + "\n");

                for (int counter = 0; counter < MenuPoints.Length; counter++)
                {
                    if (curItem == counter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(MenuPoints[counter]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(MenuPoints[counter]);
                    }
                }

                Console.WriteLine("\n\nNavigieren können Sie mit den Pfeiltasten.\nBestätigen Sie Ihre Eingabe mit der return-Taste.");
                key = Console.ReadKey(true);
                if (key.Key.ToString() == "DownArrow")
                {
                    curItem++;
                    if (curItem > MenuPoints.Length - 1) curItem = 0;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    curItem--;
                    if (curItem < 0) curItem = Convert.ToInt32(MenuPoints.Length - 1);
                }
            } while (key.Key.ToString() != "Enter");
            return curItem;
        }
    }
}