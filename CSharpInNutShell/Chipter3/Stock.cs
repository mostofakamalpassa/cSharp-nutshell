using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Stock
    {
        /*
         * Properties look like fields from the outside, but internally they contain logic,like methods do.
         * 
         * A property is declared like a field but with a get/set block added
         * 
         */

        decimal currentPrice; // The private "backing" field

        public decimal CurrentPrice // The public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        /*
         * get and set denote property accessors. The get accessor runs when the property is read. It must return a value of the property’s type. 
         * The set accessor runs when the property is assigned. 
         * It has an implicit parameter named value of the property’s type that you typically assign to a private field
         * 
         * 
         * Although properties are accessed in the same way as fields, they differ in that they give the implementer complete control over getting and setting its value.
         * 
         * This control enables the implementer to choose whatever internal representation is needed without exposing the internal details to the user of the property.
         * 
         */

        // Properties allow the following modifiers

        // Static modifier    static
        // Access modifiers  public internal private protected 
        // Inheritance modifiers new virtual abstract override sealed
        // Unmanaged code modifiers  unsafe extern

        decimal sharesOwned;

        //  Read-only and calculated properties

       // property is read-only if it specifies only a get accessor or getter
       // it is writeonly
        //if it specifies only a set accessor or Setter .Write-only properties are rarely used
        public decimal Worth
        {
            get { return currentPrice * sharesOwned; }
        }

        // more tersely as an expression-bodied property. A fat arrow replaces all the braces and the get and return keywords
        public decimal Worths => currentPrice * sharesOwned;

        // With a little extra syntax, set accessors can also be expression-bodied

        public decimal Worths1
        {
            get => currentPrice * sharesOwned;
            set => sharesOwned = value / currentPrice;
        }

        // Automatic properties 

        /*
         * The most common implementation for a property is a getter and/or setter that simply reads and writes to a private field of the same type as the property
         * 
         */
        public decimal CurrentPrice1 { get; set; }

        // Property initializers

        // You can add a property initializer to automatic properties, just as with  fields
        public decimal CurrentPrice11 { get; set; } = 123;

    }
}
