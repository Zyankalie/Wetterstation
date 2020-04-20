//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Defragment.cs
//Datum:        06.04.2020
//Beschreibung: Räumt das Array auf und schiebt alle leeren Einträge nach hinten,
//              sodass gefüllte Arraygröße definiert werden kann.
//Aenderungen:  06.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void Defragment(ref Record[] WeatherData)
        {
            bool Swaped = true;
            while (Swaped)
            {
                Swaped = false;
                for (int i = 1; i < WeatherData.Length - 1; i++)
                {
                    if (WeatherData[i - 1].Date == "  .  .    " && WeatherData[i].Date != "  .  .    ")
                    {
                        Swaped = true;
                        Swap(ref WeatherData, i, i - 1);
                    }
                }
            }
        }
    }
}
