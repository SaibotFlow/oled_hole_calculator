using System;

namespace OledHoleCalculator
{
    internal class Program
    {
        public static string  SplashScreen = @"
   ___ _          _               _          ___      _      
  /___\ | ___  __| |   /\  /\___ | | ___    / __\__ _| | ___ 
 //  // |/ _ \/ _` |  / /_/ / _ \| |/ _ \  / /  / _` | |/ __|
/ \_//| |  __/ (_| | / __  / (_) | |  __/ / /__| (_| | | (__ 
\___/ |_|\___|\__,_| \/ /_/ \___/|_|\___| \____/\__,_|_|\___|";

        static void Main(string[] args)
        {
            Console.Title = "Oled-Hole-Calculator";
            ConsoleEx.WriteLineColor(SplashScreen,ConsoleColor.Cyan);
            Console.Write(Environment.NewLine);
            ConsoleEx.WriteLineColor("Arguments: ",ConsoleColor.Yellow);
            ConsoleEx.WriteLineColor("-p \t Specification of the display size in pixels e.g. 128x64", ConsoleColor.Yellow);
            Console.WriteLine(Environment.NewLine);

            if (args.Length == 2)
            {
                if (args[0] == "-p")
                {
                    try
                    {
                        var width = int.Parse(args[1].Split("x")[0]);
                        var height = int.Parse(args[1].Split("x")[1]);
                        Calc(width, height);
                    }
                    catch (Exception)
                    {
                        ConsoleEx.WriteLineColor("Invalid format of pixels - for example: 128x64", ConsoleColor.DarkRed);
                    }      
                }
                else
                {
                    ConsoleEx.WriteLineColor("Invalid argument parameter", ConsoleColor.DarkRed);
                }
            }
            else if (args.Length > 2)
            {
                ConsoleEx.WriteLineColor("Only one argument allowed", ConsoleColor.DarkRed);
            }
            else
            {
                Console.WriteLine("Enter your display size in pixels (128x64)");
                string input = Console.ReadLine();
                var width = int.Parse(input.Split("x")[0]);
                var height = int.Parse(input.Split("x")[1]);
                Calc(width, height);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void Calc(int width, int height)
        {
            var result = width >= height ? height : width;
            ConsoleEx.WriteLineColor("Maximum Diameter is: " + Math.Round((float)result * 0.264583333333334, 2) + "mm", ConsoleColor.Green);
            var midPoint = width / 2 + "," + height / 2;
            var leftBorder = (width / 2 - result / 2) + "," + (height / 2);
            var rightBorder = (width / 2 + result / 2) + "," + (height / 2);
            var bottomBorder = (width / 2 + "," + (height / 2 + result / 2));
            var topBorder = (width / 2 + "," + (height / 2 - result / 2));
            Console.Write(Environment.NewLine);
            ConsoleEx.WriteLineColor("Mid Point: \t(" + midPoint + ")", ConsoleColor.Green);
            ConsoleEx.WriteLineColor("Left Border: \t(" + leftBorder + ")", ConsoleColor.Green);
            ConsoleEx.WriteLineColor("Right Border: \t(" + rightBorder + ")", ConsoleColor.Green);
            ConsoleEx.WriteLineColor("Top Border: \t(" + topBorder + ")", ConsoleColor.Green);
            ConsoleEx.WriteLineColor("Bottom Border: \t(" + bottomBorder + ")", ConsoleColor.Green);
        }

    }
}