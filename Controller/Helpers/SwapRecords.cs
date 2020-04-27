//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Swap.cs
//Datum:        06.04.2020
//Beschreibung: Nimmt zwei Positionen entgegen 
//              und tauscht die Einträge an diesen Positionen.
//Aenderungen:  06.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void SwapRecords(ref Record[] weatherData, int elem1, int elem2)
        {
            Record tmp = new Record { 
                date = weatherData[elem1].date, 
                airTemperature = weatherData[elem1].airTemperature,
                airPressure = weatherData[elem1].airPressure, 
                humidity = weatherData[elem1].humidity
            };

            weatherData[elem1].date = weatherData[elem2].date;
            weatherData[elem1].airTemperature = weatherData[elem2].airTemperature;
            weatherData[elem1].airPressure = weatherData[elem2].airPressure;
            weatherData[elem1].humidity = weatherData[elem2].humidity;

            weatherData[elem2].date = tmp.date;
            weatherData[elem2].airTemperature = tmp.airTemperature;
            weatherData[elem2].airPressure = tmp.airPressure;
            weatherData[elem2].humidity = tmp.humidity;

        }
    }
}
