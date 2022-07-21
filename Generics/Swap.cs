using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Swap<T>
    {
        /******
         * 
         * A generic method declares type parameters within the signature of a method. With generic methods, many fundamental algorithms can be implemented in a general-purpose way.
         * Here is a generic method that swaps the contents of two variables of any type T:
         * 
         * ****/
        static void SwapMethod<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        T[] data = new T[100];

       // we could write an indexer that returns a generic item
        public T this[int index] => data[index];
    }
}
