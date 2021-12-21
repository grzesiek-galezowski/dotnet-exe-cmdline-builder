using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Tool.List;

public record DotnetToolListBuilder
{
  public CmdOnlyBuilder Global() => new($"{CmdLine} --global");
  public CmdOnlyBuilder Local() =>  new($"{CmdLine} --local");
  public CmdOnlyBuilder ToolPath(object toolPath) =>  new($"{CmdLine} {Format.ObjectArg("--tool-path", toolPath)}");
  private static readonly string CmdLine = "tool list";
}