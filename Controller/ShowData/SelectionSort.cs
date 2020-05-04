//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        SelectionSort.cs
//Datum:        10.04.2020
//Beschreibung: Führt einen SelectionSort auf dem Array aus.
//              Es wird ein SortParameter (0 = Datum; 1 = Lufttemperatur; 2 = Luftdruck; 3 = Luftfeuchtigkeit)
//              und ein bool übergeben(Dieser entscheidet, ob auf oder absteigend sortiert werden soll).
//Aenderungen:  10.04.2020 Erstellung
using System.Diagnostics;

namespace Wetterstation
{
    partial class main
    {
        static void SelectionSort(ref Record[] weatherData, int sortParameter, bool ascDesc, out int swapCounter, out int ifCounter, out double timeElapsed, out int arrayAccessCounter)
        {
            int pivot;
            int upperBorder = FindUpperBorder(ref weatherData);
            swapCounter = 0;
            ifCounter = 0;
            arrayAccessCounter = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            if (sortParameter == 0)
            {
                ifCounter++;
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (CompareDates(weatherData[innerLoop].date, weatherData[pivot].date))
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                        else
                        {
                            ifCounter++;
                            if (CompareDates(weatherData[pivot].date, weatherData[innerLoop].date))
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                    swapCounter++;
                    arrayAccessCounter += 16;
                }
            }
            else if (sortParameter == 1)
            {
                ifCounter++;
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (weatherData[innerLoop].airTemperature < weatherData[pivot].airTemperature)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                        else
                        {
                            ifCounter++;
                            if (weatherData[innerLoop].airTemperature > weatherData[pivot].airTemperature)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                    swapCounter++;
                    arrayAccessCounter += 16;
                }
            }
            else if (sortParameter == 2)
            {
                ifCounter++;
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (weatherData[innerLoop].airPressure < weatherData[pivot].airPressure)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                        else
                        {
                            ifCounter++;
                            if (weatherData[innerLoop].airPressure > weatherData[pivot].airPressure)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                    swapCounter++;
                    arrayAccessCounter += 16;
                }
            }
            else if (sortParameter == 3)
            {
                ifCounter++;
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop++)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop++)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (weatherData[innerLoop].humidity < weatherData[pivot].humidity)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                        else
                        {
                            ifCounter++;
                            if (weatherData[innerLoop].humidity > weatherData[pivot].humidity)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                pivot = innerLoop;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                    swapCounter++;
                    arrayAccessCounter += 16;
                }
            }
            watch.Stop();
            timeElapsed = (double)watch.ElapsedMilliseconds;
        }
    }
}