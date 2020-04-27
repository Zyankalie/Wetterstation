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
        static void SelectionSort(ref Record[] weatherData, int sortParameter, bool ascDesc)
        {
            int pivot = -1;
            DefragmentArray(ref weatherData);
            int upperBorder = FindUpperBorder(ref weatherData);

            if (sortParameter == 0)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < upperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < upperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (ascDesc)
                        {
                            if (CompareDates(weatherData[innereSchleife].date, weatherData[pivot].date))
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (CompareDates(weatherData[pivot].date, weatherData[innereSchleife].date))
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, aeussereSchleife, pivot);
                }
            }
            else if (sortParameter == 1)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < upperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < upperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[innereSchleife].airTemperature < weatherData[pivot].airTemperature)
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (weatherData[innereSchleife].airTemperature > weatherData[pivot].airTemperature)
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, aeussereSchleife, pivot);
                }
            }
            else if (sortParameter == 2)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < upperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < upperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[innereSchleife].airPressure < weatherData[pivot].airPressure)
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (weatherData[innereSchleife].airPressure > weatherData[pivot].airPressure)
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, aeussereSchleife, pivot);
                }
            }
            else if (sortParameter == 3)
            {
                for (int aeussereSchleife = 0; aeussereSchleife < upperBorder; aeussereSchleife = aeussereSchleife + 1)
                {
                    pivot = aeussereSchleife;
                    for (int innereSchleife = aeussereSchleife; innereSchleife < upperBorder; innereSchleife = innereSchleife + 1)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[innereSchleife].humidity < weatherData[pivot].humidity)
                            {
                                pivot = innereSchleife;
                            }
                        }
                        else
                        {
                            if (weatherData[innereSchleife].humidity > weatherData[pivot].humidity)
                            {
                                pivot = innereSchleife;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, aeussereSchleife, pivot);
                }
            }
            else
            {
                //Nichts
            }
        }
    }
}