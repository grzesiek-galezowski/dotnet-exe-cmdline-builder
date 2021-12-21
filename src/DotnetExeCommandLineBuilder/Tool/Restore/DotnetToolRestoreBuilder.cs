using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Tool.Restore;

public record DotnetToolRestoreBuilder : CommandLineBuilder<DotnetToolRestoreBuilder>
{
  public DotnetToolRestoreBuilder()
  {
    CmdLine = Format.Arg("tool", "restore");
  }

  public DotnetToolRestoreBuilder AddSource(object source) => WithObjectArg("--add-source", source); 
  public DotnetToolRestoreBuilder ConfigFile(object file) => WithObjectArg("--configfile", file);
  public DotnetToolRestoreBuilder DisableParallel() => WithArg("--disable-parallel");
  public DotnetToolRestoreBuilder IgnoreFailedSources() => WithArg("--ignore-failed-sources");
  public DotnetToolRestoreBuilder Interactive() => WithArg("--interactive");
  public DotnetToolRestoreBuilder NoCache() => WithArg("--no-cache");
  public DotnetToolRestoreBuilder ToolManifest(object path) => WithObjectArg("--tool-manifest", path);
  public DotnetToolRestoreBuilder Verbosity(string level) => WithArg("--verbosity", level);
  public override string ToString() => CmdLine;
}