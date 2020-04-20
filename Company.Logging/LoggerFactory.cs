using Microsoft.Extensions.Logging;

namespace Company.Logging
{
    public class Logger
    {
        private static ILoggerFactory _loggerFactory = null;

        private static ILogger GetLogger()
        {
            if (_loggerFactory == null)
            {
                _loggerFactory = LoggerFactory.Create(builder => {
                    builder.SetMinimumLevel(LogLevel.Debug);
                    builder.AddConsole();
                });
            }
            return _loggerFactory.CreateLogger("Company");
        }

        public static void LogInformation(string info, params object[] args)
        {
            GetLogger().LogInformation(info, args);
        }
    }
}
