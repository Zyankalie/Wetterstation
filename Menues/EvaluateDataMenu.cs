using System;

namespace Wetterstation
{
    partial class main
    {
        static void EvaluateDataMenu(ref Datensatz[] Wetterdaten)
        {
            bool MenueFinished = false;
            int Select = -1;
            string[] EvaluateValues = {"Arithmetisches Mittel", "Geometrisches Mittel", "Median", "Zurück" };
            int SelectParameter = -1;
            string[] PossibleParameters = { "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit", "Alle Werte", "Zurück", "Abbrechen" };
            
            do
            {
                Select = ShowSomeMenu(ref EvaluateValues, "Wählen Sie ein Auswertungsverfahren aus.");
                if (Select == 0 || Select == 1 || Select == 2)
                {
                    SelectParameter = ShowSomeMenu(ref PossibleParameters, "Welchen Wert wollen Sie auswerten?");
                    if (SelectParameter == 0) 
                    {
                        EvaluateData(ref Wetterdaten, Select, 0);
                    }
                    else if (SelectParameter == 1)
                    {
                        EvaluateData(ref Wetterdaten, Select, 1);
                    }
                    else if (SelectParameter == 2)
                    {
                        EvaluateData(ref Wetterdaten, Select, 2);
                    }
                    else if (SelectParameter == 3)
                    {
                        EvaluateData(ref Wetterdaten, Select, 3);
                    }
                    else if (SelectParameter == 4)
                    { 
                        //Nichts
                    }
                    else if (SelectParameter == 5) 
                    {
                        MenueFinished = true;
                    }

                }
                else if (Select == 3)
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