using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericTypes
{
    internal class A<T>
    {
    }

    internal class A<T1, T2>
    {
    }

    // Type a1 = typeof (A<>); // Unbound type (notice no type arguments).
    // Type a2 = typeof(A<,>); // Use commas to indicate multiple type args


    //You can also use the typeof operator to specify a closed type:

    //Type a3 = typeof (A<int,int>);
}
