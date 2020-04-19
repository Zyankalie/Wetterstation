namespace Wetterstation
{
    partial class main
    {
        static int FindUpperBorder(ref Record[] WeatherData)
        {
            Defragment(ref WeatherData);
            int Pos = 0;
            for (Pos = 0; Pos < WeatherData.Length; Pos++)
            {
                if (WeatherData[Pos].Date == "  .  .    ")
                {
                    break;
                }
            }
            return Pos;
        }
    }
}
