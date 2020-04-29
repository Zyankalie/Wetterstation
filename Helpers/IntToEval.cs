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
            switch (parameter)
            {
                case 0: return "Arithmetisches Mittel";
                case 1: return "Geometrisches Mittel";
                case 2: return "Median";
                default: return "IntToEvalError";
            }
        }
    }
}
