using DotnetExeCommandLineBuilder.Framework;

namespace DotnetExeCommandLineBuilder.Test;

public record DotnetTestCommandLineBuilder : CommandLineBuilder<DotnetTestCommandLineBuilder>
{
  public DotnetTestCommandLineBuilder(object projectOrSolutionOrDll)
  {
    CmdLine = $"test {Escaped(projectOrSolutionOrDll)}";
  }

  public override string ToString() => CmdLine;
  public DotnetTestCommandLineBuilder TestAdapterPath(object value) => WithObjectArg("--test-adapter-path", value);
  public DotnetTestCommandLineBuilder Architecture(string value) => WithArg("--arch", value);
  public DotnetTestCommandLineBuilder Diag(string value) => WithArg("--diag", value);
  public DotnetTestCommandLineBuilder Filter(string value) => WithObjectArg("--filter", value);
  public DotnetTestCommandLineBuilder Logger(string value) => WithObjectArg("--logger", value);
  public DotnetTestCommandLineBuilder Output(object value) => WithObjectArg("--output", value);
  public DotnetTestCommandLineBuilder Settings(object value) => WithObjectArg("--settings", value);
  public DotnetTestCommandLineBuilder ResultsDirectory(object value) => WithObjectArg("--results-directory", value);
  public DotnetTestCommandLineBuilder NoLogo() => WithArg("--nologo");
  public DotnetTestCommandLineBuilder ListTests() => WithArg("--list-tests");
  public DotnetTestCommandLineBuilder BlameCrashDumpType(string value) => WithArg("--blame-crash-dump-type", value);
  public DotnetTestCommandLineBuilder BlameHangDumpType(string value) => WithArg("--blame-hang-dump-type", value);
  public DotnetTestCommandLineBuilder BlameHangTimeout(string value) => WithArg("--blame-hang-timeout", value);
  public DotnetTestCommandLineBuilder Blame() => WithArg("--blame");
  public DotnetTestCommandLineBuilder BlameCrash() => WithArg("--blame-crash");
  public DotnetTestCommandLineBuilder BlameCrashCollectAlways() => WithArg("--blame-crash-collect-always");
  public DotnetTestCommandLineBuilder BlameHang() => WithArg("--blame-hang");
  public DotnetTestCommandLineBuilder Configuration(string value) => WithArg("--configuration", value);
  public DotnetTestCommandLineBuilder Collect(string value) => WithArg("--collect", value);
  public DotnetTestCommandLineBuilder Framework(string value) => WithArg("--framework", value);
  public DotnetTestCommandLineBuilder Interactive() => WithArg("--interactive");
  public DotnetTestCommandLineBuilder NoBuild() => WithArg("--no-build");
  public DotnetTestCommandLineBuilder NoRestore() => WithArg("--no-restore");
  public DotnetTestCommandLineBuilder Os(string value) => WithObjectArg("--os", value);
  public DotnetTestCommandLineBuilder Runtime(string value) => WithArg("--runtime", value);
  public DotnetTestCommandLineBuilder Verbosity(string value) => WithArg("--verbosity", value);
  public DotnetTestCommandLineBuilder RunSettings(string value) => WithArg("--", value);
}