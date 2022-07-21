using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericTypes
{
    internal interface IComparable<T> // Simplified version of interface
    {
        int CompareTo(T other);
    }
}
