//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        InputMaskPath.cs
//Datum:        20.04.2020
//Beschreibung: Eingabemaske für das Hinzufügen von Dateipfaden
//Aenderungen:  20.04.2020 Erstellung
using System;
using System.IO;

namespace Wetterstation
{
    partial class main
    {
        static bool InputMaskPath(bool importExport, ref string path)
        {
            string headline;
            string errorMessage;
            if (importExport)
            {
                headline = "Bitte geben Sie den relativen Pfad zu der Datei an,\r\nwelche importiert werden soll.";
                errorMessage = "Der Dateipfad \"" + path + "\" existiert nicht. Bitte überprüfen Sie Ihre Eingabe!";
            }
            else
            {
                headline = "Bitte geben Sie den relativen Pfad zu dem Verzeichnis an,\r\nin welche die Wetterdaten exportiert werden sollen.";
                errorMessage = "Das Verzeichnis \"" + path + "\" existiert nicht. Bitte überprüfen Sie Ihre Eingabe!";
            }
            path = "";
            bool pathProcess = true;
            Console.CursorVisible = true;
            string errorShown = "";
            do
            {
                Console.Clear();
                Console.WriteLine(headline);
                Console.WriteLine();
                Console.WriteLine("Bestätigen Sie die Eingabe mit der Eingabetaste.");
                Console.WriteLine("Um zurück zu gelangen drücken Sie die Escape Taste.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sie befinden sich im Pfad:");
                WriteWithColor(ConsoleColor.Green, Directory.GetCurrentDirectory());
                Console.WriteLine();
                Console.WriteLine("Dateipfad: " + path);
                Console.WriteLine();
                Console.WriteLine();
                WriteWithColor(ConsoleColor.Red, errorShown);
                Console.CursorTop = 10;
                Console.CursorLeft = 11 + path.Length;

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    pathProcess = false;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    errorShown = "";
                    path = path.Substring(0, path.Length > 0 ? path.Length - 1 : 0);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (importExport)
                    {
                        if (File.Exists(Directory.GetCurrentDirectory() + "\\" + path))
                        {
                            path = Directory.GetCurrentDirectory() + "\\" + path;
                            Console.CursorVisible = false;
                            return true;
                        }
                        else
                        {
                            errorShown = errorMessage;
                        }
                    }
                    else
                    {
                        if (!File.Exists(Directory.GetCurrentDirectory() + "\\" + path))
                        {
                            path = Directory.GetCurrentDirectory() + "\\" + path;
                            Console.CursorVisible = false;
                            return true;
                        }
                        else
                        {
                            errorShown = errorMessage;
                        }
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    errorShown = "";
                    path += key.KeyChar;
                }
                else
                {
                    //Nichts
                }
            } while (pathProcess);
            return false;
        }
    }
}