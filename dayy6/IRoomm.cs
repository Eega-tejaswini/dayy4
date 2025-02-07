using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayy6
{
    internal interface IRoomm<T>

    {
        void AddRoom(T item);
        IEnumerable<T> GetAll();  
    }
}
