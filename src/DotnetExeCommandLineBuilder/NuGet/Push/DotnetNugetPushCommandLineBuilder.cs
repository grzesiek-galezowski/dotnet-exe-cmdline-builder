using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.NuGet.Push;

public record DotnetNugetPushCommandLineBuilder : CommandLineBuilder<DotnetNugetPushCommandLineBuilder>
{
  public DotnetNugetPushCommandLineBuilder(object path)
  {
    CmdLine = Format.ObjectArg("nuget push", path);
  }

  public override string ToString() => CmdLine;
  public DotnetNugetPushCommandLineBuilder DisableBuffering() => WithArg("--disable-buffering");
  public DotnetNugetPushCommandLineBuilder ForceEnglishOutput() => WithArg("--force-english-output");
  public DotnetNugetPushCommandLineBuilder Interactive()  => WithArg("--interactive");
  public DotnetNugetPushCommandLineBuilder ApiKey(object apiKey) => WithObjectArg("--api-key", apiKey);
  public DotnetNugetPushCommandLineBuilder NoSymbols() => WithArg("--no-symbols");
  public DotnetNugetPushCommandLineBuilder NoServiceEndpoint() => WithArg("--no-service-endpoint");
  public DotnetNugetPushCommandLineBuilder Source(object value) => WithObjectArg("--source", value);
  public DotnetNugetPushCommandLineBuilder SkipDuplicate() => WithArg("--skip-duplicate");
  public DotnetNugetPushCommandLineBuilder SymbolApiKey(object value) => WithObjectArg("--symbol-api-key", value);
  public DotnetNugetPushCommandLineBuilder SymbolSource(object value) => WithObjectArg("--symbol-source", value);
  public DotnetNugetPushCommandLineBuilder Timeout(int value) => WithArg("--timeout", value.ToString());
}