using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowEvaluatedData(ref Record[] WeatherData, int EvaluationAlgorithm, int EvalutationParameter)
        {
            Console.Clear();
            Console.WriteLine(IntToEval(EvaluationAlgorithm) + ":");
            if (EvaluationAlgorithm == 0)
            {
                if (EvalutationParameter != 3)
                {
                    Console.WriteLine(IntToParam(EvalutationParameter + 1) + ": " + ArithmeticMean(ref WeatherData, EvalutationParameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + ArithmeticMean(ref WeatherData, 0));
                    Console.WriteLine("Luftdruck: " + ArithmeticMean(ref WeatherData, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + ArithmeticMean(ref WeatherData, 2));
                }
            }
            else if (EvaluationAlgorithm == 1)
            {
                if (EvalutationParameter != 3)
                {
                    Console.WriteLine(IntToParam(EvalutationParameter + 1) + ": " + GeometricMean(ref WeatherData, EvalutationParameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + GeometricMean(ref WeatherData, 0));
                    Console.WriteLine("Luftdruck: " + GeometricMean(ref WeatherData, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + GeometricMean(ref WeatherData, 2));
                }
            }
            else if (EvaluationAlgorithm == 2)
            {
                if (EvalutationParameter != 3)
                {
                    Console.WriteLine(IntToParam(EvalutationParameter + 1) + ": " + Median(ref WeatherData, EvalutationParameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + Median(ref WeatherData, 0));
                    Console.WriteLine("Luftdruck: " + Median(ref WeatherData, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + Median(ref WeatherData, 2));
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
