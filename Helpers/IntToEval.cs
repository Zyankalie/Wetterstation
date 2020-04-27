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
        static string IntToEval(int parameter)
        {
            if (parameter == 0)
            {
                return "Arithmetisches Mittel";
            }
            else if (parameter == 1)
            {
                return "Geometrisches Mittel";
            }
            else if (parameter == 2)
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
