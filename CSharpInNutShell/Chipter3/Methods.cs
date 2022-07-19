using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Methods
    {
        /*
         * A method performs an action in a series of statements. A method can receive input data from the caller by specifying parameters and output data back to the caller by specifying a return type. A method can specify a void return type, indicating that it doesn’t return any value to its caller.
         * A method can also output data back to the caller via ref/out parameters.
         * A method’s signature must be unique within the type. 
         * A method’s signature comprises its name and parameter types in order (but not the parameter names, nor the return type).
         * 
          
         */


        /*
         * Methods allow the following modifiers:
         * 
         * Static modifier              static
         * Access modifiers             public internal private protected
         * Inheritance modifiers        new virtual abstract override sealed
         * Partial method modifier      partial
         * Unmanaged code modifiers     unsafe extern
         * Asynchronous code modifier   async
         * 
         */

        // Expression-bodied methods
        // A method that comprises a single expression, such as

        int Foo(int x) { return x * 2; }

        // can be written more tersely as an expression-bodied method. A fat arrow replaces the braces and return keyword
        int Foo1(int x) => x * 2;

        // Expression-bodied functions can also have a void return type:

        void Foo2(int x) => Console.WriteLine(x);


        // Local methods
        //You can define a method within another method

        void WriteCubes()
        {
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube(5));
            int Cube(int value) => value * value * value;
            // Static local methods
            static int Cube1(int value) => value * value * value;
        }


        // Overloading methods
        // A type can overload methods (define multiple methods with the same name) as long as the signatures are different.

        void Foo3(int x) { Console.WriteLine(x);  }
        void Foo3(double x) { Console.WriteLine(x); }
        void Foo3(int x, float y) { Console.WriteLine(x + y); }
        void Foo3(float x, int y) { Console.WriteLine(x+y); }

        /*
         * However, the following pairs of methods cannot coexist in the same type, because the return type and the params modifier are not part of a method’s signature:
         * 
         * Whether a parameter is pass-by-value or pass-by-reference is also part of the signature. For example, Foo(int) can coexist with either Foo(ref int) or Foo(out int). However, Foo(ref int) and Foo(out int) cannot coexist:
         */
    }
}
