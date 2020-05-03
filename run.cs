//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        run.cs
//Datum:        06.04.2020
//Beschreibung: run-Funktion, stellt den Programmablauf dar
//Aenderungen:  06.04.2020 Erstellung
//              14.04.2020 Methodenaufruf FillWithRandom hinzugefügt
//              19.04.2020 Aufruf Splashinfo hinzugefügt
using System;
namespace Wetterstation
{
    partial class main
    {
        static void Run()
        {
            Console.CursorVisible = false;

            Splashinfo();
            Console.ReadKey(true);

            Record[] WeatherData = new Record[366];
            FillWithRandom(ref WeatherData, 360);

            MainMenu(ref WeatherData);
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
