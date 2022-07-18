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


        /*
         * Parameters
         * A method may have a sequence of parameters. Parameters define the set of arguments that must be provided for that method.
         * 
         * 
         */


        /*
         * You can control how parameters are passed with the ref, in, and out modifiers
         * ref -> Reference  -> Going in
         * in -> Reference (read-only)  -> Going in
         * out -> Reference  -> Going in
         * 
         */

        // Passing arguments by value
        //By default, arguments in C# are passed by value, which is by far the most common case.

        StringBuilder sb = new StringBuilder();
        static void Foo(int p)
        {

            p = p + 1; // Increment p by 1
            Console.WriteLine(p); // Write p to screen
        }

        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }

        static void Foo(ref int p)
        {
            p = p + 1; // Increment p by 1
            Console.WriteLine(p); // Write p to screen
        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        void Split(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }
        // Like a ref parameter, an out parameter is passed by reference.


        int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
                sum += ints[i]; // Increase sum by ints[i]
            return sum;
        }

        // name arguments 

        void Foo(int x, int y) { Console.WriteLine(x + ", " + y); }

        //Foo(x:1, y:2);
        //Foo(y:2, x:1);


        public void TargetTypeExpression()
        {

            /*
             * Another way to reduce lexical repetition is with target-typed new expressions (
          
             */

            System.Text.StringBuilder sb1 = new();
            System.Text.StringBuilder sb2 = new("Test");

            // This is precisely equivalent to:

            System.Text.StringBuilder sb4 = new System.Text.StringBuilder();
            System.Text.StringBuilder sb5 = new System.Text.StringBuilder("Test");
        }
    }
}
