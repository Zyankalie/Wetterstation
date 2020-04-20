//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        AddRecord.cs
//Datum:        14.04.2020
//Beschreibung: Fügt einen Eintrag an einer Position n ein.
//              Hat Position den Wert -1, wird Eintrag an erstmöglicher
//              Stelle eingefügt.
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void AddRecord(ref Record[] WeatherData, ref Record NewEntry, ref int Position)
        {
            if (Position == -1)
            {
                WeatherData[FindUpperBorder(ref WeatherData)] = NewEntry;
            }
            else
            {
                FreeASpot(ref WeatherData, Position - 1);
                WeatherData[Position - 1] = NewEntry;
            }
        }
    }
}
