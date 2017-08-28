namespace SRPDemo.After
{
    public class Payroll : IPayroll
    {
        public decimal CalculatePay(Employee employee, decimal hoursWorked)
        {
            return employee.HourlyRate * hoursWorked;
        }
    }
}
