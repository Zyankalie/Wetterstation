//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        InputMaskNewEntry.cs
//Datum:        16.04.2020
//Beschreibung: Eingabemaske für das Hinzufügen von Datensätzen
//Aenderungen:  16.04.2020 Erstellung
using System;
using System.Linq;

namespace Wetterstation
{
    partial class main
    {
        static bool InputMaskEntryManipulation(ref Record[] weatherData, ref Record newEntry, ref int position)
        {
            bool editing = true;
            int currentline = 0;
            string[] userInputs = { "", "", "", "", position.ToString() };
            string[] parameters = { "Datum", "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit", "Position" };
            string[] menuPath = { "Datenverwalten Menü", "Eingabe fortsetzen" };

            do
            {
                Console.Clear();
                Console.WriteLine("Bitte geben Sie die Werte für einen neuen Datensatz ein:");
                for (int counter = 0; counter < parameters.Length; counter++)
                {
                    WriteWithColor((counter == currentline) ? ConsoleColor.Green : ConsoleColor.White, parameters[counter] + ": " + userInputs[counter]);
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    editing = false;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (currentline < 4)
                    {
                        currentline++;
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (currentline > 0)
                    {
                        currentline--;
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {

                    userInputs[currentline] = userInputs[currentline].Substring(0, userInputs[currentline].Length > 0 ? userInputs[currentline].Length - 1 : 0);

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    newEntry.date = userInputs[0];
                    newEntry.airTemperature = Convert.ToDouble(userInputs[1]);
                    newEntry.airPressure = Convert.ToUInt32(userInputs[2]);
                    newEntry.humidity = Convert.ToUInt32(userInputs[3]);
                    int validation = ValidateEntry(ref weatherData, ref newEntry);
                    if (userInputs[4] != "" && (Convert.ToInt32(userInputs[4]) > 366 || (Convert.ToInt32(userInputs[4]) < 1)))
                    {
                        validation += 64;
                    }
                    if (validation != 0)
                    {
                        int option = ShowSomeMenu(ref menuPath, GenerateErrorMessage(validation));
                        if (option == 0)
                        {
                            return false;
                        }
                        else if (option == 1)
                        {

                        }
                    }
                    else
                    {
                        position = Convert.ToInt32(userInputs[4] == "" ? "-1" : userInputs[4]);
                        return true;
                    }
                }
                else
                {
                    if (currentline == 0)
                    {
                        if (CanBeDate(userInputs[currentline], key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 1)
                    {
                        if (key.KeyChar == ',' || char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 2)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 3)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 4)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                }
            } while (editing);
            return false;
        }

        static bool InputMaskEntryManipulation(ref Record[] weatherData, ref Record newEntry, string date, string temperature, string pressure, string humidity, string position)
        {
            bool editing = true;
            int currentline = 0;
            string[] userInputs = { date, temperature, pressure, humidity, position };
            string[] parameters = { "Datum", "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit", "Position" };
            string[] menuPath = { "Datenverwalten Menü", "Eingabe fortsetzen" };

            do
            {
                Console.Clear();
                Console.WriteLine("Bitte geben Sie die Werte für einen neuen Datensatz ein:");
                for (int counter = 0; counter < parameters.Length; counter++)
                {
                    WriteWithColor((counter == currentline) ? ConsoleColor.Green : ConsoleColor.White, parameters[counter] + ": " + userInputs[counter]);
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    editing = false;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (currentline < 3)
                    {
                        currentline++;
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (currentline > 0)
                    {
                        currentline--;
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {

                    userInputs[currentline] = userInputs[currentline].Substring(0, userInputs[currentline].Length > 0 ? userInputs[currentline].Length - 1 : 0);

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    newEntry.date = userInputs[0];
                    newEntry.airTemperature = Convert.ToDouble(userInputs[1]);
                    newEntry.airPressure = Convert.ToUInt32(userInputs[2]);
                    newEntry.humidity = Convert.ToUInt32(userInputs[3]);
                    int validation = ValidateEntry(ref weatherData, ref newEntry);

                    if (validation != 0)
                    {
                        int option = ShowSomeMenu(ref menuPath, GenerateErrorMessage(validation));
                        if (option == 0)
                        {
                            return false;
                        }
                        else if (option == 1)
                        {

                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (currentline == 0)
                    {
                        if (CanBeDate(userInputs[currentline], key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 1)
                    {
                        if (key.KeyChar == ',' && userInputs[currentline].Length != 0 && 0 == userInputs[currentline].Count(x => x == ',') || char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 2)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 3)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            userInputs[currentline] += key.KeyChar;
                        }
                    }
                }
            } while (editing);
            return false;
        }
    }
}