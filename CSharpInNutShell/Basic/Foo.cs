using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class Foo
    {
        System.Text.StringBuilder sb;

        public Foo(string initialize)
        {
            sb = new (initialize);
        }

        /*
         * Target-typed new expressions are also helpful in the following scenario:
         * MyMethod (new ("test"));
         * void MyMethod (System.Text.StringBuilder sb) { ... } 
         * 
         */

        public void NullCoalescingOperator()
        {
            string s1 = null;
            string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"

            /*
             * If the lefthand expression is non-null, the righthand expression is never evaluated. The null-coalescing operator also works with nullable value types
             */
        }


        public void NullCoalescingAssignmentOperator()
        {

            /*
             * The ??= operator is the null-coalescing assignment operator.
             * If the operand to the left is null, assign the right operand tothe left operand.
             * 
             */
            string name = null;
             name ??= "hello kamal";

            // This is equivalent to:
            if (name == null)
            {
                name = "Hello kamal";
            }
        }

        public void NullConditionalOperator()
        {
            /*
             * The ?. operator is the null-conditional or “Elvis” operator (after the Elvis emoticon). It allows you to call methods and access members just like the standard dot operator except that if the operand on the left is null, the expression evaluates to null instead of throwing a NullReferenceException:
             * 
             * 
             * NullReferenceException:
             */

            System.Text.StringBuilder sb = null;
            string s = sb?.ToString(); // No error; s instead evaluates to null

            // The last line is equivalent to the following:
            string ss = (sb == null ? null : sb.ToString());

           // Null - conditional expressions also work with indexers:
            string foo = null;
            char? c = foo?[1]; // c is null

            string x = null;
            string y = null;
            string z = "hello";

            //x?.y?.z

           // x == null ? null: (x.y == null ? null : x.y.z)
        }
    }
}
