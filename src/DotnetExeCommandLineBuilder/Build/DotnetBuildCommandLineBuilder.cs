using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Build;

public record DotnetBuildCommandLineBuilder : CommandLineBuilder<DotnetBuildCommandLineBuilder>
{
  public DotnetBuildCommandLineBuilder(object projectOrSolution)
  {
    CmdLine = Format.ObjectArg("build", projectOrSolution);
  }

  public override string ToString() => CmdLine;

  public DotnetBuildCommandLineBuilder Architecture(string value) => WithArg("--arch", value);
  public DotnetBuildCommandLineBuilder VersionSuffix(string value) => WithArg("--version-suffix", value);
  public DotnetBuildCommandLineBuilder Source(object value) => WithObjectArg("--source", value);
  public DotnetBuildCommandLineBuilder SelfContained(bool value) => WithArg("--self-contained", value.ToString().ToLower());
  public DotnetBuildCommandLineBuilder Output(object value) => WithObjectArg("--output", value);
  public DotnetBuildCommandLineBuilder Configuration(string value) => WithArg("--configuration", value);
  public DotnetBuildCommandLineBuilder Framework(string value) => WithArg("--framework", value);
  public DotnetBuildCommandLineBuilder Force() => WithArg("--force");
  public DotnetBuildCommandLineBuilder Interactive() => WithArg("--interactive");
  public DotnetBuildCommandLineBuilder NoBuild() => WithArg("--no-build");
  public DotnetBuildCommandLineBuilder NoDependencies() => WithArg("--no-dependencies");
  public DotnetBuildCommandLineBuilder NoIncremental() => WithArg("--no-incremental");
  public DotnetBuildCommandLineBuilder NoRestore() => WithArg("--no-restore");
  public DotnetBuildCommandLineBuilder NoSelfContained() => WithArg("--no-self-contained");
  public DotnetBuildCommandLineBuilder NoLogo() => WithArg("--no-logo");
  public DotnetBuildCommandLineBuilder Os(string value) => WithObjectArg("--os", value);
  public DotnetBuildCommandLineBuilder Runtime(string value) => WithArg("--runtime", value);
  public DotnetBuildCommandLineBuilder Verbosity(string value) => WithArg("--verbosity", value);
}