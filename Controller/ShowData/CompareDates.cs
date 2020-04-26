//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        CompareDates.cs
//Datum:        10.04.2020
//Beschreibung: Erhält zwei Zeitstempel als Strings.
//              Ist FirstDate aktueller als SecondDate
//              wird true zurückgegeben, sonst false.
//Aenderungen:  10.04.2020 Erstellung
using System;
namespace Wetterstation
{
    partial class main
    {
        static bool CompareDates(string firstDate, string secondDate)
        {
            string[] firstDateAsArray = firstDate.Split('.');
            string[] secondDateAsArray = secondDate.Split('.');
            if (Convert.ToInt32(firstDateAsArray[2]) < Convert.ToInt32(secondDateAsArray[2]))
            {
                return true;
            }
            else if (Convert.ToInt32(firstDateAsArray[2]) > Convert.ToInt32(secondDateAsArray[2]))
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(firstDateAsArray[1]) < Convert.ToInt32(secondDateAsArray[1]))
                {
                    return true;
                }
                else if (Convert.ToInt32(firstDateAsArray[1]) > Convert.ToInt32(secondDateAsArray[1]))
                {
                    return false;
                }
                else
                {
                    if (Convert.ToInt32(firstDateAsArray[0]) < Convert.ToInt32(secondDateAsArray[0]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}