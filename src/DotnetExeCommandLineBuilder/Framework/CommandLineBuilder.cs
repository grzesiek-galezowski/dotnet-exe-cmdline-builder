namespace DotnetExeCommandLineBuilder.Framework;

public record CommandLineBuilder<T> where T : CommandLineBuilder<T>
{
  public string CmdLine { get; protected init; }
  public T WithArg(string arg) => (T)(this with { CmdLine = $"{CmdLine} {arg}" });
  public T WithArg(string argName, string argValue) => (T)(this with { CmdLine = $"{CmdLine} {Format.Arg(argName, argValue)}" });
  public T WithObjectArg(string argName, object argValue) => (T)(this with { CmdLine = $"{CmdLine} {Format.ObjectArg(argName, argValue)}" });
  protected string Escaped<TContent>(TContent content) => Format.Escaped(content);
}