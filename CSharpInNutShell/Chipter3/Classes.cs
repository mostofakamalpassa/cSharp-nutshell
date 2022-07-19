using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Classes
    {

        // A class most common kind of Reference type 
        /*
         * Preceding the  Attributes and class modifiers. The non-nested class modifiers are public,
         * 
         * keyword class   internal, abstract, sealed, static, unsafe, and partial.
         * 
         * Following    Generic type parameters and constraints, a base class, and interfaces.
         * 
         * Within the braces    Class members (these are methods, properties, indexers, events, fields, constructors, overloaded operators, nested types, and a finalizer).
         * 
         * 
         * 
         */


        // Field 

        // Field is a variable that is a member of a class or struct;

        string name; // Filed 
        public int Age = 10; //  Filed

        // Static modifier   static

        // Access modifiers  public internal private protected

        // Inheritance modifier     new 

        // Unsafe code modifier   unsafe 
        // Read-only modifier     readonly

        // Threading modifier      volatile

        // Field initialization
        // Field initialization is optional. An uninitialized field has a default value (0, '\0', null, false). Field initializers run before constructors:

        //A field initializer can contain expressions and call methods: 

        static readonly string TempFolder = System.IO.Path.GetTempPath();

        // Declaring multiple fields together

        static readonly int legs = 8,  eyes = 2;

        // Constants
        // A constant is declared with the const keyword and must be initialized with a value
        public const string Message = "Hello World";


        public static double Circumference(double radius)
        {
            return 2 * System.Math.PI * radius;
        }

        void Test()
        {
            //  Constants can also be declared local to a method:
            const double twoPI = 2 * System.Math.PI;
           
}

    }
}
