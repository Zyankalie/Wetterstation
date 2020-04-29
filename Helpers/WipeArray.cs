namespace Wetterstation
{
    partial class main
    {
        static void WipeArray(ref Record[] weatherData)
        {
            int upperBorder = FindUpperBorder(ref weatherData);
            for (int counter = 0; counter < upperBorder; counter++)
            {
                weatherData[counter].date = "  .  .    ";
                weatherData[counter].airTemperature = 0.0;
                weatherData[counter].airPressure = 0;
                weatherData[counter].humidity = 0;
            }
        }
    }
}