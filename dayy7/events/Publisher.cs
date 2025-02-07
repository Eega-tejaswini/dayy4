using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void DelEvent();
    internal class Publisher
    {
        public event DelEvent SampleEvent;

        public void Initiate()
        {
            Console.WriteLine(" Event started");
            RaiseEvent();
        }

        public void RaiseEvent()
        {
            SampleEvent?.Invoke();
        }
    }
}
