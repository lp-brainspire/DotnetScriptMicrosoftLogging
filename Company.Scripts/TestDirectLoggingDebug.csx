#r "nuget: Microsoft.Extensions.Logging, 3.1.2"
#r "nuget: Microsoft.Extensions.Logging.Console, 3.1.2"
#r "nuget: Microsoft.Extensions.Logging.Debug, 3.1.2"
#r "nuget: Microsoft.Extensions.Logging.Abstractions, 3.1.2"

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;

var loggerFactory = LoggerFactory.Create(builder => {
    builder.SetMinimumLevel(LogLevel.Debug);
    builder.AddDebug();
    builder.AddConsole();
});

var logger = loggerFactory.CreateLogger("Company");

logger.LogInformation("test");

/* Generates the following with the dotnet script -d option
Suppressed diagnostic CS1705: C:\Users\user\Company\Company.Scripts\TestDirectLoggingDebug.csx(12,5): error CS1705: Assembly 'Microsoft.Extensions.Logging.Debug' with identity 'Microsoft.Extensions.Logging.Debug, Version=3.1.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' uses 'Microsoft.Extensions.Logging, Version=3.1.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' which has a higher version than referenced assembly 'Microsoft.Extensions.Logging' with identity 'Microsoft.Extensions.Logging, Version=3.0.1.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
System.NullReferenceException: Object reference not set to an instance of an object.
   at Dotnet.Script.Core.ScriptPublisher.CreateScriptAssembly[TReturn,THost](ScriptContext context, String outputDirectory, String assemblyFileName) in D:\a\1\s\src\Dotnet.Script.Core\ScriptPublisher.cs:line 105
   at Dotnet.Script.Core.ScriptPublisher.CreateAssembly[TReturn,THost](ScriptContext context, LogFactory logFactory, String assemblyFileName) in D:\a\1\s\src\Dotnet.Script.Core\ScriptPublisher.cs:line 47
   at Dotnet.Script.Core.Commands.PublishCommand.Execute(PublishCommandOptions options) in D:\a\1\s\src\Dotnet.Script.Core\Commands\PublishCommand.cs:line 39
   at Dotnet.Script.Core.Commands.ExecuteScriptCommand.<GetLibrary>g__CreateLibrary|6_0(<>c__DisplayClass6_0& ) in D:\a\1\s\src\Dotnet.Script.Core\Commands\ExecuteScriptCommand.cs:line 67
   at Dotnet.Script.Core.Commands.ExecuteScriptCommand.GetLibrary(ExecuteScriptCommandOptions executeOptions) in D:\a\1\s\src\Dotnet.Script.Core\Commands\ExecuteScriptCommand.cs:line 59
   at Dotnet.Script.Core.Commands.ExecuteScriptCommand.Run[TReturn,THost](ExecuteScriptCommandOptions options) in D:\a\1\s\src\Dotnet.Script.Core\Commands\ExecuteScriptCommand.cs:line 34
   at Dotnet.Script.Program.<>c__DisplayClass4_0.<<Wain>b__9>d.MoveNext() in C:\Users\VssAdministrator\AppData\Local\Temp\tmp1D34\Dotnet.Script\Program.cs:line 242
--- End of stack trace from previous location where exception was thrown ---
   at McMaster.Extensions.CommandLineUtils.CommandLineApplication.<>c__DisplayClass126_0.<OnExecute>b__0() in C:\projects\commandlineutils\src\CommandLineUtils\CommandLineApplication.cs:line 505
   at McMaster.Extensions.CommandLineUtils.CommandLineApplication.Execute(String[] args) in C:\projects\commandlineutils\src\CommandLineUtils\CommandLineApplication.cs:line 611
   at Dotnet.Script.Program.Wain(String[] args) in C:\Users\VssAdministrator\AppData\Local\Temp\tmp1D34\Dotnet.Script\Program.cs:line 251
   at Dotnet.Script.Program.Main(String[] args) in C:\Users\VssAdministrator\AppData\Local\Temp\tmp1D34\Dotnet.Script\Program.cs:line 27
*/