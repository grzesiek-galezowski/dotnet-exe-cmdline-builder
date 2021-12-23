namespace DotnetExeCommandLineBuilder.Framework;

internal static class Format
{
  public static string Escaped<TContent>(TContent content)
  {
    return $"\"{content}\"";
  }

  public static string ObjectArg(string argName, object argValue)
  {
    return $"{argName} {Escaped(argValue)}";
  }

  public static string Arg(string argName, string argValue)
  {
    return $"{argName} {argValue}";
  }
}