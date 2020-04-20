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
        static void ExportData(ref Record[] WeatherData, string DestinationPath)
        {
            string filename = "WeatherDataExport_" + DateTime.Now.Date.ToString().Substring(0, 10) + ".csv";            
            FileStream FS = new FileStream(DestinationPath + "\\" + filename, FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS, Encoding.UTF8);
            //SW.AutoFlush = true;
            Defragment(ref WeatherData);
            int UpperBorder = FindUpperBorder(ref WeatherData);
            SW.WriteLine("Datum;Lufttemperatur;Luftdruck;Luftfeuchtigkeit");
            for(int i = 0; i < UpperBorder;i++)
            {
                SW.WriteLine(WeatherData[i].Date + ";" + WeatherData[i].AirTemperature + ";" + WeatherData[i].AirPressure + ";" + WeatherData[i].Humidity);
            }
            SW.Close();
            FS.Close();
        }
    }
}
