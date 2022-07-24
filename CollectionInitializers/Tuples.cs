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

            Console.WriteLine(bob); // (Bob, 23)
            Console.WriteLine(joe); // (Joe, 23)
            /**  Unlike with anonymous types, you can specify a tuple type explicitly. Just list each of the element types in parenthesis: ***/

            (string, int) bobs = ("Bob", 23);
        }

        // This means that you can usefully return a tuple from a method
        public (string, int) Person()
        {
            return ("kamal", 23);
        }

        // Tuples play well with generics, so the following types are all legal:

        Task<(string, int)> PersonInfo;
        Dictionary<(string, int), Uri> PersionDecotryan;
        IEnumerable<(int id, string name)> PersonEmutable;// See below for naming elements


        public void NamingTupleElements()
        {
            // Naming Tuple Elements
            // You can optionally give meaningful names to elements when creating tuple literals:

            var tuple = (name: "Bob", age: 23);

            Console.WriteLine(tuple.name); // Bob
            Console.WriteLine(tuple.age); // 23

            // You can do the same when specifying tuple types:
            (string name, int age) GetPersons() => ("Bob", 23);


            /*****
             * 
             * Note that you can still treat the elements as unnamed and refer to them as Item1, Item2, etc. (although Visual Studio hides these fields from IntelliSense).
             * 
             * Element names are automatically inferred from property or field names:
             * 
             * ***/

            var now = DateTime.Now;
            var tuples = (now.Day, now.Month, now.Year);
            Console.WriteLine(tuples.Day); // OK

            /****
             * 
             * 
             * Tuples are type compatible with one another if their element types match up (in order). Their element names need not:

            ***/
            (string name, int age, char sex) bob1 = ("Bob", 23, 'M');
            (string age, int sex, char name) bob2 = bob1; // No error!

            // Our particular example leads to confusing results:
            Console.WriteLine(bob2.name); // M
            Console.WriteLine(bob2.age); // Bob
            Console.WriteLine(bob2.sex); // 23


            ValueTuple<string, int> bob11 = ValueTuple.Create("Bob", 23);
            (string, int) bob22 = ValueTuple.Create("Bob", 23);
            (string name, int age) bob3 = ValueTuple.Create("Bob", 23);

        }



    }
}
