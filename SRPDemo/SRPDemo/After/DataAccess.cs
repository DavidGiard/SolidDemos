using System;

namespace SRPDemo.After
{
    public class DataAccess: IDataAccess
    {
        public void Save(IEmployee employee)
        {
            // TODO: Save to database
            Console.WriteLine("Saving data for employee {0} {1}...", 
                employee.FirstName, employee.LastName);

        }
    }
}
