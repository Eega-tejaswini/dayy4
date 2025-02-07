using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDe
{
    public delegate void MathOpDel(int c, int d);
    internal class MathOper
    {
       // public delegate void MathOpDel(int c, int d);
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
