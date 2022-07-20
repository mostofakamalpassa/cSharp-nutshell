using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3.Inheritance
{

    // A derived class is also called a subclass, Child Class.
    // A base class is also called a superclass, parent Class.
    internal class Asset
    {
        public string Name;

        /***
         * =============== Polymorphism ==============
         * References are polymorphic. 
         * This means a variable of type x can refer to anobject that subclasses x.
         * For instance, consider the following method
         * 
         * **/
        public static void Display(Asset asset)
        {
            System.Console.WriteLine(asset.Name);
        }

        /*****
         * 
         * 
         * This method can display both a Stock and a House because they are both Assets:
         * 
         * ***/


        /*
         * This method can display both a Stock and a House because they are both Assets:
            Stock msft = new Stock ... ;
            House mansion = new House ... ;
            Display (msft);
            Display (mansion);
         * 
         */
    }
}
