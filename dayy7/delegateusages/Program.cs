// See https://aka.ms/new-console-template for more information
using static DeleUsage.Student;

Console.WriteLine("Hello, World!");//


namespace DeleUsage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { stdid = 1, name = " vyshh", marks = 60 },
                new Student() { stdid = 2, name = " gythri", marks = 50 },
                new Student() { stdid = 3, name = " teju", marks = 55 }
            };
            Delpromote delpromote = new Delpromote(IsPromote);
            Student.Promotestudent(students, delpromote);
        }

        static bool IsPromote(Student st)
        {
          if (st.marks > 50)
            {
                return true;
            }
            return false;
        }
    }
} 

