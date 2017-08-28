using System;

namespace DependencyInversionDemo.After
{
    public class FakeLogger : ILogger
    {
        public void LogEvent(string message, string category)
        {
            // Do nothing. Used for testing
            Console.WriteLine("Fake logger");

        }
    }
}
