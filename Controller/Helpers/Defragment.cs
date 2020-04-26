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
        static void Defragment(ref Record[] weatherData)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < weatherData.Length - 1; i++)
                {
                    if (weatherData[i - 1].date == "  .  .    " && weatherData[i].date != "  .  .    ")
                    {
                        swapped = true;
                        Swap(ref weatherData, i, i - 1);
                    }
                }
            }
        }
    }
}
