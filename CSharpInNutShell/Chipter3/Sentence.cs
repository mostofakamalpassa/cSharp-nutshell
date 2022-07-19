using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Sentence
    {

        // ------------------Implementing an indexer -------------------------

        /*
         * To write an indexer, define a property called this, specifying the arguments in square brackets:
        
         */

        string[] words = "The quick brown fox".Split();

        public string this [int inWord]
        {
            get { return words [inWord]; }
            set { words [inWord] = value; } 
        }


        //----------- Using indices and ranges with indexers -------------------

        /* 
         * 
         * You can support indices and ranges in your own classes by defining an indexer with a parameter type of Index or Range.
         * We could extend our previous example, by adding the following indexers to the Sentence class: 
         * 
         */

        public string this[Index index] => words[index];
        public string[] this[Range range] => words[range];


    }
}
