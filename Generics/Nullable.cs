using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /****
     * 
     * Declaring Type Parameters Type parameters can be introduced in the declaration of classes, structs, interfaces, delegates Other constructs, such as properties, cannot introduce a type parameter,
     * 
     * ****/
    internal class Nullable<T>
    {
        // A generic type or method can have multiple parameters
        public T Value { get; }
    }
}
