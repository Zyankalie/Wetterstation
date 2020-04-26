//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        HumidityValidation.cs
//Datum:        14.04.2020
//Beschreibung: Überprüft, ob es sich um einen validen Wert für die Luftfeuchtigkeit handelt.
//              Valide: 0 <= x <= 100
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static bool HumidityValidation(uint humidity)
        {
            if (humidity > 100 || humidity < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
