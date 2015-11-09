using System;
using System.IO;
using Microsoft.Framework.Logging;

namespace Ef7.Console
{
    public class DbFileLogger : ILogger
    {
        public void Log(LogLevel logLevel, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
        {
            var message = $"{Environment.NewLine}{formatter(state, exception)}";
            //var decoration = new String('=', 10);
            using (var writter = new StreamWriter("D://sqlOutput.txt", true))
            {
                //writter.Write("{0} {1} {0}", decoration, DateTime.Now);
                writter.Write(message);
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScopeImpl(object state)
        {
            return null;
        }
    }
}