using Microsoft.Framework.Logging;

namespace Ef7.Console
{
    public class DbLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string name)
        {
            //return new DbConsoleLogger(); 
            return new DbFileLogger();
        }

        public void Dispose()
        {
        }
    }
}