//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ExportData.cs
//Datum:        14.04.2020
//Beschreibung: Exportiert Daten in eine Datei FilePath
//Aenderungen:  14.04.2020 Erstellung
using System;
using System.IO;
using System.Text;

namespace Wetterstation
{
    partial class main
    {
        static void ExportData(ref Record[] weatherData, string destinationPath)
        {            
            FileStream FS = new FileStream(destinationPath + ".csv", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS, Encoding.UTF8);
            //Kein Defragment mehr nötig, da in FindUpperBorder schon aufgerufen
            int upperBorder = FindUpperBorder(ref weatherData);

            SW.WriteLine("Datum;Lufttemperatur;Luftdruck;Luftfeuchtigkeit");
            for (int i = 0; i < upperBorder; i++)
            {
                SW.WriteLine($"{weatherData[i].date};{weatherData[i].airTemperature};{weatherData[i].airPressure};{weatherData[i].humidity}");
            }
            SW.Close();
            FS.Close();
        }
    }
}
