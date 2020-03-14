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
            int SearchValue = -1;
            int SelectedSearchAlgorithm = -1;
            do
            {
                Select = ShowSomeMenu(ref MenuItems, Headline);
                if (Select == 0)
                {
                    do
                    {
                        SearchValue = ShowSomeMenu(ref SearchValues, "Wählen Sie einen Parameter als Suchkriterium aus:\n");
                        if (SearchValue != 4)
                        {
                            SelectedSearchAlgorithm = ShowSomeMenu(ref SearchAlgorithms, "Mit welchem Algorithmus soll gesucht werden?\n");
                            if (SelectedSearchAlgorithm == 0)
                            {
                                LineareSuche(ref Wetterdaten, SearchValue);
                                SearchProcess = false;
                            }
                            else if (SelectedSearchAlgorithm == 1)
                            {
                                BinaereSuche(ref Wetterdaten, SearchValue);
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
                    ShowFullData(ref Wetterdaten);
                    //Alle Datensätze anzeigen
                }
                else if (Select == 2)
                {
                    //Datensätze sortieren
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
