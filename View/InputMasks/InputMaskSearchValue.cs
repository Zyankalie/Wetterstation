using System;
using System.Linq;

namespace Wetterstation
{
    partial class main
    {
        static void InputMaskSearchValue(int searchParameter, ref string userInput)
        {
            bool userInputActive = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Bitte den Suchwert für den Parameter " + IntToParam(searchParameter) + " eingeben.");
                Console.WriteLine(userInput);
                Console.CursorTop = 2;
                Console.CursorLeft = userInput.Length;

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
                    userInputActive = false;
                }
                else
                {
                    if (searchParameter == 0)
                    {
                        if (char.IsDigit(key.KeyChar) || (key.Key == ConsoleKey.OemPeriod && 3 > userInput.Count(f => f == '.') && userInput.Length < 10))
                        {
                            userInput += key.KeyChar;
                        }
                    }
                    else if (searchParameter == 1)
                    {
                        if (char.IsDigit(key.KeyChar) || (key.Key == ConsoleKey.OemComma && 2 > userInput.Count(f => f == ',') && userInput.Length < 4))
                        {
                            userInput += key.KeyChar;
                        }
                    }
                    else if (searchParameter == 2)
                    {
                        if (char.IsDigit(key.KeyChar) && userInput.Length < 4)
                        {
                            userInput += key.KeyChar;
                        }
                    }
                    else if (searchParameter == 3)
                    {
                        if (char.IsDigit(key.KeyChar) && userInput.Length < 3)
                        {
                            userInput += key.KeyChar;
                        }
                    }
                }
            }
            while (userInputActive);
        }
    }
}