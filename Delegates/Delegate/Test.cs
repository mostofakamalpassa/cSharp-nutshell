using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{

    /*********
     * 
     * ============ A delegate is an object that knows how to call a method ===================
     * 
     * A delegate type defines the kind of method that delegate instances can call.
     * Specifically, it defines the method’s return type and its parameter types.
     * The following defines a delegate type called Transformer
     * 
     * 
     * ***********/
    delegate int Transformer(int x);  // Delegate type declaration
    /****
     * Transformer is compatible with any method with an int return type and a single int parameter, such as this:
     * 
     * A delegate is similar to a callback, a general term that captures constructs such as C function pointers.
     * 
     * A delegate’s target method can be a local, static, or instance method
     * 
     * *****/
    internal class Test
    {
       public int Square(int x) { return x * x; }

        // more testly 

       public int Square2(int x) => x * x;

        public void Transfrom(int[] values , Transformer t)
        {
            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(t(values[i])); ;
            }
        }
    }
}
