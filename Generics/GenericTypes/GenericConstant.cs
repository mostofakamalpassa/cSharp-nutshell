using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericTypes
{
    internal class GenericConstant
    {
        /******
         * 
         * Generic Constraints
         * By default, you can substitute a type parameter with any type whatsoever. Constraints can be applied to a type parameter to require more specific type  arguments.
         * These are the possible constraints:
         * 
         * where T : base-class // Base-class constraint
         * 
         * where T : interface // Interface constraint
         * where T : class // Reference-type constraint
         * where T : class? // (see “Nullable reference types”)
         * where T : struct // Value-type constraint (excludes Nullable types)
         * where T : unmanaged // Unmanaged constraint
         * 
         * where T : new() // Parameterless constructor constraint
         * where U : T // Naked type constraint
         * where T : notnull // Non-nullable value type, or (from C# 8)
         * // a non-nullable reference type
         * 
         * ******/
    }
}
