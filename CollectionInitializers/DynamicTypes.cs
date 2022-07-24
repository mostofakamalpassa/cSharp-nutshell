using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers
{
    /******
     * 
     * Instead, you must use object or dynamic and then whoever calls Foo must rely on dynamic binding, with loss of static type safety (and IntelliSense in Visual Studio).
     *  
     * *****/
    internal class DynamicTypes
    {

        dynamic Foo() => new { Name = "Bob", Age = 30 }; // No static type safety.


        /***
         * 
         * Anonymous types are immutable, so instances cannot be modified after creation.
         * However, from C# 10, you can use the with keyword to create a copy with variations (nondestructive mutation):
         * 
         * ****/
        public void Anonymus()
        {
            var a1 = new { A = 1, B = 2, C = 3, D = 4, E = 5 };
            var a2 = a1 with { E = 10 };
            Console.WriteLine(a2); // { A = 1, B = 2, C = 3, D = 4, E = 10 }

            // Anonymous types are particularly useful when writing LINQ queries
        }
    }
}
