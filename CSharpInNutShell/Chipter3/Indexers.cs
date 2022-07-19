using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Indexers
    {

        /**
         * 
         * Indexers provide a natural syntax for accessing elements in a class or struct that encapsulate a list or dictionary of values. 
         * 
         * Indexers are similar to properties but are accessed via an index argument rather than a property name. 
         * 
         * The string class has an indexer that lets you access each of its char values via an int index:
         * 
         * 
         * */

        public void IndexserString()
        {

            string name = "hello kamal";
            Console.WriteLine(name[0]);


            string s = null;
            Console.WriteLine(s?[0]); // Writes nothing; no error.

        }


        /**
         * 
         * The syntax for using indexers is like that for using arrays, except that the index argument(s) can be of any type(s). Indexers have the same modifiers as properties
         * 
         * 
         * and can be  called null-conditionally by inserting a question mark before the square bracket
         * */


        /**
          * 
          * A type can declare multiple indexers, each with parameters of different types. 
          * An indexer can also take more than one parameter:
          * 
          * 
          * */

        public string this[int arg1, string arg2]
        {
            get { return arg2; }
            set { arg2 = value; }
        }


        // If you omit the set accessor, an indexer becomes read-only, and you can use expression-bodied syntax to shorten its definition:
        string[] words = { "This is words" };
        public string this[int wordNums] => words[wordNums];


        // CLR indexer implementation

        // Indexers internally compile to methods called get_Item and set_Item, as follows:

        //  public string get_Item(int wordNum) { ...}
        //  public void set_Item(int wordNum, string value) { ...}




    }
}
