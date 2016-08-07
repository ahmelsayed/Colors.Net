using Colors.Net.StringColorExtensions;
using static Colors.Net.StringStaticMethods;

namespace Colors.Net.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            ColoredConsole.WriteLine($"You can {"color".Red()} words in a much more natural {"flow".Cyan()}.");
            ColoredConsole
                .WriteLine($"There is also {Green("another")} way of coloring withing {Blue("string")}.")
                .WriteLine($"Also {DarkYellow("WriteLine()")} and {DarkYellow("Write()")} return an instance of {DarkCyan("IConsoleWriter")} so you wan chain {DarkYellow("WriteLine()")} and {DarkYellow("Write()")} calls.");

            ColoredConsole
                .WriteLine()
                .WriteLine();

            var @main = nameof(Main).DarkCyan();
            var @strings = "strings".Blue();

            ColoredConsole
                .WriteLine($"By now you've guessed we only deal with {@strings}, so you can do anything.")
                .WriteLine($"You can have functions, like {@main} be responsible of how the are renderend.");

            ColoredConsole
                .WriteLine($"{Yellow($"You can also {Cyan($"have nested {Magenta("colored")} strings")} and it should work as expected")}");
        }
    }
}
