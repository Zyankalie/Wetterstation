//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        AlterRecord.cs
//Datum:        14.04.2020
//Beschreibung: Ersetzt einen Eintrag an Position n
//              durch einen übergebenen Eintrag
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void AlterRecord(ref Record[] weatherData, int position, ref Record alteredRecord)
        {
            weatherData[position] = alteredRecord;
        }
    }
}
