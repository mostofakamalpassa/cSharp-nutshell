using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericTypes
{
    public class Compare<T>
    {
        static public T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        internal static void Max<T1, T2>(T2 v1, T2 v2)
        {
            throw new NotImplementedException();
        }
    }
}
