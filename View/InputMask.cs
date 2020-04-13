﻿using System;

namespace Wetterstation
{
    partial class main
    {
        static bool InputMask(ref Datensatz[] Wetterdaten, ref Datensatz newEntry, ref int Pos)
        {
            bool Editing = true;
            int currentline = 0;
            string[] UserInputs = { "", "", "", "", "" };
            string[] Parameters = { "Datum", "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit", "Position" };
            string[] MenuPath = { "Datenverwalten Menü", "Eingabe fortsetzen" };

            do
            {
                Console.Clear();
                Console.WriteLine("Bitte geben Sie die Werte für einen neuen Datensatz ein:");
                for (int i = 0; i < Parameters.Length; i++)
                {
                    if (i == currentline)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(Parameters[i] + ": " + UserInputs[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    Editing = false;
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

                    UserInputs[currentline] = UserInputs[currentline].Substring(0, UserInputs[currentline].Length > 0 ? UserInputs[currentline].Length - 1 : 0);

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    newEntry.Datum = UserInputs[0];
                    newEntry.Lufttemperatur = Convert.ToDouble(UserInputs[1]);
                    newEntry.Luftdruck = Convert.ToInt32(UserInputs[2]);
                    newEntry.Luftfeuchtigkeit = Convert.ToInt32(UserInputs[3]);
                    int Validation = ValidateEntry(ref Wetterdaten, ref newEntry);
                    if (UserInputs[4] != "" && (Convert.ToInt32(UserInputs[4]) > 366 || (Convert.ToInt32(UserInputs[4]) < 1)))
                    {
                        Validation += 64;
                    }
                    if (Validation != 0)
                    {
                        int Option = ShowSomeMenu(ref MenuPath, ShowErrorMessage(Validation));
                        if (Option == 0)
                        {
                            Editing = false;
                            return false;
                        }
                        else if (Option == 1)
                        {

                        }
                    }
                    else
                    {
                        Pos = Convert.ToInt32(UserInputs[4] == "" ? "-1" : UserInputs[4]);
                        Editing = false;
                        return true;
                    }
                }
                else
                {
                    if (currentline == 0)
                    {
                        if (key.KeyChar == '.' || char.IsLetterOrDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 1)
                    {
                        if (key.KeyChar == ',' || char.IsDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 2)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 3)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 4)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                }
            } while (Editing);
            return false;
        }

        static bool InputMask(ref Datensatz[] Wetterdaten, ref Datensatz newEntry, string date, string temperature, string pressure, string humidity, string position)
        {
            bool Editing = true;
            int currentline = 0;
            string[] UserInputs = { date, temperature, pressure, humidity, position };
            string[] Parameters = { "Datum", "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit", "Position" };
            string[] MenuPath = { "Datenverwalten Menü", "Eingabe fortsetzen" };

            do
            {
                Console.Clear();
                Console.WriteLine("Bitte geben Sie die Werte für einen neuen Datensatz ein:");
                for (int i = 0; i < Parameters.Length; i++)
                {
                    if (i == currentline)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(Parameters[i] + ": " + UserInputs[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    Editing = false;
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

                    UserInputs[currentline] = UserInputs[currentline].Substring(0, UserInputs[currentline].Length > 0 ? UserInputs[currentline].Length - 1 : 0);

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    newEntry.Datum = UserInputs[0];
                    newEntry.Lufttemperatur = Convert.ToDouble(UserInputs[1]);
                    newEntry.Luftdruck = Convert.ToInt32(UserInputs[2]);
                    newEntry.Luftfeuchtigkeit = Convert.ToInt32(UserInputs[3]);
                    int Validation = ValidateEntry(ref Wetterdaten, ref newEntry);

                    if (Validation != 0)
                    {
                        int Option = ShowSomeMenu(ref MenuPath, ShowErrorMessage(Validation));
                        if (Option == 0)
                        {
                            Editing = false;
                            return false;
                        }
                        else if (Option == 1)
                        {

                        }
                    }
                    else
                    {
                        Editing = false;
                        return true;
                    }
                }
                else
                {
                    if (currentline == 0)
                    {
                        if (key.KeyChar == '.' || char.IsLetterOrDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 1)
                    {
                        if (key.KeyChar == ',' || char.IsDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 2)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                    else if (currentline == 3)
                    {
                        if (char.IsDigit(key.KeyChar))
                        {
                            UserInputs[currentline] += key.KeyChar;
                        }
                    }
                }
            } while (Editing);
            return false;
        }
    }
}