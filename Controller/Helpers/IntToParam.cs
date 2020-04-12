namespace Wetterstation
{
    partial class main
    {
        static string IntToParam(int Parameter)
        {
            if (Parameter == 0)
            {
                return "Datum";
            }
            else if (Parameter == 1)
            {
                return "Lufttemperatur";
            }
            else if (Parameter == 2)
            {
                return "Luftdruck";
            }
            else if (Parameter == 3)
            {
                return "Luftfeuchtigkeit";
            }
            else
            {
                return "IntToParamError";
            }
        }
    }
}
