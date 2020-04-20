//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ShowErrorMessage.cs
//Datum:        12.04.2020
//Beschreibung: Methode, um Fehlermeldungen auszugeben.
//              Mapping für Fehlermeldungen auf Zweierpotenzen, so können
//              mit der Übergabe von einem Integer mehrere Fehlermeldungen erzeugt werden.
//              Mapping:
//              1  : Datensatz konnte nicht gefunden werden.
//              2  : Ungültiges Datum.
//              4  : Ungültige Lufttemperatur.
//              8  : Ungültiger Luftdruck.
//              16 : Ungültige Luftfeuchtigkeit.
//              32 : Datenbank voll.
//              64 : Ungültige Position.
//              128: Es befindet sich kein Datensatz an dieser Position.

//Aenderungen:  12.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static string ShowErrorMessage(int Error)
        {
            string ErrorMessage = "Fehler:\r\n";
            int currError = 1;
            while(Error > 0)
            {
                currError = 1;
                while(currError <= Error)
                {
                    currError = currError * 2;
                }
                currError /= 2;
                if (currError == 1)
                {
                    ErrorMessage += "Datensatz konnte nicht gefunden werden!\r\n";
                }
                else if(currError == 2)
                {
                    ErrorMessage += "Ungültiges Datum!\r\n";
                }
                else if (currError == 4)
                {
                    ErrorMessage += "Ungültige Lufttemperatur!\r\n";
                }
                else if (currError == 8)
                {
                    ErrorMessage += "Ungültiger Luftdruck!\r\n";
                }
                else if (currError == 16)
                {
                    ErrorMessage += "Ungültige Luftfeuchtigkeit!\r\n";
                }
                else if (currError == 32)
                {
                    ErrorMessage += "Datenbank voll!\r\n";
                }
                else if(currError == 64)
                {
                    ErrorMessage += "Ungültige Position!\r\n";
                }
                else if(currError == 128)
                {
                    ErrorMessage += "Es befindet sich kein Datensatz an dieser Position!\r\n";
                }
                Error -= currError;
            }
            
            return ErrorMessage;
        }
    }
}
