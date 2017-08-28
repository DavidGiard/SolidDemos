using System;
using System.Text;

namespace SRPDemo.Before
{
    public class Employee : IEmployee
    {
        public Employee()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public decimal HourlyRate { get; set; }


        /// <summary>
        /// Calculate how much to pay employee
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public decimal CalculatePay(decimal hoursWorked)
        {
            return this.HourlyRate * hoursWorked;
        }

        /// <summary>
        /// Save customer info to database
        /// </summary>
        public void Save()
        {
            // TODO: Save to database
            Console.WriteLine("Saving data for employee {0} {1}...", FirstName, LastName);
        }

        /// <summary>
        /// Format text about Employee that can be appended to a report
        /// </summary>
        /// <returns></returns>
        public String ReportHours()
        {
            var sb = new StringBuilder();
            sb.Append(this.FirstName);
            sb.Append(" ");
            sb.Append(this.LastName);
            sb.Append("\n");
            sb.Append(this.JobTitle);

            return sb.ToString();
        }

    }
}
