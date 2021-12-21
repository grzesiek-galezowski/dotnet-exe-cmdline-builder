using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Publish;

public record DotnetPublishCommandLineBuilder : CommandLineBuilder<DotnetPublishCommandLineBuilder>
{
  public DotnetPublishCommandLineBuilder(object projectOrSolution)
  {
    CmdLine = $"build {Escaped(projectOrSolution)}";
  }

  public override string ToString() => CmdLine;
  public DotnetPublishCommandLineBuilder Architecture(string value) => WithArg("--arch", value);
  public DotnetPublishCommandLineBuilder VersionSuffix(string value) => WithArg("--version-suffix", value);
  public DotnetPublishCommandLineBuilder Source(object value) => WithObjectArg("--source", value);
  public DotnetPublishCommandLineBuilder Manifest(object value) => WithObjectArg("--manifest", value);
  public DotnetPublishCommandLineBuilder SelfContained(bool value) => WithArg("--self-contained", value.ToString().ToLower());
  public DotnetPublishCommandLineBuilder Output(object value) => WithObjectArg("--output", value);
  public DotnetPublishCommandLineBuilder Configuration(string value) => WithArg("--configuration", value);
  public DotnetPublishCommandLineBuilder Framework(string value) => WithArg("--framework", value);
  public DotnetPublishCommandLineBuilder Force() => WithArg("--force");
  public DotnetPublishCommandLineBuilder Interactive() => WithArg("--interactive");
  public DotnetPublishCommandLineBuilder NoBuild() => WithArg("--no-build");
  public DotnetPublishCommandLineBuilder NoDependencies() => WithArg("--no-dependencies");
  public DotnetPublishCommandLineBuilder NoRestore() => WithArg("--no-restore");
  public DotnetPublishCommandLineBuilder NoSelfContained() => WithArg("--no-self-contained");
  public DotnetPublishCommandLineBuilder NoLogo() => WithArg("--no-logo");
  public DotnetPublishCommandLineBuilder Os(string value) => WithObjectArg("--os", value);
  public DotnetPublishCommandLineBuilder Runtime(string value) => WithArg("--runtime", value);
  public DotnetPublishCommandLineBuilder Verbosity(string value) => WithArg("--verbosity", value);
}