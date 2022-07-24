using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers.Nullable
{

    /**********
     * 
     * =========== Scenarios for Nullable Value Types ===========
     * One of the most common scenarios for nullable value types is to represent unknown values.
     * 
     * This frequently occurs in database programming, where a class is mapped to a table with nullable columns. 
     * If these columns are strings (e.g., an EmailAddress column on a Customer table), there is no problem because string is a reference type in the CLR, which can be null.
     * However, most other SQL column types map to CLR struct types, making nullable value types very useful when mapping SQL to the CLR:
     * 
     * 
     * ***********/
    internal class Customer
    {
        public decimal? AccountBalance;

        /********
         * 
         * A nullable type can also be used to represent the backing field of what’s sometimes called an ambient property. 
         * An ambient property, if null, returns the value of its parent:
         * 
         * 
         * 
         * **********/
    }


    public class Row
    {
       // Grid parent;
        Color? color;

        public Color Color
        {
            // get { return color ?? parent.Color; }
            //set { color = value == parent.Color ? (Color?)null : value; }
            get;
            set;
        }
    }

}
