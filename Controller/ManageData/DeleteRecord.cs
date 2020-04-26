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
        static void DeleteRecord(ref Record[] weatherData, int position)
        {
            weatherData[position].date = "  .  .    ";
            weatherData[position].airTemperature = 0.0;
            weatherData[position].airPressure = 0;
            weatherData[position].humidity = 0;
        }
    }
}
