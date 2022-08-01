using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers.Nullable
{
    internal class EqualityOperators
    {

        /******
         * 
         * ============ Equality operators (== and !=) ============= 
         * Lifted equality operators handle nulls just like reference types do. 
         * This means that two null values are equal
         * 
         * *******/
        public void Equality()
        {
            Console.WriteLine(null == null); // True
            Console.WriteLine((bool?)null == (bool?)null); // True

            // If exactly one operand is null, the operands are unequal.
            // If both operands are non-null, their Values are compared.

        }

        public void RelationalOperator()
        {

            int? x = 5;
            int? y = null;
            // Relational operators (<, <=, >=, >)

            /****
             * The relational operators work on the principle that it is meaningless to compare null operands. This means comparing a null value to either a null or a non-null value returns false:
             * 
             * ***/

            bool b = x < y; // Translation:
            bool c = (x.HasValue && y.HasValue)
            ? (x.Value < y.Value)
            : false;
            // b is false (assuming x is 5 and y is null)
        }

        public void AllOtherOperators()
        {
            int? x = 5;
            int? y = null;
            // All other operators (+, −, *, /, %, &, |, ^, <<, >>, +, ++, --, !, ~)

            // These operators return null when any of the operands are null. This pattern should be familiar to SQL users

            int? c = x + y; // Translation:
            int? d = (x.HasValue && y.HasValue) ? (int?)(x.Value + y.Value) : null;
            // c is null (assuming x is 5 and y is null)

            // An exception is when the & and | operators are applied to bool?, which we discuss shortly
        }

        public void MixingNullableAndNonNullableOperators()
        {
            /****
             * 
             * You can mix and match nullable and non-nullable value types (this works because there is an implicit conversion from T to T?):
             * 
             * ***/

            int? a = null;
            int b = 2;
            int? c = a + b; // c is null - equivalent to a + (int?)b
        }

        public void NullableValueTypesAndNullOperators(){
            // Nullable value types work particularly well with the ?? operator

            int? x = null;
            int y = x ?? 5; // y is 5

            int? a = null, b = 1, c = 2;
            Console.WriteLine(a ?? b ?? c); // 1 (first non-null value)

            // Using ?? on a nullable value type is equivalent to calling
            // GetValueOrDefault with an explicit default value except that the expression for the default value is never evaluated if the variable is not null.

            // Nullable value types also work well with the null-conditional operator

            System.Text.StringBuilder sb = null;
            int? length = sb?.ToString().Length;

            int lengths = sb?.ToString().Length ?? 0; // Evaluates to 0 if sb is null

        }

        

    }
}
