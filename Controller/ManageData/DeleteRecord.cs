//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        DeleteRecord.cs
//Datum:        14.04.2020
//Beschreibung: Löscht einen Eintrag an Position n.
//              Löschen bedeutet in diesem Kontext, dass alle
//              Werte auf 0 und das Datum auf "  .  .    " gesetzt werden.
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void DeleteRecord(ref Record[] WeatherData, int Position)
        {
            WeatherData[Position].Date = "  .  .    ";
            WeatherData[Position].AirTemperature = 0.0;
            WeatherData[Position].AirPressure = 0;
            WeatherData[Position].Humidity = 0;
        }
    }
}
