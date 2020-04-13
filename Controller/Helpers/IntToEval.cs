namespace Wetterstation
{
    partial class main
    {
        static string IntToEval(int Parameter)
        {
            if (Parameter == 0)
            {
                return "Arithmetisches Mittel";
            }
            else if (Parameter == 1)
            {
                return "Geometrisches Mittel";
            }
            else if (Parameter == 2)
            {
                return "Median";
            }
            else
            {
                return "IntToEvalError";
            }
        }
    }
}
