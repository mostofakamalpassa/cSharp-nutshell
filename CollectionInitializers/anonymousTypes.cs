using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers
{
    internal class anonymousTypes
    {
        /****
         * 
         * =============Anonymous Types===============
         * An anonymous type is a simple class created by the compiler on the fly to store a set of values.
         * To create an anonymous type, use the new keyword followed by an object initializer,specifying the properties and values the type will contain; for example
         * 
         * 
         * *****/

        public void Anonymous()
        {
            int Age = 23;
            var dude = new { Name = "Bob", Age = 23 };
            var dudes = new { Name = "Bob", Age = Age, Length = Age.ToString().Length };
            var a1 = new { X = 2, Y = 4 };
            var a2 = new { X = 2, Y = 4 };
            Console.WriteLine(a1.GetType() == a2.GetType()); // True

            // You can create arrays of anonymous types as follows:
            var dudeses = new[]
            {
            new { Name = "Bob", Age = 30 },
            new { Name = "Tom", Age = 40 }
            };
        }



    }

    // The compiler translates this to (approximately) the following

    internal class AnonymousGeneratedTypeName
    {
        private string name; // Actual field name is irrelevant
        private int age; // Actual field name is irrelevant
        public AnonymousGeneratedTypeName(string name, int age)
        {
            this.name = name; this.age = age;
        }
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        // The Equals and GetHashCode methods are overridden (see Chapter 6).
        // The ToString method is also overridden.
    }

    /*****
     * 
     * You must use the var keyword to reference an anonymous type because it doesn’t have a name.
     * 
     * The property name of an anonymous type can be inferred from an expression that is itself an identifier (or ends with one); thus
     * 
     * *****/


}
