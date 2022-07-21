using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Base
{
    internal class Stack
    {
        /// <summary>
        /// Because Stack works with the object type, we can Push and Pop instances of any type to and from the Stack
        /// </summary>
        /// 
        int position = 0;
        object[] data = new object[10];
        public void Push(object obj) { data[position++] = obj; }
        public object Pop() { return data[--position]; }

        ///object is a reference type, by virtue of being a class. Despite this, value
        // types, such as int, can also be cast to and from object, and so be added to our stack.

        /****
         * 
         * When you cast between a value type and object, the CLR must perform some special work to bridge the difference in semantics between value and reference types. This process is called boxing and unboxing
         * 
         * 
         * *****/


        /**************
         * 
         * ============= Boxing and Unboxing =================== 
         * Boxing is the act of converting a value-type instance to a reference-type instance. 
         * The reference type can be either the object class or an interface
         * 
         * 
         * **********/
        
        public void Boxing()
        {

            int x = 9;
            object obj = x; // Box the int
        }


        /// <summary>
        /// Unboxing reverses the operation by casting the object back to the original value type:
        /// </summary>
        public void UnBoxing()
        {
            int x = 9;
            object obj = x;
            int y = (int)obj; // Unbox the int
        }
        /***********
         * 
         * Unboxing requires an explicit cast. The runtime checks that the stated value type matches the actual object type, and throws an InvalidCastException if the check fails. For instance, the following throws an exception because long does not exactly match int:
         * 
         * 
         * ********/

        public void BoxingToUnBoxing()
        {
         //   The following succeeds, however:
            object obj = 9;
            long x = (int)obj;

          //  As does this:
         object objs = 3.5; // 3.5 is inferred to be of type double
            int xx = (int)(double)objs; // x is now 3
        }


        /***********
         * 
         * ================ Copying semantics of boxing and unboxing ===============    
         * Boxing copies the value-type instance into the new object, and unboxing copies the contents of the object back into a value-type instance.
         * In the following example, changing the value of i doesn’t change its previously boxed copy:
         * 
         * 
         * ***********/

        public void CopingSematicBoxingAndUnboxing()
        {
            int i = 3;

            dynamic name = "kamal";
            name = 2345;
            var abc = 10;
            Console.WriteLine(name);
            //abc = "jamal";
            object boxed = i;
            i = 5;
            Console.WriteLine(boxed); // 3


            
        }
    }
}
