using System;

namespace Wetterstation
{
    partial class main
    {
        static bool InputMaskEnterEntryPosition(ref int position, string headline)
        {
            bool userInputActive = true;
            string userInput = "";

            do
            {
                Console.Clear();
                Console.WriteLine(headline);
                Console.WriteLine(userInput);
                Console.CursorTop = 2;
                Console.CursorLeft = userInput.Length;
                Console.SetCursorPosition(0, Console.WindowHeight - 2);
                Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    userInputActive = false;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    userInput = userInput.Substring(0, userInput.Length > 0 ? userInput.Length - 1 : 0);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    position = Convert.ToInt32(Console.ReadLine());
                    return true;
                }
                else if (char.IsDigit(key.KeyChar))
                {
                    userInput += key.KeyChar;
                }
                else
                {
                    //Nichts
                }
            } while (userInputActive);
            return false;
        }
    }
}