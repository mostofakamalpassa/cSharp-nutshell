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
         * Polymorphism works on the basis that subclasses (Stock and House) have all the features of their base class (Asset). 
         * The converse, however, is not true. 
         * If Display was modified to accept a House, you could not pass in an Asset:
         */





    /****
     * ================= Casting and Reference Conversions ==========
     * 
     * An object reference can be
     * 
     * Implicitly upcast to a base class reference
     * 
     * Explicitly downcast to a subclass reference
     * 
     * Upcasting and downcasting between compatible reference types performs
     * reference conversions: a new reference is (logically) created that points to the same object
     * An upcast always succeeds; a downcast succeeds only if the object is suitably typed
     * 
     * =================== Upcasting ================
     * An upcast operation creates a base class reference from a subclass reference
     * 
     * Stock msft = new Stock();
     * Asset a = msft; // Upcast
     * 
     * 
     * ================== Downcasting =========================
     * A downcast operation creates a subclass reference from a base class reference
     * 
     * Stock msft = new Stock();
        Asset a = msft; // Upcast
        Stock s = (Stock)a; // Downcast
        Console.WriteLine (s.SharesOwned); // <No error>
        Console.WriteLine (s == a); // True
        Console.WriteLine (s == msft); // True
     * 
     * ***/


        // as operator
        // is operator

    public virtual decimal Liability => 0; // Expression-bodied property

        /***
         * 
         * ==========Virtual Function Members ==================
         * 
         * */


        public virtual Asset Clone() => new Asset { Name = Name };

    }
}
