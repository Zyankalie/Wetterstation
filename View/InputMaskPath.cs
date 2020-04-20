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
        static bool InputMaskPath(bool ImportExport, ref string Path)
        {
            string Headline = "";
            string ErrorMessage = "";
            if (ImportExport)
            {
                Headline = "Bitte geben Sie den relativen Pfad zu der Datei an,\r\nwelche importiert werden soll.";
                ErrorMessage = "Der Dateipfad \"" + Path + "\" existiert nicht. Bitte überprüfen Sie Ihre Eingabe!";
            }
            else
            {
                Headline = "Bitte geben Sie den relativen Pfad zu dem Verzeichnis an,\r\nin welche die Wetterdaten exportiert werden sollen";
                ErrorMessage = "Das Verzeichnis \"" + Path + "\" existiert nicht. Bitte überprüfen Sie Ihre Eingabe!";
            }
            Path = "";
            bool PathProcess = true;
            Console.CursorVisible = true;
            string ErrorShown = "";
            do
            {
                Console.Clear();
                Console.WriteLine(Headline);
                Console.WriteLine("Bestätigen Sie die Eingabe mit der Eingabetaste.");
                Console.WriteLine("Um zurück zu gelangen drücken Sie die Escape Taste.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Dateipfad: " + Path);
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ErrorShown);
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorTop = 6;
                Console.CursorLeft = 11 + Path.Length;

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    PathProcess = false;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    ErrorShown = "";
                    Path = Path.Substring(0, Path.Length > 0 ? Path.Length - 1 : 0);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (ImportExport)
                    {
                        if (File.Exists(Path))
                        {
                            return true;
                        }
                        else
                        {
                            ErrorShown = ErrorMessage;
                        }
                    }
                    else
                    {
                        if (Directory.Exists(Path))
                        {
                            return true;
                        }
                        else
                        {
                            ErrorShown = ErrorMessage;
                        }
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    ErrorShown = "";
                    Path = Path + key.KeyChar;
                }
                else
                {

                }
            } while (PathProcess);
            return false;
        }
    }
}