//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        IntToEval.cs
//Datum:        12.04.2020
//Beschreibung: Übersetzt Integer in Strings für Ausgaben.
//Aenderungen:  12.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static string IntToEval(int Parameter)
        {
            if (Parameter == 0)
            {
                return "Arithmetisches Mittel";
            }
            else if (Parameter == 1)
            {
                return "Geometrisches Mittel";
            }
            else if (Parameter == 2)
            {
                return "Median";
            }
            else
            {
                return "IntToEvalError";
            }
        }
    }
}
