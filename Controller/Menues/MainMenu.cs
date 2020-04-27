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
        static void MainMenu(ref Record[] weatherData)
        {
            bool menuFinished = false;
            do
            {
                string headline = "Hauptmenü";
                string[] menuItems = { "Daten anzeigen", "Daten verwalten", "Daten auswerten", "Programm schließen" };
                int select = ShowSomeMenu(ref menuItems, headline);
                if (select == 0)
                {
                    ShowDataMenu(ref weatherData);
                }
                else if (select == 1)
                {
                    ManageDataMenu(ref weatherData);
                }
                else if (select == 2)
                {
                    EvaluateDataMenu(ref weatherData);
                }
                else if (select == 3)
                {
                    menuFinished = true;
                }
                else
                {
                    //Sollte nicht erreicht werden können
                }
            } while (!menuFinished);
        }
    }
}
