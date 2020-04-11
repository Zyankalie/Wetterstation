using System;
using System.IO;

namespace Wetterstation
{
    partial class main
    {
        static void ManageDataMenu(ref Datensatz[] Wetterdaten)
        {
            bool MenueFinished = false;
            string[] ManageSelection = { "Datensatz hinzufügen", "Datensatz verändern", "Datensatz löschen", "Datensätze importieren", "Datensätze exportieren", "Zurück" };
            int Selection = -1;
            do
            {
                Selection = ShowSomeMenu(ref ManageSelection, "Daten verwalten");
                if (Selection == 0)
                {
                    //hinzufügen
                }
                else if (Selection == 1)
                {
                    //verändern
                }
                else if (Selection == 2)
                {
                    //Löschen
                }
                else if (Selection == 3)
                {
                    //Import
                    bool importProcess = true;
                    string ImportPath = "";
                    ConsoleKeyInfo info;
                    Console.Clear();
                    Console.CursorVisible = true;
                    do
                    {
                        ImportPath = "";
                        
                        Console.WriteLine("Bitte geben Sie den Pfad zu der Datei an, welche importiert werden soll und bestätigen Sie die Eingabe mit der Eingabetaste.");
                        Console.WriteLine("Um zurück zu gelangen drücken Sie die Escape Taste.");
                        info = Console.ReadKey(true);
                        while(info.Key != ConsoleKey.Enter && info.Key != ConsoleKey.Escape)
                        {
                            Console.Write(info.KeyChar);
                            ImportPath = ImportPath + info.KeyChar;
                            info = Console.ReadKey(true);
                        }

                        if (info.Key == ConsoleKey.Enter)
                        {
                            if (Directory.Exists(ImportPath))
                            {
                                ImportData(ref Wetterdaten, ImportPath);
                                importProcess = false;
                            }
                            else
                            {
                                Console.WriteLine("Dieser Pfad existiert nicht. Bitte überprüfen Sie Ihre Eingabe.");
                            }
                        }
                        else if (info.Key == ConsoleKey.Escape)
                        {
                            importProcess = false;
                        }
                        else
                        { 
                            //Nichts
                        }                                      
                    } while (importProcess);
                }
                else if (Selection == 4)
                { 
                    //Export
                }
                else if (Selection == 5)
                {
                    MenueFinished = true;
                }
                else
                { 
                    //Nichts
                }
            } while (!MenueFinished);
            //Datensatz hinzufügen
            //Mehrere Datensätze hinzufügen
            //Datensatz löschen
            //Datensatz verändern
            //Datensätze importieren
            //Datensätze exportieren
        }
    }
}