using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Colors.Net.StringColorExtensions;
using static Colors.Net.StringStaticMethods;
using System;

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

            Parallel.ForEach(Enumerable.Range(0, 10000),
                new ParallelOptions { MaxDegreeOfParallelism = 50 },
                i =>
                {
                    var @yellow = Yellow("I'm Yellow!");
                    var @red = Red("I'm Red!");
                    var @blue = "I'm Blue".Blue(); // just to show a different way
                    ColoredConsole
                        .WriteLine($@"{Green($"I'm green yet {@yellow}, {@red}, {@blue} and back to green.")}");
                });

            stopwatch.Stop();
            ColoredConsole.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}");

            Console.Read();
        }
    }
}
