using System;
using System.IO;

namespace Wetterstation
{
    partial class main
    {
        static void ManageDataMenu(ref Record[] WeatherData)
        {
            bool MenueFinished = false;
            string[] ManageSelection = { "Datensatz hinzufügen", "Datensatz verändern", "Datensatz löschen", "Datensätze importieren", "Datensätze exportieren", "Zurück" };
            string[] JaNein = { "Ja", "Nein" };
            int Selection = -1;
            bool ProcessOngoing = true;
            int Continue = -1;
            int Position = -1;
            Record newEntry;
            do
            {
                ProcessOngoing = true;
                Selection = ShowSomeMenu(ref ManageSelection, "Daten verwalten");
                if (Selection == 0)
                {
                    do
                    {
                        newEntry = new Record { Date = "  .  .    ", AirTemperature = 0.0d, AirPressure = 0, Humidity = 0 };
                        if (InputMask(ref WeatherData, ref newEntry, ref Position))
                        {
                            AddRecord(ref WeatherData, ref newEntry, ref Position);
                            Continue = ShowSomeMenu(ref JaNein, "Datensatz wurde hinzugefügt.\r\nWollen Sie einen weiteren Datensatz hinzufügen?");
                            if (Continue == 0)
                            {

                            }
                            else if (Continue == 1)
                            {
                                ProcessOngoing = false;
                            }
                            else
                            {
                                //Nichts
                            }
                        }
                        else
                        {
                            ProcessOngoing = false;
                        }
                    } while (ProcessOngoing);
                }
                else if (Selection == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Geben Sie die Position des Datensatzes an, den Sie anpassen wollen.");
                        Position = Convert.ToInt32(Console.ReadLine());
                        if (WeatherData[Position - 1].Date == "  .  .    ")
                        {
                            Continue = ShowSomeMenu(ref JaNein, ShowErrorMessage(128) + "Wollen Sie eine andere Position eingeben?");
                            if (Continue == 0)
                            {

                            }
                            else
                            {
                                ProcessOngoing = false;
                            }
                        }
                        else
                        {
                            newEntry = WeatherData[Position - 1];
                            if (InputMask(ref WeatherData, ref newEntry, newEntry.Date, newEntry.AirTemperature.ToString(), newEntry.AirPressure.ToString(), newEntry.Humidity.ToString(), Position.ToString()))
                            {
                                AlterRecord(ref WeatherData, Position - 1, ref newEntry);
                                Continue = ShowSomeMenu(ref JaNein, "Datensatz wurde angepasst.\r\nWollen Sie einen weiteren Datensatz anpassen?");
                                if (Continue == 0)
                                {

                                }
                                else if (Continue == 1)
                                {
                                    ProcessOngoing = false;
                                }
                                else
                                {
                                    //Nichts
                                }
                            }
                            else
                            {
                                ProcessOngoing = false;
                            }
                        }
                    } while (ProcessOngoing);
                }
                else if (Selection == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Geben Sie die Position des Datensatzes an, den Sie löschen wollen.");
                        Position = Convert.ToInt32(Console.ReadLine());
                        if (WeatherData[Position - 1].Date == "  .  .    ")
                        {
                            Continue = ShowSomeMenu(ref JaNein, ShowErrorMessage(128) + "Wollen Sie eine andere Position eingeben?");
                            if (Continue == 0)
                            {

                            }
                            else
                            {
                                ProcessOngoing = false;
                            }
                        }
                        else
                        {
                            DeleteRecord(ref WeatherData, Position - 1);
                            Continue = ShowSomeMenu(ref JaNein, "Datensatz wurde löschen.\r\nWollen Sie einen weiteren Datensatz löschen?");
                            if (Continue == 0)
                            {

                            }
                            else if (Continue == 1)
                            {
                                ProcessOngoing = false;
                            }
                            else
                            {
                                //Nichts
                            }
                        }
                    } while (ProcessOngoing);
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
                        while (info.Key != ConsoleKey.Enter && info.Key != ConsoleKey.Escape)
                        {
                            Console.Write(info.KeyChar);
                            ImportPath = ImportPath + info.KeyChar;
                            info = Console.ReadKey(true);
                        }

                        if (info.Key == ConsoleKey.Enter)
                        {
                            if (Directory.Exists(ImportPath))
                            {
                                ImportData(ref WeatherData, ImportPath);
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