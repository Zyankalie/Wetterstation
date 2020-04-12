using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowDataMenu(ref Datensatz[] Wetterdaten)
        {
            string[] MenuItems = { "Datensatz suchen", "Alle Datensätze anzeigen", "Datensätze sortieren", "Zurück" };
            string[] SearchAlgorithms = { "Lineare Suche", "Binäre Suche", "Zurück" };
            string[] SortAlgorithms = { "Bubblesort", "Selectionsort", "Zurück", "Abbrechen" };
            string[] PossibleParameters = { "Datum", "Temperatur", "Luftdruck", "Luftfeuchtigkeit", "Zurück", "Abbrechen" };
            string[] MenuPathSearching = { "Hauptmenü", "Datenanzeigen Menü", "Auswahl Suchalgorithmus", "Auswahl Suchparameter", "Eingabe Suchwert" };

            bool MenuFinished = false;
            bool Process = true;
            bool SelectedParameter = true;
            bool SearchProcess = true;

            int PositionOfItem = -1;
            int ErrorHandling = -1;

            string UserInput = "";

            int ProcessSelect = -1;
            int ParameterSelected = -1;
            int SelectedAlgorithm = -1;


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
                                        PositionOfItem = LineareSuche(ref Wetterdaten, ParameterSelected, UserInput);
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
                                            ShowFullData(ref Wetterdaten, PositionOfItem);
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
                                        PositionOfItem = BinaereSuche(ref Wetterdaten, ParameterSelected, UserInput);
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
                                            ShowFullData(ref Wetterdaten, PositionOfItem);
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
                    ShowFullData(ref Wetterdaten);
                }
                else if (ProcessSelect == 2)
                {
                    //Datensätze sortieren
                    bool SortProcess = true;
                    do
                    {
                        string[] SortValues = { "Datum", "Temperatur", "Luftdruck", "Luftfeuchtigkeit", "Zurück" }; ;
                        int SortValue = ShowSomeMenu(ref SortValues, "Wählen Sie einen Parameter als Sortierkriterium aus:\n");
                        if (SortValue != 4)
                        {

                            int SelectedSortAlgorithm = ShowSomeMenu(ref SortAlgorithms, "Mit welchem Algorithmus soll sortiert werden?\n");
                            if (SelectedAlgorithm == 0)
                            {
                                //BubbleSort(ref Wetterdaten, SortValue);
                                SortProcess = false;
                            }
                            else if (SelectedSortAlgorithm == 1)
                            {
                                //SelectionSort(ref Wetterdaten, SortValue);
                                SortProcess = false;
                            }
                            else if (SelectedSortAlgorithm == 2)
                            {
                                Process = true;
                            }
                            else if (SelectedSortAlgorithm == 3)
                            {
                                SortProcess = false;
                            }
                            else
                            {
                                //Nichts
                            }
                        }
                        else
                        {
                            SortProcess = false;
                        }
                    } while (SortProcess);
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
