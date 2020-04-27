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
        static void BubbleSort(ref Record[] weatherData, int sortParameter, bool ascDesc)
        {
            bool swaped = true;
            DefragmentArray(ref weatherData);
            int upperBorder = FindUpperBorder(ref weatherData);

            if (sortParameter == 0)
            {
                while (swaped)
                {
                    swaped = false;
                    for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                    {
                        if (ascDesc)
                        {
                            if (CompareDates(weatherData[index1].date, weatherData[index1 - 1].date))
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                        else
                        {
                            if (CompareDates(weatherData[index1 - 1].date, weatherData[index1].date))
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                    }
                }
            }
            else if (sortParameter == 1)
            {
                while (swaped)
                {
                    swaped = false;
                    for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[index1].airTemperature < weatherData[index1 - 1].airTemperature)
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                        else
                        {
                            if (weatherData[index1].airTemperature > weatherData[index1 - 1].airTemperature)
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                    }
                }
            }
            else if (sortParameter == 2)
            {
                while (swaped)
                {
                    swaped = false;
                    for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[index1].airPressure < weatherData[index1 - 1].airPressure)
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                        else
                        {
                            if (weatherData[index1].airPressure > weatherData[index1 - 1].airPressure)
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                    }
                }
            }
            else if (sortParameter == 3)
            {
                while (swaped)
                {
                    swaped = false;
                    for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                    {
                        if (ascDesc)
                        {
                            if (weatherData[index1].humidity < weatherData[index1 - 1].humidity)
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                        else
                        {
                            if (weatherData[index1].humidity > weatherData[index1 - 1].humidity)
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swaped = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
