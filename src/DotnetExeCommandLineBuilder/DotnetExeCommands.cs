using DotnetExeCommandLineBuilder.Build;
using DotnetExeCommandLineBuilder.Clean;
using DotnetExeCommandLineBuilder.Pack;
using DotnetExeCommandLineBuilder.Publish;
using DotnetExeCommandLineBuilder.Run;
using DotnetExeCommandLineBuilder.Test;
using DotnetExeCommandLineBuilder.Tool;

namespace DotnetExeCommandLineBuilder;

public static class DotnetExeCommands
{
  public static DotnetBuildCommandLineBuilder Build(object projectOrSolution) => new(projectOrSolution);
  public static DotnetCleanCommandLineBuilder Clean(object projectOrSolution) => new(projectOrSolution);
  public static DotnetPackCommandLineBuilder Pack(object projectOrSolution) => new(projectOrSolution);
  public static DotnetPublishCommandLineBuilder Publish(object projectOrSolution) => new(projectOrSolution);
  public static DotnetRunCommandLineBuilder Run() => new();
  public static DotnetTestCommandLineBuilder Test(object projectOrSolutionOrDll) => new(projectOrSolutionOrDll);
  public static DotnetToolCommandLineBuilder Tool() => new();
}