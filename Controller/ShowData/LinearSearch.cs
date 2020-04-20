//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        LinearSearch.cs
//Datum:        10.04.2020
//Beschreibung: Führt eine lineare Suche auf dem Array aus.
//              Es wird ein SearchParamter (0 = Datum; 1 = Lufttemperatur; 2 = Luftdruck; 3 = Luftfeuchtigkeit)
//              und ein Searchvalue übergeben.
//              Gibt die Position des ersten Elements, dass passt zurück.
//Aenderungen:  10.04.2020 Erstellung
using System;

namespace Wetterstation
{
    partial class main
    {
        static int LinearSearch(ref Record[] WeatherData, int SearchParameter, string SearchValue)
        {
            int i = 0;
            if (SearchParameter == 0)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].Date == SearchValue)
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (SearchParameter == 1)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].AirTemperature== Convert.ToDouble(SearchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (SearchParameter == 2)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].AirPressure == Convert.ToInt32(SearchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (SearchParameter == 3)
            {
                for (i = 0; i < WeatherData.Length; i++)
                {
                    if (WeatherData[i].Humidity == Convert.ToInt32(SearchValue))
                    {
                        return i;
                    }
                    else 
                    { 
                        //Nichts                    
                    }
                }
            }
            else 
            {
                return -1;
            }
            return -1;
        }
    }
}