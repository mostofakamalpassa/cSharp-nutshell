using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Base
{
    internal class Subclass : Baseclass
    {
        /*******
         * 
         * Subclass must hence “redefine” any constructors it wants to expose. In doing so, however, it can call any of the base class’s constructors via the base keyword
         * 
         * ****/

        public Subclass(int x) : base(x) { }

        /*********
         * The base keyword works rather like the this keyword except that it calls a constructor in the base class. Base-class constructors always execute first; this ensures that base initialization occurs before specialized initialization
         * 
         * *******/

        /*****
         * 
         * Implicit calling of the parameterless base-class constructor If a constructor in a subclass omits the base keyword, the base type’s parameterless constructor is implicitly called
         * 
         * ****/

        public Subclass() { Console.WriteLine(X); }

        /****
         * 
         * If the base class has no accessible parameterless constructor, subclasses are forced to use the base keyword in their constructors.
         * 
         * **/
    }
}
