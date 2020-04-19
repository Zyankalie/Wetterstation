namespace Wetterstation
{
    partial class main
    {
        static void Defragment(ref Record[] WeatherData)
        {
            bool Swaped = true;
            while (Swaped)
            {
                Swaped = false;
                for (int i = 1; i < WeatherData.Length - 1; i++)
                {
                    if (WeatherData[i - 1].Date == "  .  .    " && WeatherData[i].Date != "  .  .    ")
                    {
                        Swaped = true;
                        Swap(ref WeatherData, i, i - 1);
                    }
                }
            }
        }
    }
}
