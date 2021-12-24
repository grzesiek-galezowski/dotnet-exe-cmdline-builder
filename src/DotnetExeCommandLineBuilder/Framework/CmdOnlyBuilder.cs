namespace DotnetExeCommandLineBuilder.Framework;

public record CmdOnlyBuilder(string CmdLine)
{
  public override string ToString()
  {
    return CmdLine;
  }
  public static implicit operator string(CmdOnlyBuilder builder) => builder.CmdLine;

}