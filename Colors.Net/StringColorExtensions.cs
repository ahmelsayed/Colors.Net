using System;

namespace Colors.Net.StringColorExtensions
{
    public static class StringColorExtensions
    {
        public static string Black(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Black];
            return $"{color}{value}{color}";
        }

        public static string DarkBlue(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.DarkBlue];
            return $"{color}{value}{color}";
        }

        public static string DarkGreen(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.DarkGreen];
            return $"{color}{value}{color}";
        }

        public static string DarkCyan(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.DarkCyan];
            return $"{color}{value}{color}";
        }

        public static string DarkRed(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.DarkRed];
            return $"{color}{value}{color}";
        }

        public static string DarkMagenta(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.DarkMagenta];
            return $"{color}{value}{color}";
        }

        public static string DarkYellow(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.DarkYellow];
            return $"{color}{value}{color}";
        }

        public static string Gray(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Gray];
            return $"{color}{value}{color}";
        }

        public static string DarkGray(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.DarkGray];
            return $"{color}{value}{color}";
        }

        public static string Blue(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Blue];
            return $"{color}{value}{color}";
        }

        public static string Green(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Green];
            return $"{color}{value}{color}";
        }

        public static string Cyan(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Cyan];
            return $"{color}{value}{color}";
        }

        public static string Red(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Red];
            return $"{color}{value}{color}";
        }

        public static string Magenta(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Magenta];
            return $"{color}{value}{color}";
        }

        public static string Yellow(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.Yellow];
            return $"{color}{value}{color}";
        }

        public static string White(this string value)
        {
            var color = Data.ConsoleColorToUnicode[ConsoleColor.White];
            return $"{color}{value}{color}";
        }
    }
}