using System;

namespace Wetterstation
{
    partial class main
    {
        static bool InputMaskEnterEntryPosition(ref Record[] weatherData, ref int position, string headline)
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
                Console.SetCursorPosition(0, Console.WindowHeight - 4);
                Console.WriteLine("Wollen Sie vorher nochmal alle Datensätze anschauen?\r\nFalls ja drücken sie die F1-Taste.");
                Console.WriteLine("Drücken Sie die Eingabe-Taste, um ihre Auswahl zu bestätigen.");
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
                    position = Convert.ToInt32(userInput);
                    return true;
                }
                else if (char.IsDigit(key.KeyChar))
                {
                    userInput += key.KeyChar;
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    ShowFullData(ref weatherData);
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