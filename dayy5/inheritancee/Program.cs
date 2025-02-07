

namespace MuitipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of employee 1.Permanent 2.Temporary");
            string? type = Console.ReadLine();

            if (type.ToLower().Contains("per"))
            {
                //  IEmployee employee = new PermanentEmployee() { empid = 111, empname = "Riya", salary = 70000 };
                PermanentEmployee employee = new PermanentEmployee() { empid = 111, empname = "teju", salary = 70000 };
                employee.BasicDet();
                employee.SalDetails();
                employee.AttendMeetings();
                Interface1 emp = new PermanentEmployee() { empid = 113, empname = "vyshh", salary = 80000 };
                emp.BasicDet();
                emp.SalDetails();

            }
            else if (type.ToLower().Contains("temp"))
            {
                Interface1 tmp = new TemporaryEmployee()
                {
                    empid = 112,
                    empname = "Riyaz",
                    salaryperday = 7000
                };
                tmp.BasicDet();
                tmp.SalDetails();
            }

        }
    }
}
