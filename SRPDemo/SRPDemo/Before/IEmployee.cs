namespace SRPDemo.Before
{
    public interface IEmployee
    {
        string Address { get; set; }
        string FirstName { get; set; }
        decimal HourlyRate { get; set; }
        string JobTitle { get; set; }
        string LastName { get; set; }

        decimal CalculatePay(decimal hoursWorked);
        string ReportHours();
        void Save();
    }
}