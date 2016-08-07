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

        internal static string ColorString(string value, ConsoleColor color)
        {
            var colorChar = Data.ConsoleColorToUnicode[color];
            if (value[0] >= '\uE000')
            {
                value = value.Trim(value[0]);
            }
            return $"{colorChar}{value}{colorChar}";
        }

        public static string DarkBlue(string value) => ColorString(value, ConsoleColor.DarkBlue);

        public static string DarkGreen(string value) => ColorString(value, ConsoleColor.DarkGreen);

        public static string DarkCyan(string value) => ColorString(value, ConsoleColor.DarkCyan);

        public static string DarkRed(string value) => ColorString(value, ConsoleColor.DarkRed);

        public static string DarkMagenta(string value) => ColorString(value, ConsoleColor.DarkMagenta);

        public static string DarkYellow(string  value) => ColorString(value, ConsoleColor.DarkYellow);

        public static string Gray(string  value) => ColorString(value, ConsoleColor.Gray);

        public static string DarkGray(string  value) => ColorString(value, ConsoleColor.DarkGray);

        public static string Blue(string  value) => ColorString(value, ConsoleColor.Blue);

        public static string Green(string  value) => ColorString(value, ConsoleColor.Green);

        public static string Cyan(string  value) => ColorString(value, ConsoleColor.Cyan);

        public static string Red(string  value) => ColorString(value, ConsoleColor.Red);

        public static string Magenta(string  value) => ColorString(value, ConsoleColor.Magenta);

        public static string Yellow(string  value) => ColorString(value, ConsoleColor.Yellow);

        public static string White(string  value) => ColorString(value, ConsoleColor.White);
    }
}
