using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    
  
        public class MathOp
        {
            public virtual int Add(int a, int b)
            {
                return a + b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }
            public int Mul(int a, int b)
            {
                return a * b;
            }
            public int Div(int a, int b)
            {
                return a / b;
            }

            public virtual bool CheckVal()
            {
                return false;
            }

        }
        public class Student
        {
            string Name;
            int Age;

            public Student(string ename, int age)
            {
                Name = ename;
                Age = age;
            }
            public string name
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }

            public int age
            {
                get
                {
                    return Age;
                }
                set
                {
                    Age = value;
                }
            }

            public void Display()
            {
                Console.WriteLine(Name + " " + Age);
            }
        }

    
}

