using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleUsage
{
    
    
        public delegate bool Delpromote(Student st);
        public class Student
        {
            public int stdid { get; set; }
            public string name { get; set; }    
            public int marks { get; set; }

            public static void Promotestudent(List<Student> lst , Delpromote isPromotable)
            {
                foreach (Student st in lst) 
                {
                    if (isPromotable(st))
                    {
                        Console.WriteLine(st.name + " is promoted");
                    }
                }
            }
        }
    
}
