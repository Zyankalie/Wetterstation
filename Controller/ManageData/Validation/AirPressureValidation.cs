//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        AirPressureValidation.cs
//Datum:        14.04.2020
//Beschreibung: Überprüft, ob es sich um einen validen Wert für den Luftdruck handelt.
//              Valide: 700 <= x <= 1080
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static bool AirPressureValidation(int pressure)
        {
            if (pressure > 1080 || pressure < 700)
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
