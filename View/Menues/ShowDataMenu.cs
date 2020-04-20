//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ShowDataMenu.cs
//Datum:        10.04.2020
//Beschreibung: Programmablauf für das Menü "Daten anzeigen"
//Aenderungen:  10.04.2020 Erstellung
//              11.04.2020 ShowFullData
//              12.04.2020 Sortieren/Suchen
//              16.04.2020 Strukturanpassungen
using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowDataMenu(ref Record[] WeatherData)
        {
            string[] MenuItems = { "Datensatz suchen", "Alle Datensätze anzeigen", "Datensätze sortieren", "Zurück" };
            string[] SearchAlgorithms = { "Lineare Suche", "Binäre Suche", "Zurück" };
            string[] SortAlgorithms = { "Bubblesort", "Selectionsort", "Zurück", "Abbrechen" };
            string[] PossibleParameters = { "Datum", "Temperatur", "Luftdruck", "Luftfeuchtigkeit", "Zurück", "Abbrechen" };
            string[] MenuPathSearching = { "Hauptmenü", "Datenanzeigen Menü", "Auswahl Suchalgorithmus", "Auswahl Suchparameter", "Eingabe Suchwert" };
            string[] AscendingDescending = { "Aufsteigend", "Absteigend", "Zurück", "Abbrechen" };

            bool MenuFinished = false;
            bool Process = true;
            bool SelectedParameter = true;
            bool SearchProcess = true;
            bool SelectAscDesc = true;

            string UserInput = "";

            int ProcessSelect = -1;
            int ParameterSelected = -1;
            int SelectedAlgorithm = -1;
            int PositionOfItem = -1;
            int ErrorHandling = -1;
            int AscDescSelect = -1;

            do
            {
                Process = true;
                SelectedParameter = true;
                SearchProcess = true;
                ProcessSelect = ShowSomeMenu(ref MenuItems, "Datensätze anzeigen");
                if (ProcessSelect == 0)
                {
                    do
                    {
                        SelectedParameter = true;
                        SelectedAlgorithm = ShowSomeMenu(ref SearchAlgorithms, "Welcher Suchalgorithmus soll verwendet werden?");

                        if (SelectedAlgorithm == 0)
                        {
                            do
                            {
                                SearchProcess = true;
                                ParameterSelected = ShowSomeMenu(ref PossibleParameters, "Nach welchem Parameter soll gesucht werden?");
                                if (ParameterSelected == 4)
                                {
                                    SelectedParameter = false;
                                }
                                else if (ParameterSelected == 5)
                                {
                                    SelectedParameter = false;
                                    Process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Bitte den Suchwert für den Parameter " + IntToParam(ParameterSelected) + " eingeben.");
                                        UserInput = Console.ReadLine();
                                        PositionOfItem = LinearSearch(ref WeatherData, ParameterSelected, UserInput);
                                        Console.Clear();
                                        if (PositionOfItem == -1)
                                        {
                                            ErrorHandling = ShowSomeMenu(ref MenuPathSearching, ShowErrorMessage(1) + "In welchen Menüpunkt wollen Sie zurückkehren?");
                                            if (ErrorHandling == 0)
                                            {
                                                SearchProcess = false;
                                                SelectedParameter = false;
                                                Process = false;
                                                MenuFinished = true;
                                            }
                                            else if (ErrorHandling == 1)
                                            {
                                                SearchProcess = false;
                                                SelectedParameter = false;
                                                Process = false;
                                            }
                                            else if (ErrorHandling == 2)
                                            {
                                                SearchProcess = false;
                                                SelectedParameter = false;
                                            }
                                            else if (ErrorHandling == 3)
                                            {
                                                SearchProcess = false;
                                            }
                                            else if (ErrorHandling == 4)
                                            {
                                                //Nichts - Parameter Eingabe
                                            }
                                            else
                                            {
                                                //Nichts - Wird nie erreicht
                                            }
                                        }
                                        else
                                        {
                                            ShowFullData(ref WeatherData, PositionOfItem);
                                            SearchProcess = false;
                                            SelectedParameter = false;
                                            Process = false;
                                        }
                                    } while (SearchProcess);
                                }
                            } while (SelectedParameter);
                        }
                        else if (SelectedAlgorithm == 1)
                        {
                            do
                            {
                                SearchProcess = true;
                                ParameterSelected = ShowSomeMenu(ref PossibleParameters, "Nach welchem Parameter soll gesucht werden?");
                                if (ParameterSelected == 4)
                                {
                                    SelectedParameter = false;
                                }
                                else if (ParameterSelected == 5)
                                {
                                    SelectedParameter = false;
                                    Process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Bitte den Suchwert für den Parameter " + IntToParam(ParameterSelected) + " eingeben.");
                                        UserInput = Console.ReadLine();
                                        PositionOfItem = BinarySearch(ref WeatherData, ParameterSelected, UserInput);
                                        Console.Clear();
                                        if (PositionOfItem == -1)
                                        {
                                            ErrorHandling = ShowSomeMenu(ref MenuPathSearching, ShowErrorMessage(1) + "In welchen Menüpunkt wollen Sie zurückkehren?");
                                            if (ErrorHandling == 0)
                                            {
                                                SearchProcess = false;
                                                SelectedParameter = false;
                                                Process = false;
                                                MenuFinished = true;
                                            }
                                            else if (ErrorHandling == 1)
                                            {
                                                SearchProcess = false;
                                                SelectedParameter = false;
                                                Process = false;
                                            }
                                            else if (ErrorHandling == 2)
                                            {
                                                SearchProcess = false;
                                                SelectedParameter = false;
                                            }
                                            else if (ErrorHandling == 3)
                                            {
                                                SearchProcess = false;
                                            }
                                            else if (ErrorHandling == 4)
                                            {
                                                //Nichts - Parameter Eingabe
                                            }
                                            else
                                            {
                                                //Nichts - Wird nie erreicht
                                            }
                                        }
                                        else
                                        {
                                            ShowFullData(ref WeatherData, PositionOfItem);
                                            SearchProcess = false;
                                            SelectedParameter = false;
                                            Process = false;
                                        }
                                    } while (SearchProcess);
                                }
                            } while (SelectedParameter);
                        }
                        else
                        {
                            Process = false;
                        }
                    } while (Process);
                }
                else if (ProcessSelect == 1)
                {
                    //Alle Datensätze anzeigen
                    ShowFullData(ref WeatherData);
                }
                else if (ProcessSelect == 2)
                {
                    do
                    {
                        SelectedParameter = true;
                        SelectedAlgorithm = ShowSomeMenu(ref SortAlgorithms, "Welcher Sortieralgorithmus soll verwendet werden?");

                        if (SelectedAlgorithm == 0)
                        {
                            do
                            {
                                SelectAscDesc = true;
                                ParameterSelected = ShowSomeMenu(ref PossibleParameters, "Nach welchem Parameter soll sortiert werden?");
                                if (ParameterSelected == 4)
                                {
                                    SelectedParameter = false;
                                }
                                else if (ParameterSelected == 5)
                                {
                                    SelectedParameter = false;
                                    Process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        AscDescSelect = ShowSomeMenu(ref AscendingDescending, "Sollen die Daten auf- oder abwärts sortiert werden?");
                                        if (AscDescSelect == 0)
                                        {
                                            BubbleSort(ref WeatherData, ParameterSelected, true);
                                        }
                                        else if (AscDescSelect == 1)
                                        {
                                            BubbleSort(ref WeatherData, ParameterSelected, false);
                                        }
                                        else if (AscDescSelect == 2)
                                        {
                                            SelectAscDesc = false;
                                        }
                                        else if (AscDescSelect == 3)
                                        {
                                            SelectAscDesc = false;
                                            SelectedParameter = false;
                                            Process = false;
                                        }
                                        else
                                        {
                                            //Nichts
                                        }
                                        ShowFullData(ref WeatherData);
                                        SelectAscDesc = false;
                                        SelectedParameter = false;
                                        Process = false;

                                    } while (SelectAscDesc);
                                }
                            } while (SelectedParameter);
                        }
                        else if (SelectedAlgorithm == 1)
                        {
                            do
                            {
                                SelectAscDesc = true;
                                ParameterSelected = ShowSomeMenu(ref PossibleParameters, "Nach welchem Parameter soll sortiert werden?");
                                if (ParameterSelected == 4)
                                {
                                    SelectedParameter = false;
                                }
                                else if (ParameterSelected == 5)
                                {
                                    SelectedParameter = false;
                                    Process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        AscDescSelect = ShowSomeMenu(ref AscendingDescending, "Sollen die Daten auf- oder abwärts sortiert werden?");
                                        if (AscDescSelect == 0)
                                        {
                                            SelectionSort(ref WeatherData, ParameterSelected, true);
                                        }
                                        else if (AscDescSelect == 1)
                                        {
                                            SelectionSort(ref WeatherData, ParameterSelected, false);
                                        }
                                        else if (AscDescSelect == 2)
                                        {
                                            SelectAscDesc = false;
                                        }
                                        else if (AscDescSelect == 3)
                                        {
                                            SelectAscDesc = false;
                                            SelectedParameter = false;
                                            Process = false;
                                        }
                                        else
                                        {
                                            //Nichts
                                        }
                                        ShowFullData(ref WeatherData);
                                        SelectAscDesc = false;
                                        SelectedParameter = false;
                                        Process = false;

                                    } while (SelectAscDesc);
                                }
                            } while (SelectedParameter);
                        }
                        else
                        {
                            Process = false;
                        }
                    } while (Process);
                }
                else if (ProcessSelect == 3)
                {
                    MenuFinished = true;
                }
                else
                {
                    //Nichts
                }
            } while (!MenuFinished);
        }
    }
}
