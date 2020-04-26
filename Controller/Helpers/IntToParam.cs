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
        static string IntToParam(int parameter)
        {
            if (parameter == 0)
            {
                return "Datum";
            }
            else if (parameter == 1)
            {
                return "Lufttemperatur";
            }
            else if (parameter == 2)
            {
                return "Luftdruck";
            }
            else if (parameter == 3)
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
