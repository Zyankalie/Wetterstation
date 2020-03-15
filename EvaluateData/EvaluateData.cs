using System;

namespace Wetterstation
{
    partial class main
    {
        static void EvaluateData(ref Datensatz[] Wetterdaten, int Verfahren, int Parameter)
        {
            string EvaluationResult = "";

            if (Verfahren == 0)
            {
                EvaluationResult = ArithmetischesMittel(ref Wetterdaten, Parameter);
            }
            else if (Verfahren == 1)
            {
                EvaluationResult = GeometrischesMittel(ref Wetterdaten, Parameter);
            }
            else if (Verfahren == 2)
            {
                EvaluationResult = Median(ref Wetterdaten, Parameter);
            }
            else
            { 
            
            }            
            ShowEvaluatedData(ref Wetterdaten);
            
        }
    }
}
