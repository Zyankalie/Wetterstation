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
        static bool CompareDates(string FirstDate, string SecondDate)
        {
            string[] FirstDateAsArray = FirstDate.Split('.');
            string[] SecondDateAsArray = SecondDate.Split('.');
            if (Convert.ToInt32(FirstDateAsArray[2]) < Convert.ToInt32(SecondDateAsArray[2]))
            {
                return true;
            }
            else if (Convert.ToInt32(FirstDateAsArray[2]) > Convert.ToInt32(SecondDateAsArray[2]))
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(FirstDateAsArray[1]) < Convert.ToInt32(SecondDateAsArray[1]))
                {
                    return true;
                }
                else if (Convert.ToInt32(FirstDateAsArray[1]) > Convert.ToInt32(SecondDateAsArray[1]))
                {
                    return false;
                }
                else
                {
                    if (Convert.ToInt32(FirstDateAsArray[0]) < Convert.ToInt32(SecondDateAsArray[0]))
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