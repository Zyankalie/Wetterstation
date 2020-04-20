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
        static int ValidateEntry(ref Record[] WeatherData, ref Record Entry)
        {
            int result = 0;
            Defragment(ref WeatherData);
            if (WeatherData[WeatherData.Length - 1].Date == "  .  .    ")
            {
                if (!DateValidation(Entry.Date))
                {
                    result += 2;
                }
                if (!AirTemperatureValidation(Entry.AirTemperature))
                {
                    result += 4;
                }

                if (!AirPressureValidation(Entry.AirPressure))
                {
                    result += 8;
                }
                if (!HumidityValidation(Entry.Humidity))
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
