using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class TypeConversion
    {

        public void NumberAllTypeConversion()
        {
            int x = 12345; // int is a 32-bit integer
            long y = x; // Implicit conversion to 64-bit integer
            short z = (short)x; // Explicit conversion to 16-bit integer
        }

        public void ValueTypes()
        {
            /*
             * Value types comprise most built-in types (specifically, all numeric types, the
char type, and the bool type) as well as custom struct and enum types.
Reference types comprise all class, array, delegate, and interface types.
(This includes the predefined string type.)
The fundamental difference between value types and reference types is how
they are handled in memory.
            
             * */
            /*
             * Value types 
             * Signed integer (sbyte, short, int, long)
             * Unsigned integer (byte, ushort, uint, ulong)
             * Real number (float, double, decimal)
             * Logical (bool)
             * Character (char)
             * IntPtr
             * UIntPtr
             * 
             */
        }

        public void ReferencyTypes()
        {
            /*
             * A reference type is more complex than a value type, having two parts: an
object and the reference to that object. The content of a reference-type
variable or constant is a reference to an object that contains the value.
             * */

            /*
             * String (string)
             * Object (object)
             * */
        }

        public void GetTypeOfType()
        {

            Console.WriteLine(1.0.GetType());
            Console.WriteLine("Heloo".GetType());
            Console.WriteLine(100.GetType());
            Console.WriteLine(0b100.GetType());
        }
    }
}
