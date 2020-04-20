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
        static int FindUpperBorder(ref Record[] WeatherData)
        {
            Defragment(ref WeatherData);
            int Pos = 0;
            for (Pos = 0; Pos < WeatherData.Length; Pos++)
            {
                if (WeatherData[Pos].Date == "  .  .    ")
                {
                    break;
                }
            }
            return Pos;
        }
    }
}
