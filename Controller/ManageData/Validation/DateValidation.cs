//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        DateValidation.cs
//Datum:        14.04.2020
//Beschreibung: Überprüft, ob es sich um einen validen Wert für das Datum handelt.
//              Valide: 1900 <= x 
//Aenderungen:  14.04.2020 Erstellung
using System;

namespace Wetterstation
{
    partial class main
    {
        static bool DateValidation(string date)
        {
            string[] dateAsArray = date.Split('.');
            if (dateAsArray.Length == 3)
            {
                if (Convert.ToInt32(dateAsArray[0]) > 31 || Convert.ToInt32(dateAsArray[0]) < 0)
                {
                    return false;
                }
                else if (Convert.ToInt32(dateAsArray[1]) > 12 || Convert.ToInt32(dateAsArray[1]) < 0)
                {
                    return false;
                }
                else if (Convert.ToInt32(dateAsArray[2]) < 1900)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
