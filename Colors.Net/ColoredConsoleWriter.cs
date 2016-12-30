using System;
using System.Collections.Generic;
using System.IO;

namespace Colors.Net
{
    public class ColoredConsoleWriter : IConsoleWriter
    {
        private static readonly object _colorLock = new object();
        private static readonly object _writeLock = new object();
        private static readonly ConsoleColor OriginalConsoleColor = Console.ForegroundColor;
        private static readonly Stack<ConsoleColor> _colorStack = new Stack<ConsoleColor>(new[] { OriginalConsoleColor });
        private readonly TextWriter _writer;

        public ColoredConsoleWriter(TextWriter writer)
        {
            _writer = writer;
        }

        public IConsoleWriter Write(object ovalue)
        {
            lock (_writeLock)
            {
                var value = ovalue?.ToString() ?? string.Empty;
                var startIndex = 0;
                var endIndex = 0;
                for (var i = 0; i < value.Length; i++)
                {
                    ConsoleColor nextColor;
                    if (Data.UnicodeToConsoleColor.TryGetValue(value[i], out nextColor))
                    {
                        var currentColor = _colorStack.Count == 0 ? OriginalConsoleColor : _colorStack.Pop();
                        WriteColor(value.Substring(startIndex, endIndex - startIndex), currentColor);
                        if (currentColor != nextColor)
                        {
                            _colorStack.Push(currentColor);
                            _colorStack.Push(nextColor);
                        }
                        startIndex = i + 1;
                        endIndex = i + 1;
                    }
                    else
                    {
                        endIndex++;
                    }
                }

                WriteColor(value.Substring(startIndex, endIndex - startIndex), OriginalConsoleColor);
                return this;
            }
        }

        private void WriteColor(string value, ConsoleColor color)
        {
            lock(_colorLock)
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

        public IConsoleWriter WriteLine(object value)
        {
            Write(value);
            return Write(Environment.NewLine);
        }
    }
}
