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
        static int LinearSearch(ref Record[] weatherData, int searchParameter, string searchValue)
        {
            int i = 0;
            if (searchParameter == 0)
            {
                for (i = 0; i < weatherData.Length; i++)
                {
                    if (weatherData[i].date == searchValue)
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (searchParameter == 1)
            {
                for (i = 0; i < weatherData.Length; i++)
                {
                    if (weatherData[i].airTemperature== Convert.ToDouble(searchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (searchParameter == 2)
            {
                for (i = 0; i < weatherData.Length; i++)
                {
                    if (weatherData[i].airPressure == Convert.ToInt32(searchValue))
                    {
                        return i;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (searchParameter == 3)
            {
                for (i = 0; i < weatherData.Length; i++)
                {
                    if (weatherData[i].humidity == Convert.ToInt32(searchValue))
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