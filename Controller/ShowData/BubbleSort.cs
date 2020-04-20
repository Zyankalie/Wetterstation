//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        BubbleSort.cs
//Datum:        10.04.2020
//Beschreibung: Führt einen Bubblesort auf dem Array aus.
//              Es wird ein SortParameter (0 = Datum; 1 = Lufttemperatur; 2 = Luftdruck; 3 = Luftfeuchtigkeit)
//              und ein bool übergeben(Dieser entscheidet, ob auf oder absteigend sortiert werden soll).
//Aenderungen:  10.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void BubbleSort(ref Record[] WeatherData, int SortParameter, bool AscDesc)
        {
            bool Swaped = true;
            Defragment(ref WeatherData);
            int UpperBorder = FindUpperBorder(ref WeatherData);

            if (SortParameter == 0)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (CompareDates(WeatherData[index1].Date, WeatherData[index1 - 1].Date))
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (CompareDates(WeatherData[index1 - 1].Date, WeatherData[index1].Date))
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
            else if (SortParameter == 1)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (WeatherData[index1].AirTemperature < WeatherData[index1 - 1].AirTemperature)
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (WeatherData[index1].AirTemperature > WeatherData[index1 - 1].AirTemperature)
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
            else if (SortParameter == 2)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (WeatherData[index1].AirPressure < WeatherData[index1 - 1].AirPressure)
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (WeatherData[index1].AirPressure > WeatherData[index1 - 1].AirPressure)
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
            else if (SortParameter == 3)
            {
                while (Swaped)
                {
                    Swaped = false;
                    for (int index1 = 1; index1 < UpperBorder; index1 = index1 + 1)
                    {
                        if (AscDesc)
                        {
                            if (WeatherData[index1].Humidity < WeatherData[index1 - 1].Humidity)
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                        else
                        {
                            if (WeatherData[index1].Humidity > WeatherData[index1 - 1].Humidity)
                            {
                                Swap(ref WeatherData, index1 - 1, index1);
                                Swaped = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
