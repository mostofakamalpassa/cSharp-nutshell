using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class VariableAndParameters
    {

        /*
         * A variable represents a storage location that has a modifiable value. A variable can be a local variable, parameter (value, ref, or out, or in), field (instance or static), or array element
         * 
         * 
         */

        /*
         * The Stack and the Heap
         * The stack and the heap are the places where variables reside. Each has very different lifetime semantics.
         * 
         */


        public void Stack()
        {
            /*
             * The stack is a block of memory for storing local variables and parameters.The stack logically grows and shrinks as a method or function is entered and exited
             */


        }

        static int FactorialStack(int x)
        {
            if (x == 0) return 1;
            return x * FactorialStack(x - 1);

            /*
             * This method is recursive, meaning that it calls itself. Each time the method is entered, a new int is allocated on the stack, and each time the method exits, the int is deallocated
             */
        }


        public void HeapMemory()
        {
            /*
             * The heap is the memory in which objects (i.e., reference-type instances) reside. Whenever a new object is created, it is allocated on the heap, and a reference to that object is returned. During a program’s execution, the heap begins filling up as new objects are created.
             */

            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);
            // The StringBuilder referenced by ref1 is now eligible for GC.
            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;
            // The StringBuilder referenced by ref2 is NOT yet eligible for GC.
            Console.WriteLine(ref3); // object2
        }
    }
}
