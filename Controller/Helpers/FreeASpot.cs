//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        FreeASpot.cs
//Datum:        14.04.2020
//Beschreibung: Nimmt eine Position n entgegen. 
//              Von dieser Position an werden alle Einträge um einen
//              Platz nach hinten verschoben
//Aenderungen:  14.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void FreeASpot(ref Record[] weatherData, int position)
        {
            for (int upperBorder = FindUpperBorder(ref weatherData); upperBorder > position; upperBorder--)
            {
                Swap(ref weatherData, upperBorder, upperBorder - 1);
            }
        }
    }
}
