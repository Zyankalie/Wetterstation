//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        BubbleSort.cs
//Datum:        10.04.2020
//Beschreibung: Führt einen Bubblesort auf dem Array aus.
//              Es wird ein SortParameter (0 = Datum; 1 = Lufttemperatur; 2 = Luftdruck; 3 = Luftfeuchtigkeit)
//              und ein bool übergeben(Dieser entscheidet, ob auf oder absteigend sortiert werden soll).
//Aenderungen:  10.04.2020 Erstellung
using System;
using System.Diagnostics;

namespace Wetterstation
{
    partial class main
    {
        static void BubbleSort(ref Record[] weatherData, int sortParameter, bool ascDesc, out int swapCounter, out int ifCounter, out double timeElapsed, out int arrayAccessCounter)
        {
            bool swapped = true;
            int upperBorder = FindUpperBorder(ref weatherData);

            swapCounter = 0;
            ifCounter = 0;
            arrayAccessCounter = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            if (sortParameter == 0)
            {
                ifCounter++;
                while (swapped)
                {
                    swapped = false;
                    for (int counter = 1; counter < upperBorder; counter += 1)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (CompareDates(weatherData[counter].date, weatherData[counter - 1].date))
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
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
                            if (CompareDates(weatherData[counter - 1].date, weatherData[counter].date))
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                }
            }
            else if (sortParameter == 1)
            {
                ifCounter += 2;
                while (swapped)
                {
                    swapped = false;
                    for (int counter = 1; counter < upperBorder; counter += 1)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (weatherData[counter].airTemperature < weatherData[counter - 1].airTemperature)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
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
                            if (weatherData[counter].airTemperature > weatherData[counter - 1].airTemperature)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                }
            }
            else if (sortParameter == 2)
            {
                ifCounter += 3;
                while (swapped)
                {
                    swapped = false;
                    for (int counter = 1; counter < upperBorder; counter += 1)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (weatherData[counter].airPressure < weatherData[counter - 1].airPressure)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
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
                            if (weatherData[counter].airPressure > weatherData[counter - 1].airPressure)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                }
            }
            else if (sortParameter == 3)
            {
                ifCounter += 4;
                while (swapped)
                {
                    swapped = false;
                    for (int counter = 1; counter < upperBorder; counter += 1)
                    {
                        if (ascDesc)
                        {
                            ifCounter++;
                            if (weatherData[counter].humidity < weatherData[counter - 1].humidity)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
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
                            if (weatherData[counter].humidity > weatherData[counter - 1].humidity)
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                                swapCounter++;
                                SwapRecords(ref weatherData, counter - 1, counter);
                                arrayAccessCounter += 16;
                                swapped = true;
                            }
                            else
                            {
                                arrayAccessCounter += 2;
                                ifCounter++;
                            }
                        }
                    }
                }
            }
            watch.Stop();
            timeElapsed = (double)watch.ElapsedMilliseconds;
        }
        //static void BubbleSort(ref Record[] weatherData, int sortParameter, bool ascDesc, )
        //{
        //    bool swapped = true;
        //    int upperBorder = FindUpperBorder(ref weatherData);

        //    if (sortParameter == 0)
        //    {
        //        while (swapped)
        //        {
        //            swapped = false;
        //            for (int counter = 1; counter < upperBorder; counter += 1)
        //            {
        //                if (ascDesc)
        //                {
        //                    if (CompareDates(weatherData[counter].date, weatherData[counter - 1].date))
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //                else
        //                {
        //                    if (CompareDates(weatherData[counter - 1].date, weatherData[counter].date))
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else if (sortParameter == 1)
        //    {
        //        while (swapped)
        //        {
        //            swapped = false;
        //            for (int counter = 1; counter < upperBorder; counter += 1)
        //            {
        //                if (ascDesc)
        //                {
        //                    if (weatherData[counter].airTemperature < weatherData[counter - 1].airTemperature)
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //                else
        //                {
        //                    if (weatherData[counter].airTemperature > weatherData[counter - 1].airTemperature)
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else if (sortParameter == 2)
        //    {
        //        while (swapped)
        //        {
        //            swapped = false;
        //            for (int counter = 1; counter < upperBorder; counter += 1)
        //            {
        //                if (ascDesc)
        //                {
        //                    if (weatherData[counter].airPressure < weatherData[counter - 1].airPressure)
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //                else
        //                {
        //                    if (weatherData[counter].airPressure > weatherData[counter - 1].airPressure)
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else if (sortParameter == 3)
        //    {
        //        while (swapped)
        //        {
        //            swapped = false;
        //            for (int counter = 1; counter < upperBorder; counter += 1)
        //            {
        //                if (ascDesc)
        //                {
        //                    if (weatherData[counter].humidity < weatherData[counter - 1].humidity)
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //                else
        //                {
        //                    if (weatherData[counter].humidity > weatherData[counter - 1].humidity)
        //                    {
        //                        SwapRecords(ref weatherData, counter - 1, counter);
        //                        swapped = true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
