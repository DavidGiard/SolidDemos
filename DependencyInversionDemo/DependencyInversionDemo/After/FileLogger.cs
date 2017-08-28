using System;
using System.IO;

namespace DependencyInversionDemo.After
{
    public class FileLogger : ILogger
    {
        public void LogEvent(string message, string category)
        {
            string fileName = string.Format(@"c:\test\Log_{0:yyyy-MM-dd}.txt", DateTime.Today);

            string[] logLines = 
                {
                "===========",
                category,
                "===========",
                System.DateTime.Now.ToString(),
                message,
                };
            File.WriteAllLines(fileName, logLines);

            Console.WriteLine("File logger");

        }
    }
}
