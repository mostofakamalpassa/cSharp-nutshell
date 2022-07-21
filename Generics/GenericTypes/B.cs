using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericTypes
{
    internal class B <T>

    {
        void X() { Type t = typeof(T); }

        /******
         * 
         * =============== The default Generic Value ===============
         * You can use the default keyword to get the default value for a generic type parameter.
         * The default value for a reference type is null, and the default value for a value type is the result of bitwise-zeroing the value type’s fields
         * 
         * ******/

        static void Zap<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = default(T);
        }

    }
}
