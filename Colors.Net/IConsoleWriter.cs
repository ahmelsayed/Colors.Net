
namespace Colors.Net
{
    public interface IConsoleWriter
    {
        IConsoleWriter Write(object value);
        IConsoleWriter WriteLine();
        IConsoleWriter WriteLine(object value);
    }
}
