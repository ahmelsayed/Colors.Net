using System.Diagnostics;
using Colors.Net.StringColorExtensions;
using static Colors.Net.StringStaticMethods;

using System;
using System.Drawing;
using Console = Colorful.Console;
using Colorful;

namespace Colors.Net.Runner
{
    class Program
    {
        static void Main(string[] args)
        {


            ColoredConsole
                .WriteLine(Yellow("C") + Green("o") + Blue("l") + Cyan("o") + Magenta("r") + DarkRed("s") + Red(".") + White("N") + DarkCyan("e") + DarkMagenta("t"));



            var originalColor = System.Console.ForegroundColor;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

                var @yellow = Yellow("I'm Yellow!");
                var @red = Red("I'm Red!");
                var @blue = "I'm Blue".Blue(); // just to show a different way

                ColoredConsole
                    .WriteLine($@"{Green($"I'm green yet {@yellow}, {@red}, {@blue} and back to green.")}");


            for (var i = 0; i < 1; i++)
            {
                //ColoredConsole.WriteLine($"You can {"color".Red()} words in a much more natural {"flow".Cyan()}.");
                //ColoredConsole
                //    .WriteLine($"There is also {Green("another")} way of coloring withing {Blue("string")}.")
                //    .WriteLine($"Also {DarkYellow("WriteLine()")} and {DarkYellow("Write()")} return an instance of {DarkCyan("IConsoleWriter")} so you wan chain {DarkYellow("WriteLine()")} and {DarkYellow("Write()")} calls.");

                //ColoredConsole
                //    .WriteLine()
                //    .WriteLine();

                //var @main = nameof(Main).DarkCyan();
                //var @strings = "strings".Blue();

                //ColoredConsole
                //    .WriteLine($"By now you've guessed we only deal with {@strings}, so you can do anything.")
                //    .WriteLine($"You can have functions, like {@main} be responsible of how the are renderend.");

                //ColoredConsole
                //    .WriteLine($"{Yellow($"You can also {Cyan($"have nested {Magenta("colored")} strings")} and it should work as expected")}");

                //ColoredConsole
                //    .WriteLine($"{Red("Red")}, {White("White")}, and {Blue("Blue")}");

                //ColoredConsole.WriteLine(sentence);


                //System.Console.ForegroundColor = System.ConsoleColor.Red;
                //System.Console.Write("Red");
                //System.Console.ForegroundColor = originalColor;
                //System.Console.Write(", ");
                //System.Console.ForegroundColor = System.ConsoleColor.White;
                //System.Console.Write("White");
                //System.Console.ForegroundColor = originalColor;
                //System.Console.Write(", and ");
                //System.Console.ForegroundColor = System.ConsoleColor.Blue;
                //System.Console.Write("Blue");
                //System.Console.WriteLine();

                //string dream = "{0}, {1}, and {2}";
                //Formatter[] colors = new Formatter[]
                //{
                //    new Formatter("Red", Color.Red),
                //    new Formatter("White", Color.White),
                //    new Formatter("Blue", Color.Blue)
                //};
                //Console.WriteLineFormatted(dream, Color.Gray, colors);

                //Console.Write("Red", Color.Red);
                //Console.Write(", ");
                //Console.Write("White", Color.White);
                //Console.Write(", and ");
                //Console.WriteLine("Blue", Color.Blue);
            }
            stopwatch.Stop();
            ColoredConsole.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}");
        }
    }
}
