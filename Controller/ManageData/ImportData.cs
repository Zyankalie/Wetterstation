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
        static void ImportData(ref Record[] weatherData, string filePath)
        {
            WipeArray(ref weatherData);
            FileStream FS = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS, Encoding.UTF8);
            string[] currentLine;
            Record InsertRecord;
            int Position = -1;
            string errorLog = "Nachfolgende Datensätze konnten nicht importiert werden:\r\n";
            int Validated = -1;

            for (int index = 0; !SR.EndOfStream; index++)
            {
                currentLine = SR.ReadLine().Split(';');
                InsertRecord = new Record { date = currentLine[0], airTemperature = Convert.ToDouble(currentLine[1]), airPressure = Convert.ToUInt32(currentLine[2]), humidity = Convert.ToUInt32(currentLine[3]) };
                Validated = ValidateEntry(ref weatherData, ref InsertRecord);
                if (Validated == 0)
                {
                    AddRecord(ref weatherData, ref InsertRecord, ref Position);
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
