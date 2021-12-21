namespace DotnetExeCommandLineBuilder.Tool.InstallOrUpdate;

public record DotnetToolInstallOrUpdateBuilder
{
  public DotnetToolInstallOrUpdateBuilder(string toolName, string subcommand)
  {
    CmdLine = $"tool {subcommand} {toolName}";
  }

  private string CmdLine { get; }
  public ModedInstallOrUpdateBuilder Global() => new(CmdLine, "--global");
  public ModedInstallOrUpdateBuilder Local() =>  new(CmdLine, "--local");
  public ModedInstallOrUpdateBuilder ToolPath(object toolPath) =>  new(CmdLine, $"--tool-path \"{toolPath}\"");
}