namespace Wetterstation
{
    partial class main
    {
        static void FreeASpot(ref Record[] WeatherData, int Position)
        {
            for (int UpperBorder = FindUpperBorder(ref WeatherData); UpperBorder > Position; UpperBorder--)
            {
                Swap(ref WeatherData, UpperBorder, UpperBorder - 1);
            }
        }
    }
}
