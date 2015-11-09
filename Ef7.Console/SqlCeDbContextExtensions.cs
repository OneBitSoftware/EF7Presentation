using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Framework.Logging;

namespace Ef7.Console
{
    public static class SqlCeDbContextExtensions
    {
        public static void LogQuery(this DbContext context)
        {
            var loggerFactory = (context).GetService<ILoggerFactory>();
            loggerFactory.AddProvider(new DbLoggerProvider());
        }
    }
}