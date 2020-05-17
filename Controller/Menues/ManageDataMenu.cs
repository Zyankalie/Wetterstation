//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ManageDataMenu.cs
//Datum:        08.04.2020
//Beschreibung: Programmablauf für das Menü "Daten verwalten"
//Aenderungen:  08.04.2020 Erstellung
//              13.04.2020 Daten hinzufügen/löschen/verändern
//              14.04.2020 Pathvalidation

using System;
using System.IO;

namespace Wetterstation
{
    partial class main
    {
        static void ManageDataMenu(ref Record[] weatherData)
        {
            bool menueFinished = false;
            bool processOngoing;

            string[] manageSelection = { "Datensatz hinzufügen", "Datensatz verändern", "Datensatz löschen", "Datensätze importieren", "Datensätze exportieren", "Zurück" };
            string[] yesNo = { "Ja", "Nein" };
            string path = "";

            int selection;
            int doAnotherInput;
            int position = FindUpperBorder(ref weatherData);

            Record newEntry;

            do
            {
                processOngoing = true;
                selection = ShowSomeMenu(ref manageSelection, "Daten verwalten");
                if (selection == 0)
                {
                    do
                    {
                        newEntry = new Record { date = "  .  .    ", airTemperature = 0.0d, airPressure = 0, humidity = 0 };
                        if (InputMaskEntryManipulation(ref weatherData, ref newEntry, ref position))
                        {
                            AddRecord(ref weatherData, ref newEntry, position);
                            doAnotherInput = ShowSomeMenu(ref yesNo, "Datensatz wurde hinzugefügt.\r\nWollen Sie einen weiteren Datensatz hinzufügen?");
                            if (doAnotherInput == 1)
                            {
                                processOngoing = false;
                            }
                            else
                            {
                                //Nichts
                            }
                        }
                        else
                        {
                            processOngoing = false;
                        }
                    } while (processOngoing);
                }
                else if (selection == 1)
                {
                    do
                    {
                        if (InputMaskEnterEntryPosition(ref weatherData, ref position, "Geben Sie die Position des Datensatzes an, den Sie anpassen wollen."))
                        {
                            if (weatherData[position - 1].date == "  .  .    ")
                            {
                                doAnotherInput = ShowSomeMenu(ref yesNo, GenerateErrorMessage(128) + "Wollen Sie eine andere Position eingeben?");
                                if (doAnotherInput == 1)
                                {
                                    processOngoing = false;
                                }
                                else
                                {
                                    //Nichts
                                }
                            }
                            else
                            {
                                newEntry = weatherData[position - 1];
                                if (InputMaskEntryManipulation(ref weatherData, ref newEntry, newEntry.date, newEntry.airTemperature.ToString(), newEntry.airPressure.ToString(), newEntry.humidity.ToString(), position.ToString()))
                                {
                                    AlterRecord(ref weatherData, position - 1, ref newEntry);
                                    doAnotherInput = ShowSomeMenu(ref yesNo, "Datensatz wurde angepasst.\r\nWollen Sie einen weiteren Datensatz anpassen?");
                                    if (doAnotherInput == 1)
                                    {
                                        processOngoing = false;
                                    }
                                    else
                                    {
                                        //Nichts
                                    }
                                }
                                else
                                {
                                    processOngoing = false;
                                }
                            }
                        }
                        else
                        {
                            processOngoing = false;
                        }
                    } while (processOngoing);
                }
                else if (selection == 2)
                {
                    do
                    {
                        if (InputMaskEnterEntryPosition(ref weatherData, ref position, "Geben Sie die Position des Datensatzes an, den Sie löschen wollen."))
                        {
                            if (weatherData[position - 1].date == "  .  .    ")
                            {
                                doAnotherInput = ShowSomeMenu(ref yesNo, GenerateErrorMessage(128) + "Wollen Sie eine andere Position eingeben?");
                                if (doAnotherInput == 1)
                                {
                                    processOngoing = false;
                                }
                                else
                                {
                                    //Nichts
                                }
                            }
                            else
                            {
                                DeleteRecord(ref weatherData, position - 1);
                                doAnotherInput = ShowSomeMenu(ref yesNo, "Datensatz wurde gelöscht.\r\nWollen Sie einen weiteren Datensatz löschen?");
                                if (doAnotherInput == 1)
                                {
                                    processOngoing = false;
                                }
                                else
                                {
                                    //Nichts
                                }
                            }
                        }
                        else
                        {
                            processOngoing = false;
                        }
                    } while (processOngoing);
                }
                else if (selection == 3)
                {
                    //Import                    
                    if (InputMaskPath(true, ref path))
                    {
                        if (ShowSomeMenu(ref yesNo, "Sind Sie sicher, dass Sie diese Datei importieren wollen?\r\nAktuelle Daten werden unwiderruflich gelöscht,\r\nsofern keine Datensicherung vorliegt.") == 0)
                        {
                            Console.Clear();
                            string error = ImportData(ref weatherData, path);
                            Console.WriteLine("Import abgeschlossen!");
                            if (error != "")
                            {
                                Console.WriteLine(error);
                            }
                            else
                            {
                                //Nichts
                            }
                            Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight - 2);
                            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            //Nichts
                        }
                    }
                    else
                    {
                        //Nichts
                    }
                }
                else if (selection == 4)
                {
                    if (InputMaskPath(false, ref path))
                    {
                        ExportData(ref weatherData, path);
                        Console.Clear();
                        Console.WriteLine("Export abgeschlossen!");
                        Console.WriteLine("Die Datei befindet sich in folgendem Verzeichnis:\r\n");
                        WriteWithColor(ConsoleColor.Green, path.Substring(0, path.LastIndexOf("\\")));
                        Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight - 2);
                        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        //Nichts
                    }
                }
                else if (selection == 5)
                {
                    menueFinished = true;
                }
                else
                {
                    //Nichts
                }
            } while (!menueFinished);
        }
    }
}