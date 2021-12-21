using static DotnetExeCommandLineBuilder.Framework.Format;

namespace DotnetExeCommandLineBuilder.Tool.InstallOrUpdate;

public record ModedInstallOrUpdateBuilder
{
  public ModedInstallOrUpdateBuilder(string cmdLine, string mode)
  {
    CmdLine = $"{cmdLine} {mode}";
  }
  
  public ModedInstallOrUpdateBuilder AddSource<T>(T source) => this with { CmdLine = CmdLine + $" --add-source {Escaped(source)}" }; 
  public ModedInstallOrUpdateBuilder ConfigFile<T>(T file) => this with { CmdLine = CmdLine + $" --configfile {Escaped(file)}" };
  public ModedInstallOrUpdateBuilder DisableParallel() => this with { CmdLine = CmdLine + $" --disable-parallel" };
  public ModedInstallOrUpdateBuilder Framework<T>(T framework) => this with { CmdLine = CmdLine + $" --framework {Escaped(framework)}"}; 
  public ModedInstallOrUpdateBuilder IgnoreFailedSources() => this with { CmdLine = CmdLine + $" --ignore-failed-sources" }; 
  public ModedInstallOrUpdateBuilder Interactive() => this with { CmdLine = CmdLine + $" --interactive" };
  public ModedInstallOrUpdateBuilder NoCache() => this with { CmdLine = CmdLine + $" --no-cache" }; 
  public ModedInstallOrUpdateBuilder ToolManifest<T>(T path) => this with { CmdLine = CmdLine + $" --tool-manifest {Escaped(path)}" }; 
  public ModedInstallOrUpdateBuilder Verbosity<T>(T level) => this with { CmdLine = CmdLine + $" -v {Escaped(level)}" };
  public ModedInstallOrUpdateBuilder Version<T>(T versionNumber) => this with { CmdLine = CmdLine + $" --version {Escaped(versionNumber)}" };
  private string CmdLine { get; init; }
  public override string ToString() => CmdLine;
}