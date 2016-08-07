
namespace Colors.Net
{
    public interface IConsoleWriter
    {
        IConsoleWriter Write(string value);
        IConsoleWriter WriteLine();
        IConsoleWriter WriteLine(string value);
    }
}
