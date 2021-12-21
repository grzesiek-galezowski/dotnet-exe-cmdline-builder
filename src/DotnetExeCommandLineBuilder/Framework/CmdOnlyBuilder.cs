namespace DotnetExeCommandLineBuilder.Framework;

public record CmdOnlyBuilder(string CmdLine)
{
  public override string ToString()
  {
    return CmdLine;
  }
}