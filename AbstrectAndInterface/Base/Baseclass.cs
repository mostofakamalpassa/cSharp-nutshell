using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Base
{
    internal class Baseclass
    {
        /*****
         * 
         * A subclass must declare its own constructors. The base class’s constructors are accessible to the derived class but are never automatically inherited. For example, if we define Baseclass and Subclass as follows:
         * 
         * 
         * ***/
        public int X;
        public Baseclass() { }
        public Baseclass(int x) { this.X = x; }
    }
}
