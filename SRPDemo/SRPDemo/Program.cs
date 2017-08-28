using System;

namespace SRPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEFORE");
            var employeeB = new Before.Employee()
            {
                FirstName = "David",
                LastName = "Giard",
                JobTitle = "TE",
                HourlyRate = 15
            };
            var payB = employeeB.CalculatePay(40);
            Console.WriteLine("Employee {0} earned ${1:#,###0.00}", 
                    employeeB.FirstName, payB);

            Console.WriteLine();

            Console.WriteLine("AFTER");
            var employeeA = new After.Employee()
            {
                FirstName = "Satya",
                LastName = "Nadella",
                JobTitle = "CEO",
                HourlyRate = 1000
            };
            var payroll = new After.Payroll();
            var payA = payroll.CalculatePay(employeeA, 40);
            Console.WriteLine("Employee {0} earned ${1:#,###0.00}", 
            employeeA.FirstName, payA);
            Console.ReadLine();

            Console.WriteLine();

        }
    }
}
