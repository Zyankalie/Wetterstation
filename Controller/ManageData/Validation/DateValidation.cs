//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        DateValidation.cs
//Datum:        14.04.2020
//Beschreibung: Überprüft, ob es sich um einen validen Wert für das Datum handelt.
//              Valide: 1900 <= x 
//Aenderungen:  14.04.2020 Erstellung
using System;
using System.Text.RegularExpressions;

namespace Wetterstation
{
    partial class main
    {
        static bool DateValidation(string date)
        {
            Regex r = new Regex(@"([0][1-9]|[1|2][0-9]|[3][0-1]).([0][1-9]|[1][0-2]).(19|20)\d\d");
            return r.Match(date).Success;
        }
    }
}
