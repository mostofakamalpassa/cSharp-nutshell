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

        public void OperatorLefting()
        {
            // Operator Lifting

            /****
             * The Nullable<T> struct does not define operators such as <, >, or even ==. 
             * Despite this, the following code compiles and executes correctly
             * 
             * 
             * ****/

            int? x = 5;
            int? y = 10;
            bool b = x < y; // true

            /***
             * This works because the compiler borrows or “lifts” the less-than operator from the underlying value type.
             * 
             * 
             * ***/

            bool c = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;

            // Equality operator examples
            Console.WriteLine(x == y); // False
            Console.WriteLine(x == null); // False
            Console.WriteLine(x == 5); // True
            Console.WriteLine(y == null); // True
            Console.WriteLine(y == 5); // False
            Console.WriteLine(y != 5); // True

            // Relational operator examples
            Console.WriteLine(x < 6); // True
            Console.WriteLine(y < 6); // False
            Console.WriteLine(y > 6); // False

            // All other operator examples
            Console.WriteLine(x + 5); // 10
            Console.WriteLine(x + y); // null (prints empty line)

            /*********
             * 
             * The compiler performs null logic differently depending on the category of operator. 
             * The following sections explain these different rules.
             * 
             * *******/
        }
    }
}
