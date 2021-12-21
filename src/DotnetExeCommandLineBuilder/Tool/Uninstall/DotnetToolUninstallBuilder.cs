using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Tool.Uninstall;

public record DotnetToolUninstallBuilder
{
  public DotnetToolUninstallBuilder(string toolName)
  {
    CmdLine = Format.ObjectArg("tool uninstall", toolName);
  }

  public CmdOnlyBuilder Global() => new(CmdLine + " --global");
  public CmdOnlyBuilder Local() => new(CmdLine + " --local");
  public CmdOnlyBuilder ToolPath<T>(T path) => new($"{CmdLine} {Format.ObjectArg("--tool-path", path)}");
  private string CmdLine { get; init; }
}