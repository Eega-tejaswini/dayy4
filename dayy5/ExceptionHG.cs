using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ExceptionHG
    {
    
    
        
        internal class AgeException : Exception
        {
            public AgeException(string errmsg) : base(errmsg)
            { }
        }

    }
}

