//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        run.cs
//Datum:        06.04.2020
//Beschreibung: run-Funktion, stellt den Programmablauf dar
//Aenderungen:  06.04.2020 Erstellung
//              14.04.2020 Methodenaufruf FillWithRandom hinzugefügt
//              19.04.2020 Aufruf Splashinfo hinzugefügt
using System;
using System.Linq;
namespace Wetterstation
{
    partial class main
    {
        static void run()
        {
            Console.CursorVisible = false;
            Splashinfo();
            Console.ReadKey(true);
            Record[] weatherData = new Record[366];
            FillWithRandom(ref weatherData, 365);
            MainMenu(ref weatherData);
            //string tmp = string.Join("\r\n", WeatherData.Select(x => $"{x.Date};{ x.AirTemperature};{ x.AirPressure};{ x.Humidity}"));
        }
        struct Record
        {
            public string date;
            public double airTemperature;
            public uint airPressure;
            public uint humidity;
        }
    }
    
}
