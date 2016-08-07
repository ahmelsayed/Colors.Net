using System;

namespace Colors.Net.StringColorExtensions
{
    public static class StringColorExtensions
    {
        public static string Black(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Black);

        public static string DarkBlue(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkBlue);

        public static string DarkGreen(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkGreen);

        public static string DarkCyan(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkCyan);

        public static string DarkRed(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkRed);

        public static string DarkMagenta(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkMagenta);

        public static string DarkYellow(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkYellow);

        public static string Gray(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Gray);

        public static string DarkGray(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkGray);

        public static string Blue(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Blue);

        public static string Green(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Green);

        public static string Cyan(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Cyan);

        public static string Red(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Red);

        public static string Magenta(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Magenta);

        public static string Yellow(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Yellow);

        public static string White(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.White);
    }
}