using System;

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
