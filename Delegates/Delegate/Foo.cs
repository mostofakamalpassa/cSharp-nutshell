using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{
    public interface IFoo { event EventHandler Ev; }
    internal class Foo : IFoo
    {
        public event EventHandler ev;

        event EventHandler IFoo.Ev
        {
            add { ev += value; }
            remove { ev -= value; }
        }
    }

    /******
     * 
     * ================ Event Modifiers  ===================
     * Like methods, events can be virtual, overridden, abstract, or sealed. Events can also be static:
     * 
     * 
     * ********/
    public class Foo2
    {
        public static event EventHandler<EventArgs> StaticEvent;
        public virtual event EventHandler<EventArgs> VirtualEvent;
    }
}
