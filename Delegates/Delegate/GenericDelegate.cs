using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{
    /*******
     * 
     * =================Generic Delegate Types ================
     * 
     * A delegate type can contain generic type parameters:
     * 
     * public delegate T Transformer<T> (T arg);
     * 
     * With this definition, we can write a generalized Transform utility method that works on any type:
     * 
     * 
     * 
     * *****/

    public delegate T Transfomaer<T>(T tag);
    internal class GenericDelegate
    {

        public static void Transform<T>(T[] values, Transfomaer<T> t)
        {

            for(int i = 0; i < values.Length; i++)
            {
               values[i] =  t(values[i]);


            }

        }
    }
}
