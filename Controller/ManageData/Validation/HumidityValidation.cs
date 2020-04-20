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
        static bool HumidityValidation(uint Humidity)
        {
            if (Humidity > 100 || Humidity < 0)
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
