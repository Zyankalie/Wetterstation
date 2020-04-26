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
        static void AddRecord(ref Record[] weatherData, ref Record newEntry, ref int position)
        {
            if (position == -1)
            {
                weatherData[FindUpperBorder(ref weatherData)] = newEntry;
            }
            else
            {
                FreeASpot(ref weatherData, position - 1);
                weatherData[position - 1] = newEntry;
            }
        }
    }
}