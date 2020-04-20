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
        static void ManageDataMenu(ref Record[] WeatherData)
        {
            bool MenueFinished = false;
            string[] ManageSelection = { "Datensatz hinzufügen", "Datensatz verändern", "Datensatz löschen", "Datensätze importieren", "Datensätze exportieren", "Zurück" };
            string[] JaNein = { "Ja", "Nein" };
            string Path = "";
            int Selection = -1;
            bool ProcessOngoing = true;
            int Continue = -1;
            int Position = -1;
            int Sure = -1;
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
                        if (InputMaskNewEntry(ref WeatherData, ref newEntry, ref Position))
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
                            if (InputMaskNewEntry(ref WeatherData, ref newEntry, newEntry.Date, newEntry.AirTemperature.ToString(), newEntry.AirPressure.ToString(), newEntry.Humidity.ToString(), Position.ToString()))
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
                    if (InputMaskPath(true, ref Path))
                    {
                        if (ShowSomeMenu(ref JaNein, "Sind Sie sicher, dass Sie diese Datei importieren wollen?\r\nAktuelle werden unwiderruflich gelöscht,\r\nsofern keine Datensicherung vorliegt.") == 0)
                        {
                            ImportData(ref WeatherData, Path);
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
                else if (Selection == 4)
                {
                    if (InputMaskPath(false, ref Path))
                    {
                        ExportData(ref WeatherData, Path);
                    }
                    else
                    {
                        //Nichts
                    }
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
        }
    }
}