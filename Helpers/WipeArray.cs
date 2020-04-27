namespace Wetterstation
{
    partial class main
    { 
        static void WipeArray(ref Record[] weatherData)
        {
            int upperBorder = FindUpperBorder(ref weatherData);
            for(int index = 0; index < upperBorder; index++)
            {
                weatherData[index].date = "  .  .    ";
                weatherData[index].airTemperature = 0.0;
                weatherData[index].airPressure = 0;
                weatherData[index].humidity = 0;
            }
        }
    }
}