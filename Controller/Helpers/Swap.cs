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
        static void Swap(ref Record[] WeatherData, int elem1, int elem2)
        {
            Record tmp = new Record { 
                Date = WeatherData[elem1].Date, 
                AirTemperature = WeatherData[elem1].AirTemperature,
                AirPressure = WeatherData[elem1].AirPressure, 
                Humidity = WeatherData[elem1].Humidity
            };

            WeatherData[elem1].Date = WeatherData[elem2].Date;
            WeatherData[elem1].AirTemperature = WeatherData[elem2].AirTemperature;
            WeatherData[elem1].AirPressure = WeatherData[elem2].AirPressure;
            WeatherData[elem1].Humidity = WeatherData[elem2].Humidity;

            WeatherData[elem2].Date = tmp.Date;
            WeatherData[elem2].AirTemperature = tmp.AirTemperature;
            WeatherData[elem2].AirPressure = tmp.AirPressure;
            WeatherData[elem2].Humidity = tmp.Humidity;

        }
    }
}
