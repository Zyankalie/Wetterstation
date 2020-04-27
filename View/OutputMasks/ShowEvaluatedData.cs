//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        ShowEvaluatedData.cs
//Datum:        16.04.2020
//Beschreibung: Konsolenausgabe für die Evaluierung.
//              Mapping: 
//                  EvaluationAlgorithm: 0 = ArithmeticMean; 1 = GeometricMean; 2 = Median
//                  EvaluationParameter: 0 = Lufttemperatur; 1 = Luftdruck; 2 = Luftfeuchtigkeit; 3 = Alle Werte
//Aenderungen:  16.04.2020 Erstellung
using System;

namespace Wetterstation
{
    partial class main
    {
        static void ShowEvaluatedData(ref Record[] weatherData, int evaluationAlgorithm, int evalutationParameter)
        {
            Console.Clear();
            Console.WriteLine(IntToEval(evaluationAlgorithm) + ":");
            if (evaluationAlgorithm == 0)
            {
                if (evalutationParameter != 3)
                {
                    Console.WriteLine(IntToParam(evalutationParameter + 1) + ": " + ArithmeticMean(ref weatherData, evalutationParameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + ArithmeticMean(ref weatherData, 0));
                    Console.WriteLine("Luftdruck: " + ArithmeticMean(ref weatherData, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + ArithmeticMean(ref weatherData, 2));
                }
            }
            else if (evaluationAlgorithm == 1)
            {
                if (evalutationParameter != 3)
                {
                    Console.WriteLine(IntToParam(evalutationParameter + 1) + ": " + GeometricMean(ref weatherData, evalutationParameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + GeometricMean(ref weatherData, 0));
                    Console.WriteLine("Luftdruck: " + GeometricMean(ref weatherData, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + GeometricMean(ref weatherData, 2));
                }
            }
            else if (evaluationAlgorithm == 2)
            {
                if (evalutationParameter != 3)
                {
                    Console.WriteLine(IntToParam(evalutationParameter + 1) + ": " + Median(ref weatherData, evalutationParameter));
                }
                else
                {
                    Console.WriteLine("Lufttemperatur: " + Median(ref weatherData, 0));
                    Console.WriteLine("Luftdruck: " + Median(ref weatherData, 1));
                    Console.WriteLine("Luftfeuchtigkeit: " + Median(ref weatherData, 2));
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
