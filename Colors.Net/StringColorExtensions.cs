using System;

namespace Colors.Net.StringColorExtensions
{
    public static class StringColorExtensions
    {
        public static RichString Black(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Black);

        public static RichString DarkBlue(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkBlue);

        public static RichString DarkGreen(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkGreen);

        public static RichString DarkCyan(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkCyan);

        public static RichString DarkRed(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkRed);

        public static RichString DarkMagenta(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkMagenta);

        public static RichString DarkYellow(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkYellow);

        public static RichString Gray(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Gray);

        public static RichString DarkGray(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.DarkGray);

        public static RichString Blue(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Blue);

        public static RichString Green(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Green);

        public static RichString Cyan(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Cyan);

        public static RichString Red(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Red);

        public static RichString Magenta(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Magenta);

        public static RichString Yellow(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.Yellow);

        public static RichString White(this string value) => StringStaticMethods.ColorString(value, ConsoleColor.White);
    }
}