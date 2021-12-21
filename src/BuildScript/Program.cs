using AtmaFileSystem;
using AtmaFileSystem.IO;
using DotnetExeCommandLineBuilder;
using static Bullseye.Targets;
using static SimpleExec.Command;

var configuration = "Release";

// Define directories.
var root = AbsoluteFilePath.OfThisFile().ParentDirectory(2).Value;
var srcDir = root.AddDirectoryName("src");
var nugetPath = root.AddDirectoryName("nuget");
var version="0.1.0";

if (!nugetPath.Exists())
{
  nugetPath.Create();
}
srcDir.SetAsCurrentDirectory();

//////////////////////////////////////////////////////////////////////
// HELPER FUNCTIONS
//////////////////////////////////////////////////////////////////////
void Pack(AbsoluteDirectoryPath outputPath, AbsoluteDirectoryPath rootSourceDir, string projectName)
{
  Run("dotnet",
    DotnetExeCommands.Pack()
      .Configuration(configuration)
      .IncludeSymbols()
      .NoBuild()
      .WithArg("-p:SymbolPackageFormat=snupkg")
      .WithArg($"-p:VersionPrefix={version}")
      .Output(outputPath).CmdLine,
    workingDirectory: rootSourceDir.AddDirectoryName(projectName).ToString());
}

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Target("Clean", () =>
{
  nugetPath.Delete(true);
  Run($"dotnet", DotnetExeCommands.Clean().Configuration(configuration).CmdLine);
});

Target("Build", () =>
{
  Run("dotnet",
    DotnetExeCommands.Build()
      .Configuration(configuration)
      .WithArg($"-p:VersionPrefix={version}")
      .CmdLine);
});

Target("Test", DependsOn("Build"), () =>
{
  Run("dotnet",
    DotnetExeCommands.Test()
      .NoBuild()
      .Configuration(configuration)
      .WithArg($"-p:VersionPrefix={version}")
      .CmdLine);
});

Target("Pack", DependsOn("Test", (string) "Build"), () =>
{
  Pack(nugetPath, srcDir, "DotnetExeCommandLineBuilder");
});

Target("Push", DependsOn("Clean", "Pack"), () =>
{
    foreach (var nupkgPath in nugetPath.GetFiles("*.nupkg"))
    {
        Run("dotnet", $"nuget push {nupkgPath}" +
                      " --source https://api.nuget.org/v3/index.json");
    }
});

Target("default", DependsOn("Pack"));

RunTargetsAndExit(args);