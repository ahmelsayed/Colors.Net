
namespace Colors.Net
{
    public static class ColoredConsole
    {
        public static IConsoleWriter Write(string value)
        {
            Out.Write(value);
            return Out;
        }

        public static IConsoleWriter WriteLine()
        {
            Out.WriteLine();
            return Out;
        }

        public static IConsoleWriter WriteLine(string value)
        {
            Out.WriteLine(value);
            return Out;
        }

        public static IConsoleWriter Out { get; set; } = new ColoredConsoleWriter(System.Console.Out);

        public static IConsoleWriter Error { get; set; } = new ColoredConsoleWriter(System.Console.Error);
    }
}
