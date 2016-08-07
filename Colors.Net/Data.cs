using System;
using System.Collections.Generic;
using System.Linq;

namespace Colors.Net
{
    public static class Data
    {
        // Some characters from the private use range of unicode.
        // https://en.wikipedia.org/wiki/Private_Use_Areas
        public static IDictionary<ConsoleColor, char> ConsoleColorToUnicode = new Dictionary<ConsoleColor, char>()
        {
            { ConsoleColor.Black, '\uE000' },
            { ConsoleColor.DarkBlue, '\uE001' },
            { ConsoleColor.DarkGreen, '\uE002' },
            { ConsoleColor.DarkCyan, '\uE003' },
            { ConsoleColor.DarkRed, '\uE004' },
            { ConsoleColor.DarkMagenta, '\uE005' },
            { ConsoleColor.DarkYellow, '\uE006' },
            { ConsoleColor.Gray, '\uE007' },
            { ConsoleColor.DarkGray, '\uE008' },
            { ConsoleColor.Blue, '\uE009' },
            { ConsoleColor.Green, '\uE00A' },
            { ConsoleColor.Cyan, '\uE00B' },
            { ConsoleColor.Red, '\uE00C' },
            { ConsoleColor.Magenta, '\uE00D' },
            { ConsoleColor.Yellow, '\uE00E' },
            { ConsoleColor.White, '\uE00F' }
        };

        public static IDictionary<char, ConsoleColor> UnicodeToConsoleColor = ConsoleColorToUnicode.ToDictionary(k => k.Value, v => v.Key);
    }
}
