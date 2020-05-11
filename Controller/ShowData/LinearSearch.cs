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
            int position;
            int upperBorder = FindUpperBorder(ref weatherData);
            if (searchParameter == 0)
            {
                for (position = 0; position < upperBorder; position++)
                {
                    if (weatherData[position].date == searchValue)
                    {
                        return position;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (searchParameter == 1)
            {
                for (position = 0; position < upperBorder; position++)
                {

                    if (weatherData[position].airTemperature.ToString() == searchValue)
                    {
                        return position;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (searchParameter == 2)
            {
                for (position = 0; position < upperBorder; position++)
                {
                    if (weatherData[position].airPressure == Convert.ToInt32(searchValue))
                    {
                        return position;
                    }
                    else
                    {
                        //Nichts                    
                    }
                }
            }
            else if (searchParameter == 3)
            {
                for (position = 0; position < upperBorder; position++)
                {
                    if (weatherData[position].humidity == Convert.ToInt32(searchValue))
                    {
                        return position;
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