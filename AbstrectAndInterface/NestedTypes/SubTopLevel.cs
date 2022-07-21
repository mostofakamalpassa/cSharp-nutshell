using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.NestedTypes
{

    /***************
     * 
     * 
     * Nested types are used heavily by the compiler itself when it generates private classes that capture state for constructs such as iterators and anonymous methods.
     * 
     * 
     * ***********/
    internal class SubTopLevel : TopLevel
    {
        static void Foo() { new TopLevel.Nested(); }
    }
}
