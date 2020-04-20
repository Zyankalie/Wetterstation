namespace Wetterstation
{
    partial class main
    { 
        static void WipeArray(ref Record[] WeatherData)
        {
            int UpperBorder = FindUpperBorder(ref WeatherData);
            for(int index = 0; index < UpperBorder; index++)
            {
                WeatherData[index].Date = "  .  .    ";
                WeatherData[index].AirTemperature = 0.0;
                WeatherData[index].AirPressure = 0;
                WeatherData[index].Humidity = 0;
            }
        }
    }
}