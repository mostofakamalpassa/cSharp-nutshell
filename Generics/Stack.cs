using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /***********
     * =========================== Generics===========================
     * C# has two separate mechanisms for writing code that is reusable across different types: inheritance and generics. Whereas inheritance expressesreusability with a base type, generics express reusability with a “template”
     * 
     * that contains “placeholder” types. Generics, when compared to inheritance, can increase type safety and reduce casting and boxing.
     * 
     * *********/
    internal class Stack<T>
    {

        /***********
         * 
         * Generic Types
         * 
         * generic type declares type parameters—placeholder types to be filled in by the consumer of the generic type, which supplies the type arguments. 
         * Here is a generic type Stack<T>, designed to stack instances of type T.
         * Stack<T> declares a single type parameter T:
         * 
         * ***********/

        int position;
        T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];
    }
}
