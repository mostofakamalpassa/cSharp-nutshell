using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class Arrayes
    {

        public void ArrayesData()
        {
            /*
             * Arrays
             * An array represents a fixed number of variables (called elements) of aparticular type. The elements in an array are always stored in a contiguous block of memory, providing highly efficient access
             * An array is denoted with square brackets after the element type
             * 
            
             */

            char[] vowels = new char[5]; // Declare an array of 5 characters
            /*
             * Square brackets also index the array, accessing a particular element by position:
             * 
             */
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            Console.WriteLine(vowels[1]); // e

            for (int i = 0; i < vowels.Length; i++)
                Console.Write(vowels[i]); // aeiou

            /*
             * An array initialization expression lets you declare and populate an array in a single step
             * 
             */

            char[] vowels1 = new char[] { 'a', 'e', 'i', 'o', 'u' };
            // Or simply:
            char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' };

            /*
             * All arrays inherit from the System.Array class, providing common services for all arrays. These members include methods to get and set elements regardless of the array type.
             */
        }
    }
}
