
namespace Colors.Net
{
    public static class ColoredConsole
    {
        public static IConsoleWriter Write(object value)
        {
            Out.Write(value);
            return Out;
        }

        public static IConsoleWriter WriteLine()
        {
            Out.WriteLine();
            return Out;
        }

        public static IConsoleWriter WriteLine(object value)
        {
            Out.WriteLine(value);
            return Out;
        }

        public static IConsoleWriter Out { get; set; } = new ColoredConsoleWriter(System.Console.Out);

        public static IConsoleWriter Error { get; set; } = new ColoredConsoleWriter(System.Console.Error);
    }
}
