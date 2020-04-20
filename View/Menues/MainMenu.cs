//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        MainMenu.cs
//Datum:        06.04.2020
//Beschreibung: Programmablauf für das Hauptmenü
//Aenderungen:  06.04.2020 Erstellung

namespace Wetterstation
{
    partial class main
    {
        static void MainMenu(ref Record[] WeatherData)
        {
            bool MenuFinished = false;
            do
            {
                string Headline = "Hauptmenü";
                string[] MenuItems = { "Daten anzeigen", "Daten verwalten", "Daten auswerten", "Programm schließen" };
                int Select = ShowSomeMenu(ref MenuItems, Headline);
                if (Select == 0)
                {
                    ShowDataMenu(ref WeatherData);
                }
                else if (Select == 1)
                {
                    ManageDataMenu(ref WeatherData);
                }
                else if (Select == 2)
                {
                    EvaluateDataMenu(ref WeatherData);
                }
                else if (Select == 3)
                {
                    MenuFinished = true;
                }
                else
                {
                    //Sollte nicht erreicht werden können
                }
            } while (!MenuFinished);
        }
    }
}
