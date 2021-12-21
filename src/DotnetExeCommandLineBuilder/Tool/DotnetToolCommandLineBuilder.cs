using DotnetExeCommandLineBuilder.Framework;
using DotnetExeCommandLineBuilder.Tool.InstallOrUpdate;
using DotnetExeCommandLineBuilder.Tool.List;
using DotnetExeCommandLineBuilder.Tool.Restore;
using DotnetExeCommandLineBuilder.Tool.Search;
using DotnetExeCommandLineBuilder.Tool.Uninstall;

namespace DotnetExeCommandLineBuilder.Tool;

public record DotnetToolCommandLineBuilder
{
  public DotnetToolInstallOrUpdateBuilder Install(string toolName) => new (toolName, "install");
  public DotnetToolInstallOrUpdateBuilder Update(string toolName) => new (toolName, "update");
  public DotnetToolUninstallBuilder Uninstall(string toolName) => new (toolName);
  public DotnetToolListBuilder List() => new ();
  public DotnetToolRestoreBuilder Restore() => new();
  public CmdOnlyBuilder Run(object toolName) => new(Format.ObjectArg("tool run", toolName));
  public DotnetToolSearchBuilder Search(string phrase) => new(phrase);
}