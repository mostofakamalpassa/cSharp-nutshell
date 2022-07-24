using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers
{
    internal class Tuples
    {
        /******
         * 
         * Like anonymous types, tuples provide a simple way to store a set of values. 
         * The main purpose of tuples is to safely return multiple values from a method without resorting to out parameters (something you cannot do with anonymous types).
         * 
         * Tuples do almost everything that anonymous types do and more. Their one disadvantage—as you’ll see soon—is runtime type erasure with named elements.
         * *****/

        public void TupleTypes()
        {
            /***
             * 
             * The simplest way to create a tuple literal is to list the desired values in parenthesis. 
             * This creates a tuple with unnamed elements, which you refer to as Item1, Item2, and so on:
             * 
             * ***/
            var bob = ("Bob", 23); // Allow compiler to infer the element types
            Console.WriteLine(bob.Item1); // Bob
            Console.WriteLine(bob.Item2); // 23
                                          // Tuple are Value types with mutable (Read/write) element 

            var joe = bob; // joe is a *copy* of bob
            joe.Item1 = "Joe"; // Change joe’s Item1 from Bob to Joe
        }
    }
}
