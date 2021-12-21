using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Run;

public record DotnetRunCommandLineBuilder : CommandLineBuilder<DotnetRunCommandLineBuilder>
{
  public DotnetRunCommandLineBuilder() => CmdLine = "run";
  public override string ToString() => CmdLine;
  public DotnetRunCommandLineBuilder Architecture(string value) => WithArg("--arch", value);
  public DotnetRunCommandLineBuilder Configuration(string value) => WithArg("--configuration", value);
  public DotnetRunCommandLineBuilder Framework(string value) => WithArg("--framework", value);
  public DotnetRunCommandLineBuilder Force() => WithArg("--force");
  public DotnetRunCommandLineBuilder Interactive() => WithArg("--interactive");
  public DotnetRunCommandLineBuilder NoBuild() => WithArg("--no-build");
  public DotnetRunCommandLineBuilder NoDependencies() => WithArg("--no-dependencies");
  public DotnetRunCommandLineBuilder NoLaunchProfile() => WithArg("--no-launch-profile");
  public DotnetRunCommandLineBuilder NoRestore() => WithArg("--no-restore");
  public DotnetRunCommandLineBuilder LaunchProfile(string value) => WithObjectArg("--launch-profile", value);
  public DotnetRunCommandLineBuilder Os(string value) => WithObjectArg("--os", value);
  public DotnetRunCommandLineBuilder Project(string value) => WithObjectArg("--project", value);
  public DotnetRunCommandLineBuilder Runtime(string value) => WithArg("--runtime", value);
  public DotnetRunCommandLineBuilder Verbosity(string value) => WithArg("--verbosity", value);
  public DotnetRunCommandLineBuilder AppArguments(string value) => WithArg("--", value);
}