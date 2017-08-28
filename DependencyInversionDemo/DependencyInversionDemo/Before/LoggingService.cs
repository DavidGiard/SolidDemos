using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionDemo.Before
{
    public class LoggingService
    {
        public void LogEvent(string logType, string message, string category)
        {
            if (logType == "EVENTLOG")
            {
                var logger = new EventLogLogger();
                logger.LogEvent(message, category);
            }
            else if (logType == "FILE")
            {
                var logger = new FileLogger();
                logger.LogEvent(message, category);
            }
            else if (logType == "FAKE")
            {
                var logger = new FakeLogger();
                logger.LogEvent(message, category);
            }
            else
            {
                var logger = new EventLogLogger();
                logger.LogEvent(message, category);
            }
        }
    }
}
