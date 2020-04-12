namespace Wetterstation
{
    partial class main
    {
        static string ShowErrorMessage(int Error)
        {
            string ErrorMessage = "Fehler:\r\n";
            if(Error == 1)
            {
                ErrorMessage += "Datensatz konnte nicht gefunden werden!\r\n";
            }
            return ErrorMessage;
        }
    }
}
