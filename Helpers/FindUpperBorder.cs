//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        FindUpperBorder.cs
//Datum:        14.04.2020
//Beschreibung: Gibt die Position zurück, ab welcher sich der erste
//              leere Eintrag befindet.
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static int FindUpperBorder(ref Record[] weatherData)
        {
            DefragmentArray(ref weatherData);
            int position;
            for (position = 0; position < weatherData.Length; position++)
            {
                if (weatherData[position].date == "  .  .    ")
                {
                    break;
                }
            }
            return position;
        }
    }
}
