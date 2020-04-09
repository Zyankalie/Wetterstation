using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowDataMenu(ref Datensatz[] Wetterdaten)
        {
            bool MenuFinished = false;
            bool SearchProcess = true;
            string[] SearchValues = { "Datum", "Temperatur", "Luftdruck", "Luftfeuchtigkeit", "Zurück" };
            string[] SearchAlgorithms = { "Lineare Suche", "Binäre Suche", "Zurück", "Abbrechen" };
            string[] MenuItems = { "Datensatz suchen", "Alle Datensätze anzeigen", "Datensätze sortieren", "Zurück" };
            string Headline = "Daten anzeigen";
            int Select = -1;
            int SearchParameter = -1;
            int SelectedSearchAlgorithm = -1;
            string SearchValue = "";

            do
            {
                Select = ShowSomeMenu(ref MenuItems, Headline);
                if (Select == 0)
                {
                    SearchProcess = true;
                    do
                    {
                        SearchParameter = ShowSomeMenu(ref SearchValues, "Wählen Sie einen Parameter als Suchkriterium aus:\n");
                        if (SearchParameter != 4)
                        {
                            SelectedSearchAlgorithm = ShowSomeMenu(ref SearchAlgorithms, "Mit welchem Algorithmus soll gesucht werden?\n");
                            if (SelectedSearchAlgorithm == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Geben Sie den Suchwert ein:");
                                SearchValue = Console.ReadLine();
                                Defragment(ref Wetterdaten);
                                ShowFullData(ref Wetterdaten, LineareSuche(ref Wetterdaten, SearchParameter, SearchValue));
                                SearchProcess = false;
                            }
                            else if (SelectedSearchAlgorithm == 1)
                            {
                                BinaereSuche(ref Wetterdaten, SearchParameter);
                                SearchProcess = false;
                            }
                            else if (SelectedSearchAlgorithm == 2)
                            {
                                SearchProcess = true;
                            }
                            else if (SelectedSearchAlgorithm == 3)
                            {
                                SearchProcess = false;
                            }
                            else
                            {
                                //Nichts
                            }
                        }
                        else
                        {
                            SearchProcess = false;
                        }
                    } while (SearchProcess);

                }
                else if (Select == 1)
                {
                    //Alle Datensätze anzeigen
                    ShowFullData(ref Wetterdaten);
                }
                else if (Select == 2)
                {
                    //Datensätze sortieren
                    bool SortProcess = true;
                    do
                    {
                        string[] SortValues = { "Datum", "Temperatur", "Luftdruck", "Luftfeuchtigkeit", "Zurück" }; ;
                        int SortValue = ShowSomeMenu(ref SortValues, "Wählen Sie einen Parameter als Sortierkriterium aus:\n");
                        if (SortValue != 4)
                        {
                            string[] SortAlgorithms = { "Bubblesort", "Selectionsort", "Zurück", "Abbrechen" };
                            int SelectedSortAlgorithm = ShowSomeMenu(ref SortAlgorithms, "Mit welchem Algorithmus soll sortiert werden?\n");
                            if (SelectedSearchAlgorithm == 0)
                            {
                                BubbleSort(ref Wetterdaten, SortValue);
                                SortProcess = false;
                            }
                            else if (SelectedSortAlgorithm == 1)
                            {
                                SelectionSort(ref Wetterdaten, SortValue);
                                SortProcess = false;
                            }
                            else if (SelectedSortAlgorithm == 2)
                            {
                                SearchProcess = true;
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
                else if (Select == 3)
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
