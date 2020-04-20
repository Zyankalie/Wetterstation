//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        SelectionSort.cs
//Datum:        10.04.2020
//Beschreibung: Führt einen SelectionSort auf dem Array aus.
//              Es wird ein SortParameter (0 = Datum; 1 = Lufttemperatur; 2 = Luftdruck; 3 = Luftfeuchtigkeit)
//              und ein bool übergeben(Dieser entscheidet, ob auf oder absteigend sortiert werden soll).
//Aenderungen:  10.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static void SelectionSort(ref Record[] WeatherData, int SortParameter, bool AscDesc)
        {
            int pivot = -1;
            Defragment(ref WeatherData);
            int UpperBorder = FindUpperBorder(ref WeatherData);

            if (SortParameter == 0)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (AscDesc)
                        {
                            if (CompareDates(WeatherData[innereSchleife].Date, WeatherData[pivot].Date))
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (CompareDates(WeatherData[pivot].Date, WeatherData[innereSchleife].Date))
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    Swap(ref WeatherData, aeussereSchleife, pivot);
                }
            }
            else if (SortParameter == 1)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (AscDesc)
                        {
                            if (WeatherData[innereSchleife].AirTemperature < WeatherData[pivot].AirTemperature)
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (WeatherData[innereSchleife].AirTemperature > WeatherData[pivot].AirTemperature)
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    Swap(ref WeatherData, aeussereSchleife, pivot);
                }
            }
            else if (SortParameter == 2)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (AscDesc)
                        {
                            if (WeatherData[innereSchleife].AirPressure < WeatherData[pivot].AirPressure)
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (WeatherData[innereSchleife].AirPressure > WeatherData[pivot].AirPressure)
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    Swap(ref WeatherData, aeussereSchleife, pivot);
                }
            }
            else if (SortParameter == 3)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < UpperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < UpperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (AscDesc)
                        {
                            if (WeatherData[innereSchleife].Humidity < WeatherData[pivot].Humidity)
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (WeatherData[innereSchleife].Humidity > WeatherData[pivot].Humidity)
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    Swap(ref WeatherData, aeussereSchleife, pivot);
                }
            }
            else
            {
                //Nichts
            }
        }
    }
}