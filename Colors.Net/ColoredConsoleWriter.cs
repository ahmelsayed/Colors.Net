using System;
using System.IO;

namespace Colors.Net
{
    public class ColoredConsoleWriter : IConsoleWriter
    {
        private static object _lock = new object();
        private readonly TextWriter _writer;

        public ColoredConsoleWriter(TextWriter writer)
        {
            _writer = writer;
        }

        public IConsoleWriter Write(string value)
        {
            var startIndex = 0;
            var endIndex = 0;
            var underBrush = false;
            for (var i =0; i < value.Length; i++)
            {
                ConsoleColor color;
                if (Data.UnicodeToConsoleColor.TryGetValue(value[i], out color))
                {
                    color = underBrush ? color : Console.ForegroundColor;
                    WriteColor(value.Substring(startIndex, endIndex - startIndex), color);
                    startIndex = i + 1;
                    endIndex = i + 1;
                    underBrush = !underBrush;
                }
                else
                {
                    endIndex++;
                }
            }

            WriteColor(value.Substring(startIndex, endIndex - startIndex), Console.ForegroundColor);

            return this;
        }

        private void WriteColor(string value, ConsoleColor color)
        {
            lock(_lock)
            {
                var originalColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                _writer.Write(value);
                Console.ForegroundColor = originalColor;
            }
        }

        public IConsoleWriter WriteLine()
        {
            return Write(Environment.NewLine);
        }

        public IConsoleWriter WriteLine(string value)
        {
            Write(value);
            return Write(Environment.NewLine);
        }
    }
}
