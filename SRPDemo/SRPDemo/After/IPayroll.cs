namespace SRPDemo.After
{
    public interface IPayroll
    {
        decimal CalculatePay(Employee employee, decimal hoursWorked);
    }
}