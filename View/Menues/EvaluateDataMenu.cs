using System;

namespace Wetterstation
{
    partial class main
    {
        static void EvaluateDataMenu(ref Record[] WeatherDatra)
        {
            bool MenueFinished = false;
            bool ParameterSelected = true;
            int Algorithm = -1;
            string[] EvaluateValues = { "Arithmetisches Mittel", "Geometrisches Mittel", "Median", "Zurück" };
            int SelectedParameter = -1;
            string[] PossibleParameters = { "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit", "Alle Werte", "Zurück" };

            do
            {
                ParameterSelected = true;
                Algorithm = ShowSomeMenu(ref EvaluateValues, "Wählen Sie ein Auswertungsverfahren aus.");
                if (Algorithm != 3)
                {
                    do
                    {
                        SelectedParameter = ShowSomeMenu(ref PossibleParameters, "Bitte wählen Sie den Parameter aus,\r\ndessen " + IntToEval(Algorithm) + " berechnet werden soll.");
                        if (SelectedParameter == 4)
                        {
                            ParameterSelected = false;
                        }
                        else
                        {
                            ShowEvaluatedData(ref WeatherDatra, Algorithm, SelectedParameter);
                            ParameterSelected = false;
                        }
                    } while (ParameterSelected);
                }
                else
                {
                    MenueFinished = true;
                }
            } while (!MenueFinished);
        }
    }
}