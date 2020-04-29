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
            switch (parameter)
            {
                case 0: return "Datum";
                case 1: return "Lufttemperatur";
                case 2: return "Luftdruck";
                case 3: return "Luftfeuchtigkeit";
                default: return "IntToParamError";
            }
        }
    }
}
