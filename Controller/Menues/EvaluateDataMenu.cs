//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        EvaluateDataMenu.cs
//Datum:        10.04.2020
//Beschreibung: Programmablauf für das Menü "Daten auswerten"
//Aenderungen:  10.04.2020 Erstellung

namespace Wetterstation
{
    partial class main
    {
        static void EvaluateDataMenu(ref Record[] weatherDatra)
        {
            bool menueFinished = false;
            bool parameterSelected;

            string[] evaluateValues = { "Arithmetisches Mittel", "Geometrisches Mittel", "Median", "Zurück" };
            string[] possibleParameters = { "Lufttemperatur", "Luftdruck", "Luftfeuchtigkeit", "Alle Werte", "Zurück" };

            int selectedParameter;
            int algorithm;

            do
            {
                algorithm = ShowSomeMenu(ref evaluateValues, "Wählen Sie ein Auswertungsverfahren aus.");
                if (algorithm != 3)
                {
                    do
                    {
                        selectedParameter = ShowSomeMenu(ref possibleParameters, "Bitte wählen Sie den Parameter aus,\r\ndessen " + IntToEval(algorithm) + " berechnet werden soll.");
                        if (selectedParameter == 4)
                        {
                            parameterSelected = false;
                        }
                        else
                        {
                            ShowEvaluatedData(ref weatherDatra, algorithm, selectedParameter);
                            parameterSelected = false;
                        }
                    } while (parameterSelected);
                }
                else
                {
                    menueFinished = true;
                }
            } while (!menueFinished);
        }
    }
}