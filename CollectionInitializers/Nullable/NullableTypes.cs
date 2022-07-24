using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers.Nullable
{
    internal class NullableTypes
    {
        /*****
         * 
         * Reference types can represent a nonexistent value with a null reference. Value types, however, cannot ordinarily represent null values:
         * 
         * 
         * *****/
        public void NullableTyesCheck()
        {
            string s = null; // Ok Referency types
                             // int i = null;  // int is not Referecey type for that  get Error

            /**********
             * 
             * To represent null in a value type, you must use a special construct called a nullable type. A nullable type is denoted with a value type followed by the ? symbol
             * 
             * 
             * **********/
            int? i = null;

            Console.WriteLine(i == null); // it return true beacuse we assign explecitly  nullable type 


            // Implicit and Explicit Nullable Conversions
            // The conversion from T to T? is implicit, while from T? to T the conversion is explicit

            int? getInt = 5; // implicit
            int number = (int)getInt; // explicit

        }


        public void BoxingAndUnBoxing()
        {
            /********
             * 
             * When T? is boxed, the boxed value on the heap contains T, not T?. This optimization is possible because a boxed value is a reference type that can already express null.
             * 
             * 
             * C# also permits the unboxing of nullable value types with the as operator. The result will be null if the cast fails
             * **************/

            object obj = "string";
            int? x = obj as int?;
            Console.WriteLine(x.HasValue); // false 

        }
    }
}
