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
//    None   = 0,      // 000000  0
//
//    Melee  = 1 << 0, // 000001  1
//
//    Fire   = 1 << 1, // 000010  2
//
//    Ice    = 1 << 2, // 000100  4
//
//    Poison = 1 << 3, // 001000  8
//Aenderungen:  12.04.2020 Erstellung
namespace Wetterstation
{
    partial class main
    {
        static string GenerateErrorMessage(int error)
        {
            string errorMessage = "Fehler:\r\n";
            int currentError = 1;
            while(error > 0)
            {
                currentError = 1;
                while(currentError <= error)
                {
                    currentError = currentError * 2;
                }
                currentError /= 2;
                if (currentError == 1)
                {
                    errorMessage += "Datensatz konnte nicht gefunden werden!\r\n";
                }
                else if(currentError == 2)
                {
                    errorMessage += "Ungültiges Datum!\r\n";
                }
                else if (currentError == 4)
                {
                    errorMessage += "Ungültige Lufttemperatur!\r\n";
                }
                else if (currentError == 8)
                {
                    errorMessage += "Ungültiger Luftdruck!\r\n";
                }
                else if (currentError == 16)
                {
                    errorMessage += "Ungültige Luftfeuchtigkeit!\r\n";
                }
                else if (currentError == 32)
                {
                    errorMessage += "Datenbank voll!\r\n";
                }
                else if(currentError == 64)
                {
                    errorMessage += "Ungültige Position!\r\n";
                }
                else if(currentError == 128)
                {
                    errorMessage += "Es befindet sich kein Datensatz an dieser Position!\r\n";
                }
                error -= currentError;
            }            
            return errorMessage;
        }
    }
}
