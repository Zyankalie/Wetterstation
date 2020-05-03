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
            int pivot;
            int upperBorder = FindUpperBorder(ref weatherData);

            if (sortParameter == 0)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            if (CompareDates(weatherData[innerLoop].date, weatherData[pivot].date))
                            {
                                pivot = innerLoop;
                            }
                        }
                        else
                        {
                            if (CompareDates(weatherData[pivot].date, weatherData[innerLoop].date))
                            {
                                pivot = innerLoop;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else if (sortParameter == 1)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[innerLoop].airTemperature < weatherData[pivot].airTemperature)
                            {
                                pivot = innerLoop;
                            }
                        }
                        else
                        {
                            if (weatherData[innerLoop].airTemperature > weatherData[pivot].airTemperature)
                            {
                                pivot = innerLoop;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else if (sortParameter == 2)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[innerLoop].airPressure < weatherData[pivot].airPressure)
                            {
                                pivot = innerLoop;
                            }
                        }
                        else
                        {
                            if (weatherData[innerLoop].airPressure > weatherData[pivot].airPressure)
                            {
                                pivot = innerLoop;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else if (sortParameter == 3)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[innerLoop].humidity < weatherData[pivot].humidity)
                            {
                                pivot = innerLoop;
                            }
                        }
                        else
                        {
                            if (weatherData[innerLoop].humidity > weatherData[pivot].humidity)
                            {
                                pivot = innerLoop;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else
            {
                //Nichts
            }
        }
    }
}