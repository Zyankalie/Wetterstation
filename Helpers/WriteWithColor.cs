using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void WriteWithColor(ConsoleColor color, string format, params string[] text)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(format, text);
            Console.ForegroundColor = oldColor;
        }
        static void WriteWithColor(ConsoleColor color, params string[] text)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = oldColor;
        }
    }
}
