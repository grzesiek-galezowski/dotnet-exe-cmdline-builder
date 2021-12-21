using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Tool.Search;

public record DotnetToolSearchBuilder : CommandLineBuilder<DotnetToolSearchBuilder>
{
  public DotnetToolSearchBuilder(string phrase)
  {
    CmdLine = Format.ObjectArg("tool search", phrase);
  }

  public DotnetToolSearchBuilder Detail() => WithArg("--detail");
  public DotnetToolSearchBuilder Prerelease() => WithArg("--prerelease");
  public DotnetToolSearchBuilder Skip(object number) => WithObjectArg("--skip", number);
  public DotnetToolSearchBuilder Take(object number) => WithObjectArg("--take", number);
  public override string ToString() => CmdLine;
}