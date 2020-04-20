//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ImportData.cs
//Datum:        14.04.2020
//Beschreibung: Importiert Daten aus einer Datei FilePath
//Aenderungen:  14.04.2020 Erstellung
using System;
using System.IO;
using System.Text;

namespace Wetterstation
{
    partial class main
    {
        static void ImportData(ref Record[] WeatherData, string FilePath)
        {
            WipeArray(ref WeatherData);
            FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS, Encoding.UTF8);
            string[] currentLine;
            Record InsertRecord;
            int Position = -1;
            string errorLog = "Nachfolgende Datensätze konnten nicht importiert werden:\r\n";
            int Validated = -1;

            for (int index = 0; !SR.EndOfStream; index++)
            {
                currentLine = SR.ReadLine().Split(';');
                InsertRecord = new Record { Date = currentLine[0], AirTemperature = Convert.ToDouble(currentLine[1]), AirPressure = Convert.ToUInt32(currentLine[2]), Humidity = Convert.ToUInt32(currentLine[3]) };
                Validated = ValidateEntry(ref WeatherData, ref InsertRecord);
                if (Validated == 0)
                {
                    AddRecord(ref WeatherData, ref InsertRecord, ref Position);
                }
                else
                {
                    errorLog += "Eintrag " + index + ": " + currentLine + "\r\n" + ShowErrorMessage(Validated) + "\r\n";
                }
            }
            SR.Close();
            FS.Close();
        }
    }
}
