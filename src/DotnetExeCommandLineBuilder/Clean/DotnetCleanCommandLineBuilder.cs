using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Clean;

public record DotnetCleanCommandLineBuilder : CommandLineBuilder<DotnetCleanCommandLineBuilder>
{
  public DotnetCleanCommandLineBuilder(object projectOrSolution)
  {
    CmdLine = Format.ObjectArg("clean", projectOrSolution);
  }

  public DotnetCleanCommandLineBuilder()
  {
    CmdLine = "clean";
  }

  public override string ToString() => CmdLine;
  public DotnetCleanCommandLineBuilder Output(object value) => WithObjectArg("--output", value);
  public DotnetCleanCommandLineBuilder Configuration(string value) => WithArg("--configuration", value);
  public DotnetCleanCommandLineBuilder Framework(string value) => WithArg("--framework", value);
  public DotnetCleanCommandLineBuilder Interactive() => WithArg("--interactive");
  public DotnetCleanCommandLineBuilder NoLogo() => WithArg("--no-logo");
  public DotnetCleanCommandLineBuilder Runtime(string value) => WithArg("--runtime", value);
  public DotnetCleanCommandLineBuilder Verbosity(string value) => WithArg("--verbosity", value);
}