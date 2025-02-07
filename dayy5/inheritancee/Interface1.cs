using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuitipleInheritance
{
    internal interface Interface1
    {
        void BasicDet();
        void SalDetails();
     }
    interface IMeeting
        {
            void AttendMeetings();
        }
    class PermanentEmployee : Interface1, IMeeting
        {
        public int empid { get; set; }
        public string? empname { get; set; }
        public decimal salary { get; set; }

        public static string OrgName = "Wipro";  

        public void AttendMeetings()
        {
            Console.WriteLine("Attend Meetings");
        }
        public void BasicDet()
        {
            Console.WriteLine(empid + " " + empname + " " + OrgName);
        }

        public void SalDetails()
        {
            Console.WriteLine(salary);
        }
    }
    class TemporaryEmployee : Interface1
    {
        public int empid { get; set; }
        public string? empname { get; set; }
        public decimal salaryperday { get; set; }
        public void BasicDet()
        {
            Console.WriteLine(empid + " " + empname);
        }

        public void SalDetails()
        {
            Console.WriteLine(salaryperday);
        }


    }
}
