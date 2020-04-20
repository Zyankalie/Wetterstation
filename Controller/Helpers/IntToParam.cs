//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        IntToParam.cs
//Datum:        12.04.2020
//Beschreibung: Übersetzt Integer in Strings für Ausgaben.
//Aenderungen:  12.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static string IntToParam(int Parameter)
        {
            if (Parameter == 0)
            {
                return "Datum";
            }
            else if (Parameter == 1)
            {
                return "Lufttemperatur";
            }
            else if (Parameter == 2)
            {
                return "Luftdruck";
            }
            else if (Parameter == 3)
            {
                return "Luftfeuchtigkeit";
            }
            else
            {
                return "IntToParamError";
            }
        }
    }
}
