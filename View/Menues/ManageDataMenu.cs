//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ManageDataMenu.cs
//Datum:        08.04.2020
//Beschreibung: Programmablauf für das Menü "Daten verwalten"
//Aenderungen:  08.04.2020 Erstellung
//              13.04.2020 Daten hinzufügen/löschen/verändern
//              14.04.2020 Pathvalidation

//TODO: Import/Export
using System;
using System.IO;

namespace Wetterstation
{
    partial class main
    {
        static void ManageDataMenu(ref Record[] weatherData)
        {
            bool menueFinished = false;
            string[] manageSelection = { "Datensatz hinzufügen", "Datensatz verändern", "Datensatz löschen", "Datensätze importieren", "Datensätze exportieren", "Zurück" };
            string[] jaNein = { "Ja", "Nein" };
            string path = "";
            int selection = -1;
            bool processOngoing = true;
            int @continue = -1;
            int position = -1;
            int sure = -1;
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
                        if (InputMaskNewEntry(ref weatherData, ref newEntry, ref position))
                        {
                            AddRecord(ref weatherData, ref newEntry, ref position);
                            @continue = ShowSomeMenu(ref jaNein, "Datensatz wurde hinzugefügt.\r\nWollen Sie einen weiteren Datensatz hinzufügen?");
                            if (@continue == 0)
                            {

                            }
                            else if (@continue == 1)
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
                        Console.Clear();
                        Console.WriteLine("Geben Sie die Position des Datensatzes an, den Sie anpassen wollen.");
                        position = Convert.ToInt32(Console.ReadLine());
                        if (weatherData[position - 1].date == "  .  .    ")
                        {
                            @continue = ShowSomeMenu(ref jaNein, ShowErrorMessage(128) + "Wollen Sie eine andere Position eingeben?");
                            if (@continue == 0)
                            {

                            }
                            else
                            {
                                processOngoing = false;
                            }
                        }
                        else
                        {
                            newEntry = weatherData[position - 1];
                            if (InputMaskNewEntry(ref weatherData, ref newEntry, newEntry.date, newEntry.airTemperature.ToString(), newEntry.airPressure.ToString(), newEntry.humidity.ToString(), position.ToString()))
                            {
                                AlterRecord(ref weatherData, position - 1, ref newEntry);
                                @continue = ShowSomeMenu(ref jaNein, "Datensatz wurde angepasst.\r\nWollen Sie einen weiteren Datensatz anpassen?");
                                if (@continue == 0)
                                {

                                }
                                else if (@continue == 1)
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
                    } while (processOngoing);
                }
                else if (selection == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Geben Sie die Position des Datensatzes an, den Sie löschen wollen.");
                        position = Convert.ToInt32(Console.ReadLine());
                        if (weatherData[position - 1].date == "  .  .    ")
                        {
                            @continue = ShowSomeMenu(ref jaNein, ShowErrorMessage(128) + "Wollen Sie eine andere Position eingeben?");
                            if (@continue == 0)
                            {

                            }
                            else
                            {
                                processOngoing = false;
                            }
                        }
                        else
                        {
                            DeleteRecord(ref weatherData, position - 1);
                            @continue = ShowSomeMenu(ref jaNein, "Datensatz wurde löschen.\r\nWollen Sie einen weiteren Datensatz löschen?");
                            if (@continue == 0)
                            {

                            }
                            else if (@continue == 1)
                            {
                                processOngoing = false;
                            }
                            else
                            {
                                //Nichts
                            }
                        }
                    } while (processOngoing);
                }
                else if (selection == 3)
                {
                    //Import                    
                    if (InputMaskPath(true, ref path))
                    {
                        if (ShowSomeMenu(ref jaNein, "Sind Sie sicher, dass Sie diese Datei importieren wollen?\r\nAktuelle werden unwiderruflich gelöscht,\r\nsofern keine Datensicherung vorliegt.") == 0)
                        {
                            ImportData(ref weatherData, path);
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