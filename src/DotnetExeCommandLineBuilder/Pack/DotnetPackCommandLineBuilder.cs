using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Pack;

public record DotnetPackCommandLineBuilder : CommandLineBuilder<DotnetPackCommandLineBuilder>
{
  public DotnetPackCommandLineBuilder(object projectOrSolution)
  {
    CmdLine = Format.ObjectArg("build", projectOrSolution);
  }

  public override string ToString() => CmdLine;
  public DotnetPackCommandLineBuilder VersionSuffix(string value) => WithArg("--version-suffix", value);
  public DotnetPackCommandLineBuilder IncludeSource() => WithArg("--include-source");
  public DotnetPackCommandLineBuilder IncludeSymbols() => WithArg("--include-symbols");
  public DotnetPackCommandLineBuilder Output(object value) => WithObjectArg("--output", value);
  public DotnetPackCommandLineBuilder Configuration(string value) => WithArg("--configuration", value);
  public DotnetPackCommandLineBuilder Force() => WithArg("--force");
  public DotnetPackCommandLineBuilder Interactive() => WithArg("--interactive");
  public DotnetPackCommandLineBuilder NoBuild() => WithArg("--no-build");
  public DotnetPackCommandLineBuilder NoDependencies() => WithArg("--no-dependencies");
  public DotnetPackCommandLineBuilder NoRestore() => WithArg("--no-restore");
  public DotnetPackCommandLineBuilder NoLogo() => WithArg("--no-logo");
  public DotnetPackCommandLineBuilder Serviceable() => WithArg("--serviceable");
  public DotnetPackCommandLineBuilder Runtime(string value) => WithArg("--runtime", value);
  public DotnetPackCommandLineBuilder Verbosity(string value) => WithArg("--verbosity", value);
}