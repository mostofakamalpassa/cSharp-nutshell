using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Dictionarys<TKey, TValue>
    {

        /*********
         * 
         * Generic type names and method names can be overloaded as long as the number of type parameters is different. For example, the following three type names do not conflict:
         * 
         * 
         * By convention, generic types and methods with a single type parameter typically name their parameter T, as long as the intent of the parameter is clear. 
         * 
         * When using multiple type parameters, each parameter is prefixed with T, but has a more descriptive name.
         * 
         * class A {} 
         * class A<T> {}
         * class A<T1,T2> {}
         * 
         * 
         * ********/
    }
}
