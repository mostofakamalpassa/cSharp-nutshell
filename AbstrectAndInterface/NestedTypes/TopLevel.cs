using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.NestedTypes
{
    internal class TopLevel
    {
        static int x;

        /*************
         * 
         * It can access the enclosing type’s private members and everything else the enclosing type can access.
         * 
         * You can declare it with the full range of access modifiers rather than just public and internal
         * 
         * The default accessibility for a nested type is private rather than  internal.
         * 
         * **********/
       public class Nested
        {
            static void Foo() { Console.WriteLine(TopLevel.x); }
        }
    }
}
