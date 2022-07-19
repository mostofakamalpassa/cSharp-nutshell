using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Foo
    {
        // The get and set accessors can have different access levels.
        // The typical use case for this is to have a public property with an internal or private
        // access modifier on the setter


        /*
         * 
         * Static field initializers run just before the static constructor is called.
         * If a type has no static constructor, static field initializers will execute just prior to the type being used—or anytime earlier at the whim of the runtime.
         * Static field initializers run in the order in which the fields are declared.
         * The following example illustrates this. X is initialized to 0 and Y is initialized to 3:
         * 
         * */
        public static int XX = Y; // 0
        public static int Y = 3; // 3

        /*****
         * 
         * If we swap the two field initializers around, both fields are initialized to 3.
         * The next example prints 0 followed by 3 because the field initializer that instantiates a Foo executes before X is initialized to 3:
         * 
         * ****/
        public static Foo Instance = new Foo();
        public static int Xxx = 3;

        private decimal x;
        public decimal X
        {
            get { return x; }
            private set { x = Math.Round(value, 2); }
        }
    }
}
