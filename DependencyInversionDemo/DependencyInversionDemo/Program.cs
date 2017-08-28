using DependencyInversionDemo.After;
using System;

namespace DependencyInversionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEFORE");
            var b_logSvc = new Before.LoggingService();
            b_logSvc.LogEvent("FILE", "Runing the BEFORE service", "Event");
            Console.WriteLine();

            Console.WriteLine("AFTER");
            var fileLogger = new FileLogger();
            var a_logSvc = new After.LoggingService(fileLogger);
            a_logSvc.LogEvent("This is an event", "Event");

            Console.WriteLine();
            Console.WriteLine("Done");

            Console.ReadLine();
        }


    }
}
