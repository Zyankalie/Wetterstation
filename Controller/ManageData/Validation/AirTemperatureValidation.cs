//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        AirTemperatureValidation.cs
//Datum:        14.04.2020
//Beschreibung: Überprüft, ob es sich um einen validen Wert für die Lufttemperatur handelt.
//              Valide: -50 <= x <= 60
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static bool AirTemperatureValidation(double Temperature)
        {
            if (Temperature > 60 || Temperature < -50)
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
