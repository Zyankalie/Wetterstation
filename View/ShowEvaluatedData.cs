using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowEvaluatedData(ref Datensatz[] Wetterdaten, int Verfahren, int Parameter)
        {
            Console.Clear();
            Console.WriteLine(IntToEval(Verfahren) + ":");
            if (Verfahren == 0)
            {
                if (Parameter != 3)
                {
                    Console.WriteLine(IntToParam(Parameter + 1) + ": " + ArithmetischesMittel(ref Wetterdaten, Parameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + ArithmetischesMittel(ref Wetterdaten, 0));
                    Console.WriteLine("Luftdruck: " + ArithmetischesMittel(ref Wetterdaten, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + ArithmetischesMittel(ref Wetterdaten, 2));
                }
            }
            else if (Verfahren == 1)
            {
                if (Parameter != 3)
                {
                    Console.WriteLine(IntToParam(Parameter + 1) + ": " + GeometrischesMittel(ref Wetterdaten, Parameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + GeometrischesMittel(ref Wetterdaten, 0));
                    Console.WriteLine("Luftdruck: " + GeometrischesMittel(ref Wetterdaten, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + GeometrischesMittel(ref Wetterdaten, 2));
                }
            }
            else if (Verfahren == 2)
            {
                if (Parameter != 3)
                {
                    Console.WriteLine(IntToParam(Parameter + 1) + ": " + Median(ref Wetterdaten, Parameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + Median(ref Wetterdaten, 0));
                    Console.WriteLine("Luftdruck: " + Median(ref Wetterdaten, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + Median(ref Wetterdaten, 2));
                }
            }
            else
            {
                //Nichts
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Schließen[esc]");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
