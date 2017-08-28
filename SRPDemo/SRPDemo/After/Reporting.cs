using System;
using System.Text;

namespace SRPDemo.After
{
    public class Reporting: IReporting
    {
        public String ReportHours(Employee employee)
        {
            var sb = new StringBuilder();
            sb.Append(employee.FirstName);
            sb.Append(" ");
            sb.Append(employee.LastName);
            sb.Append("\n");
            sb.Append(employee.JobTitle);

            return sb.ToString();
        }
    }
}
