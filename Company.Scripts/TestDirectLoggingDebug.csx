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

