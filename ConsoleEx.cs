using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OledHoleCalculator
{
    public static class ConsoleEx
    {
        public static void WriteLineColor(string text, ConsoleColor color)
        {
            var lastColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = lastColor;
        }
        public static void WriteColor(string text, ConsoleColor color)
        {
            var lastColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = lastColor;
        }
    }
}
