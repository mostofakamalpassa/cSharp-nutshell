using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{
    /******
     * 
     * ===================== The Func and Action Delegates  ======================
        With generic delegates, it becomes possible to write a small set of delegate
        types that are so general they can work for methods of any return type and any (reasonable number of arguments. 
    
    These delegates are the Func and Action delegates, defined in the System namespace (the in and out annotations indicate variance, which we cover in the context of delegates shortly):
     * 
     * ******/
    internal class FuncAndActionDelegate
    {

        /*****
         * 
         * delegate TResult Func <out TResult> (); 
         * delegate TResult Func <in T, out TResult> (T arg); 
         * delegate TResult Func <in T1, in T2, out TResult> (T1 arg1, T2 arg2);
         * .. and so on, up to T16
         * delegate void Action ();
         * delegate void Action <in T> (T arg);
         * delegate void Action <in T1, in T2> (T1 arg1, T2 arg2);
         * .. and so on, up to T16
         * 
         * These delegates are extremely general. The Transformer delegate in our previous example can be replaced with a Func delegate that takes a single argument of type T and returns a same-typed value:
         * 
         * 
         * *****/

        public static void Transform<T>(T[] values, Func<T, T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = transformer(values[i]);
        }
    }
}
