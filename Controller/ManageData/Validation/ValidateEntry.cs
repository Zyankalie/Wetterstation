//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ValidateEntry.cs
//Datum:        14.04.2020
//Beschreibung: Überprüft, ob ein Record valide ist und ob noch Platz im Array vorhanden ist.
//              Gibt einen Integer für mögliche Fehler zurück, siehe ShowErrorMessage für Mapping.
//              Bei 0 ist Record valide.
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static int ValidateEntry(ref Record[] weatherData, ref Record entry)
        {
            int result = 0;
            DefragmentArray(ref weatherData);
            if (weatherData[weatherData.Length - 1].date == "  .  .    ")
            {
                if (!DateValidation(entry.date))
                {
                    result += 2;
                }
                if (!AirTemperatureValidation(entry.airTemperature))
                {
                    result += 4;
                }
                if (!AirPressureValidation(entry.airPressure))
                {
                    result += 8;
                }
                if (!HumidityValidation(entry.humidity))
                {
                    result += 16;
                }
            }
            else
            {
                return result += 32;
            }
            return result;
        }
    }
}
