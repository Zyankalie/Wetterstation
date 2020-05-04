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
        static string ImportData(ref Record[] weatherData, string filePath)
        {
            WipeArray(ref weatherData);
            FileStream FS = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS, Encoding.UTF8);
            string[] currentLine = SR.ReadLine().Split(';');
            Record insertRecord;
            string errorLog = "Nachfolgende Datensätze konnten nicht importiert werden:\r\n";
            int validated;
            int errorCounter = 0;

            for (int index = 1; !SR.EndOfStream; index++)
            {
                currentLine = SR.ReadLine().Split(';');
                insertRecord = new Record { date = currentLine[0], airTemperature = Convert.ToDouble(currentLine[1]), airPressure = Convert.ToUInt32(currentLine[2]), humidity = Convert.ToUInt32(currentLine[3]) };
                validated = ValidateEntry(ref weatherData, ref insertRecord);
                if (validated == 0)
                {
                    AddRecord(ref weatherData, ref insertRecord, index);
                }
                else
                {
                    errorCounter++;
                    errorLog += "Eintrag " + index + ": " + currentLine + "\r\n" + GenerateErrorMessage(validated) + "\r\n";
                }
            }
            SR.Close();
            FS.Close();
            return errorCounter==0?"":errorLog;
        }
    }
}
