using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Test
    {

        string name;
        // The this reference also disambiguates a local variable or parameter from a field
        public Test(string name) { this.name = name; }

        //The this reference is valid only within nonstatic members of a class or struct.

        /**
         * 
         * A static constructor executes once per type rather than once per instance.
         * A type can define only one static constructor, and it must be parameterless and have the same name as the type:
         * 
         */
        static Test() { Console.WriteLine("Type Initialized"); }

        /**
         * 
         * The runtime automatically invokes a static constructor just prior to the type being used. Two things trigger this:
         * 
         * */

        // Instantiating the type

        // Accessing a static member in the type

        // The only modifiers allowed by static constructors are unsafe and extern

        // If a static constructor throws an unhandled exception that type becomes unusable for the life of the application.



    }
}
