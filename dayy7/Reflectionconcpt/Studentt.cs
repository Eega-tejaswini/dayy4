using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflectionconcpt
{
    internal class Studentt
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Studentt()
        {
            Console.WriteLine(" default constructor");
        }
        public Studentt(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void PrintId()
        {
            Console.WriteLine(" display " + Id);
        }
        public void PrintName()
        {
            Console.WriteLine(" display " + Name);
        }
    }
}
