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
        static void ShowDataMenu(ref Record[] weatherData)
        {
            string[] menuItems = { "Datensatz suchen", "Alle Datensätze anzeigen", "Datensätze sortieren", "Zurück" };
            string[] searchAlgorithms = { "Lineare Suche", "Binäre Suche", "Zurück" };
            string[] sortAlgorithms = { "Bubblesort", "Selectionsort", "Zurück", "Abbrechen" };
            string[] possibleParameters = { "Datum", "Temperatur", "Luftdruck", "Luftfeuchtigkeit", "Zurück", "Abbrechen" };
            string[] menuPathSearching = { "Hauptmenü", "Datenanzeigen Menü", "Auswahl Suchalgorithmus", "Auswahl Suchparameter", "Eingabe Suchwert" };
            string[] ascendingDescending = { "Aufsteigend", "Absteigend", "Zurück", "Abbrechen" };

            bool menuFinished = false;
            bool process;
            bool selectedParameter;
            bool searchProcess;
            bool selectAscDesc;

            string userInput;

            int processSelect;
            int parameterSelected;
            int selectedAlgorithm;
            int positionOfItem;
            int errorHandling;
            int ascDescSelect;

            do
            {
                process = true;
                processSelect = ShowSomeMenu(ref menuItems, "Datensätze anzeigen");
                if (processSelect == 0)
                {
                    do
                    {
                        selectedParameter = true;
                        selectedAlgorithm = ShowSomeMenu(ref searchAlgorithms, "Welcher Suchalgorithmus soll verwendet werden?");

                        if (selectedAlgorithm == 0)
                        {
                            do
                            {
                                searchProcess = true;
                                parameterSelected = ShowSomeMenu(ref possibleParameters, "Nach welchem Parameter soll gesucht werden?");
                                if (parameterSelected == 4)
                                {
                                    selectedParameter = false;
                                }
                                else if (parameterSelected == 5)
                                {
                                    selectedParameter = false;
                                    process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        // TODO: auslagern von Inputmaske
                                        Console.Clear();
                                        Console.WriteLine("Bitte den Suchwert für den Parameter " + IntToParam(parameterSelected) + " eingeben.");
                                        userInput = Console.ReadLine();
                                        positionOfItem = LinearSearch(ref weatherData, parameterSelected, userInput);
                                        Console.Clear();
                                        if (positionOfItem == -1)
                                        {
                                            errorHandling = ShowSomeMenu(ref menuPathSearching, GenerateErrorMessage(1) + "In welchen Menüpunkt wollen Sie zurückkehren?");
                                            if (errorHandling == 0)
                                            {
                                                searchProcess = false;
                                                selectedParameter = false;
                                                process = false;
                                                menuFinished = true;
                                            }
                                            else if (errorHandling == 1)
                                            {
                                                searchProcess = false;
                                                selectedParameter = false;
                                                process = false;
                                            }
                                            else if (errorHandling == 2)
                                            {
                                                searchProcess = false;
                                                selectedParameter = false;
                                            }
                                            else if (errorHandling == 3)
                                            {
                                                searchProcess = false;
                                            }
                                            else if (errorHandling == 4)
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
                                            ShowFullData(ref weatherData, positionOfItem);
                                            searchProcess = false;
                                            selectedParameter = false;
                                            process = false;
                                        }
                                    } while (searchProcess);
                                }
                            } while (selectedParameter);
                        }
                        else if (selectedAlgorithm == 1)
                        {
                            do
                            {
                                searchProcess = true;
                                parameterSelected = ShowSomeMenu(ref possibleParameters, "Nach welchem Parameter soll gesucht werden?");
                                if (parameterSelected == 4)
                                {
                                    selectedParameter = false;
                                }
                                else if (parameterSelected == 5)
                                {
                                    selectedParameter = false;
                                    process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        // TODO: auslagern von Inputmaske
                                        Console.Clear();
                                        Console.WriteLine("Bitte den Suchwert für den Parameter " + IntToParam(parameterSelected) + " eingeben.");
                                        userInput = Console.ReadLine();
                                        positionOfItem = BinarySearch(ref weatherData, parameterSelected, userInput);
                                        Console.Clear();
                                        if (positionOfItem == -1)
                                        {
                                            errorHandling = ShowSomeMenu(ref menuPathSearching, GenerateErrorMessage(1) + "In welchen Menüpunkt wollen Sie zurückkehren?");
                                            if (errorHandling == 0)
                                            {
                                                searchProcess = false;
                                                selectedParameter = false;
                                                process = false;
                                                menuFinished = true;
                                            }
                                            else if (errorHandling == 1)
                                            {
                                                searchProcess = false;
                                                selectedParameter = false;
                                                process = false;
                                            }
                                            else if (errorHandling == 2)
                                            {
                                                searchProcess = false;
                                                selectedParameter = false;
                                            }
                                            else if (errorHandling == 3)
                                            {
                                                searchProcess = false;
                                            }
                                            else if (errorHandling == 4)
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
                                            ShowFullData(ref weatherData, positionOfItem);
                                            searchProcess = false;
                                            selectedParameter = false;
                                            process = false;
                                        }
                                    } while (searchProcess);
                                }
                            } while (selectedParameter);
                        }
                        else
                        {
                            process = false;
                        }
                    } while (process);
                }
                else if (processSelect == 1)
                {
                    //Alle Datensätze anzeigen
                    ShowFullData(ref weatherData);
                }
                else if (processSelect == 2)
                {
                    do
                    {
                        selectedParameter = true;
                        selectedAlgorithm = ShowSomeMenu(ref sortAlgorithms, "Welcher Sortieralgorithmus soll verwendet werden?");

                        if (selectedAlgorithm == 0)
                        {
                            do
                            {
                                parameterSelected = ShowSomeMenu(ref possibleParameters, "Nach welchem Parameter soll sortiert werden?");
                                if (parameterSelected == 4)
                                {
                                    selectedParameter = false;
                                }
                                else if (parameterSelected == 5)
                                {
                                    selectedParameter = false;
                                    process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        ascDescSelect = ShowSomeMenu(ref ascendingDescending, "Sollen die Daten auf- oder abwärts sortiert werden?");
                                        if (ascDescSelect == 2)
                                        {
                                            selectAscDesc = false;
                                        }
                                        else
                                        {
                                            if (ascDescSelect == 0 || ascDescSelect == 1)
                                            {
                                                BubbleSort(ref weatherData, parameterSelected, !Convert.ToBoolean(ascDescSelect));
                                                ShowFullData(ref weatherData);
                                            }
                                            selectAscDesc = false;
                                            selectedParameter = false;
                                            process = false;
                                        }
                                    } while (selectAscDesc);
                                }
                            } while (selectedParameter);
                        }
                        else if (selectedAlgorithm == 1)
                        {
                            do
                            {
                                parameterSelected = ShowSomeMenu(ref possibleParameters, "Nach welchem Parameter soll sortiert werden?");
                                if (parameterSelected == 4)
                                {
                                    selectedParameter = false;
                                }
                                else if (parameterSelected == 5)
                                {
                                    selectedParameter = false;
                                    process = false;
                                }
                                else
                                {
                                    do
                                    {
                                        ascDescSelect = ShowSomeMenu(ref ascendingDescending, "Sollen die Daten auf- oder abwärts sortiert werden?");
                                        if (ascDescSelect == 2)
                                        {
                                            selectAscDesc = false;
                                        }
                                        else
                                        {                                            
                                            if(ascDescSelect == 0 || ascDescSelect == 1)
                                            {
                                                SelectionSort(ref weatherData, parameterSelected, !Convert.ToBoolean(ascDescSelect));
                                                ShowFullData(ref weatherData);
                                            }
                                            selectAscDesc = false;
                                            selectedParameter = false;
                                            process = false;
                                        }
                                    } while (selectAscDesc);
                                }
                            } while (selectedParameter);
                        }
                        else
                        {
                            process = false;
                        }
                    } while (process);
                }
                else if (processSelect == 3)
                {
                    menuFinished = true;
                }
                else
                {
                    //Nichts
                }
            } while (!menuFinished);
        }
    }
}
