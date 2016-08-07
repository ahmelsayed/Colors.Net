![Colors.Net](https://cloud.githubusercontent.com/assets/645740/17464702/5c8f2af6-5c9a-11e6-973e-18e5ab77765c.png)

Colors.Net
==========

## Installation:

```powershell
PS> Install-Package Colors.Net
```

## Basic usage:

```csharp
using Colors.Net;

ColoredConsole.WriteLine("Hello, World");
ColoredConsole.Write("Hello, World");
```
So it's pretty much the same surface as `System.Console`. However, to add color, all you have to do is either

```csharp
using Colors.Net.StringColorExtensions;

ColoredConsole.WriteLine($"{"Hello".Red()}, world!");
```

or

````csharp
using static Colors.Net.StringStaticMethods;

ColoredConsole.WriteLine($"{Red("Hello")}, World");
```

Since this is just manipulating strings, it's very easy to use which ever pattern you like. I personally like:



``` csharp
using Colors.Net.StringColorExtensions;

var @hello = "Hello".Red();

ColoredConsole.WriteLine($"{@hello}, World");

```

and the result of course is the same in all 2 cases:

![Hello, World!](https://cloud.githubusercontent.com/assets/645740/17464665/4a84d2bc-5c99-11e6-8dac-71912946fd4d.png)


### Nested colors:

You can also use nested colors and they will work as you'd expect string concat to work. For example:

```csharp
var @yellow = Yellow("I'm Yellow!");
var @red = Red("I'm Red!");
var @blue = "I'm Blue".Blue(); // just to show a different way

ColoredConsole
    .WriteLine($@"{Green($"I'm green yet {@yellow}, {@red}, {@blue} and back to green.")}");
```

and this prints:

![Nested colors](https://cloud.githubusercontent.com/assets/645740/17464666/4a85523c-5c99-11e6-94de-85926c2e44e3.png)


### Fluent-like Api:

I like chaining calls that logically make sense together. Anyway, `WriteLine()` and `Write()` return an instance of `IConsoleWriter` so you can chain `WriteLine()` and `Write()` calls. It looks something like this:

```csharp
ColoredConsole
    .WriteLine($"{DarkCyan("Title:")} Welcome to My Cli")
    .WriteLine()
    .WriteLine($"{DarkCyan("Version:")} {Magenta("1.0.0")}");
```

and that prints:

![Chaining] (https://cloud.githubusercontent.com/assets/645740/17464667/4a857e06-5c99-11e6-928b-0934d88e4390.png)

## Credits:
The interface is inspired by [colors.js](https://github.com/marak/colors.js/).

## Supported colors:
All colors in [`System.ConsoleColor`](https://msdn.microsoft.com/en-us/library/system.consolecolor(v=vs.110).aspx) enum.
