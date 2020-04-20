using System;

namespace Wetterstation
{
    partial class main
    {
        static void run()
        {
            Console.CursorVisible = false;
            Splashinfo();
            Console.ReadKey(true);
            Record[] WeatherData = new Record[366];
            FillWithRandom(ref WeatherData, 365);
            MainMenu(ref WeatherData);
        }
        struct Record
        {
            public string Date;
            public double AirTemperature;
            public int AirPressure;
            public int Humidity;
        }
    }
    
}
