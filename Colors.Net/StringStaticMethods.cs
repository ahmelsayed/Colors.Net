using System;

namespace Colors.Net
{
    public static class StringStaticMethods
    {
        public static string Black(string  value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Black];
            return $"{color}{value}{color}";
        }

        internal static RichString ColorString(string value, ConsoleColor color)
        {
            var colorChar = Data.ConsoleColorToUnicode[color];
            if (value[0] >= '\uE000')
            {
                value = value.Trim(value[0]);
            }
            return new RichString($"{colorChar}{value}{colorChar}");
        }

        public static RichString DarkBlue(string value) => ColorString(value, ConsoleColor.DarkBlue);

        public static RichString DarkGreen(string value) => ColorString(value, ConsoleColor.DarkGreen);

        public static RichString DarkCyan(string value) => ColorString(value, ConsoleColor.DarkCyan);

        public static RichString DarkRed(string value) => ColorString(value, ConsoleColor.DarkRed);

        public static RichString DarkMagenta(string value) => ColorString(value, ConsoleColor.DarkMagenta);

        public static RichString DarkYellow(string  value) => ColorString(value, ConsoleColor.DarkYellow);

        public static RichString Gray(string  value) => ColorString(value, ConsoleColor.Gray);

        public static RichString DarkGray(string  value) => ColorString(value, ConsoleColor.DarkGray);

        public static RichString Blue(string  value) => ColorString(value, ConsoleColor.Blue);

        public static RichString Green(string  value) => ColorString(value, ConsoleColor.Green);

        public static RichString Cyan(string  value) => ColorString(value, ConsoleColor.Cyan);

        public static RichString Red(string  value) => ColorString(value, ConsoleColor.Red);

        public static RichString Magenta(string  value) => ColorString(value, ConsoleColor.Magenta);

        public static RichString Yellow(string  value) => ColorString(value, ConsoleColor.Yellow);

        public static RichString White(string value) => ColorString(value, ConsoleColor.White);
    }
}
