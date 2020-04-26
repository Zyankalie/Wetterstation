//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        BinarySearch.cs
//Datum:        10.04.2020
//Beschreibung: Führt eine binäre Suche auf dem Array aus.
//              Es wird ein SearchParamter (0 = Datum; 1 = Lufttemperatur; 2 = Luftdruck; 3 = Luftfeuchtigkeit)
//              und ein Searchvalue übergeben.
//              Gibt die Position des ersten Elements, dass passt zurück.
//Aenderungen:  10.04.2020 Erstellung
using System;

namespace Wetterstation
{
    partial class main
    {
        static int BinarySearch(ref Record[] weatherData, int searchParameter, string searchValue)
        {
            //Damit sortiert werden kann
            Defragment(ref weatherData);
            //Damit binär gesucht werden kann
            BubbleSort(ref weatherData, searchParameter, true);
            int pivot = -1;
            int lowerLimit = 0;
            int upperLimit = FindUpperBorder(ref weatherData);
            int pos = -1;

            if (searchParameter == 0)
            {
                while (upperLimit >= lowerLimit)
                {
                    pivot = lowerLimit + ((upperLimit - lowerLimit) / 2);
                    if (weatherData[pivot].date == searchValue)
                    {
                        pos = pivot;
                        break;
                    }
                    else if (CompareDates(searchValue, weatherData[pivot].date))
                    {
                        lowerLimit = pivot + 1;
                    }
                    else //(CompareDates(SearchValue, Wetterdaten[Pivot].Datum, false))
                    {
                        upperLimit = pivot - 1;
                    }
                }                
            }
            else if (searchParameter == 1)
            {
                while (upperLimit >= lowerLimit)
                {
                    pivot = lowerLimit + ((upperLimit - lowerLimit) / 2);
                    if (weatherData[pivot].airTemperature == Convert.ToDouble(searchValue))
                    {
                        pos = pivot;
                        break;
                    }
                    else if (Convert.ToDouble(searchValue) > weatherData[pivot].airTemperature)
                    {
                        lowerLimit = pivot + 1;
                    }
                    else if (Convert.ToDouble(searchValue) < weatherData[pivot].airTemperature)
                    {
                        upperLimit = pivot - 1;
                    }
                }
            }
            else if (searchParameter == 2)
            {
                while (upperLimit >= lowerLimit)
                {
                    pivot = lowerLimit + ((upperLimit - lowerLimit) / 2);
                    if (weatherData[pivot].airPressure == Convert.ToInt32(searchValue))
                    {
                        pos = pivot;
                        break;
                    }
                    else if (Convert.ToInt32(searchValue) > weatherData[pivot].airPressure)
                    {
                        lowerLimit = pivot + 1;
                    }
                    else if (Convert.ToInt32(searchValue) < weatherData[pivot].airPressure)
                    {
                        upperLimit = pivot - 1;
                    }
                }
            }
            else if (searchParameter == 3)
            {
                while (upperLimit >= lowerLimit)
                {
                    pivot = lowerLimit + ((upperLimit - lowerLimit) / 2);
                    if (weatherData[pivot].humidity == Convert.ToInt32(searchValue))
                    {
                        pos = pivot;
                        break;
                    }
                    else if (Convert.ToInt32(searchValue) > weatherData[pivot].humidity)
                    {
                        lowerLimit = pivot + 1;
                    }
                    else if (Convert.ToInt32(searchValue) < weatherData[pivot].humidity)
                    {
                        upperLimit = pivot - 1;
                    }
                }
            }
            else
            {
                //Nichts
            }
            return pos;
        }
    }
}