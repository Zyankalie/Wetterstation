//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        NthRoot.cs
//Datum:        12.04.2020
//Beschreibung: Gibt die n-te Wurzel zurück
//Aenderungen:  12.04.2020 Erstellung

//TODO: entfernen, da unnötig
using System;
namespace Wetterstation
{
    partial class main
    {
        static double NthRoot(double value, int root)
        {
            return Math.Pow(value, 1.0 / root);
        }
    }
}
