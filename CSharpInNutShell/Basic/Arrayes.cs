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


        public void ArrayIndiceAndRange()
        {

            /*
             * Indices and ranges working with elements or portions of an array.
             * Indices
             * Indices let you refer to elements relative to the end of an array, with the ^ operator. ^1 refers to the last element, ^2 refers to the second-to-last element, and so on
             * 
             * 
             */

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char lastElement = vowels[^1]; // 'u'
            char secondToLast = vowels[^2]; // 'o'

            /*
             * implements indices with the help of the Index type, so you can also do the following
             * 
             */

            Index first = 0;
            Index last = ^1;
            char firstElement1 = vowels[first]; // 'a'
            char lastElement1 = vowels[last]; // 'u'
        }


        public void ArrayRange()
        {

            /*
             * Ranges
             * Ranges let you “slice” an array by using the .. operator
             */
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            char[] firstTwo = vowels[..2]; // 'a', 'e'
            char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
            char[] middleOne = vowels[2..3]; // 'i'

            /*
             * The second number in the range is exclusive, so ..2 returns the elements before vowels[2].
             * 
             * You can also use the ^ symbol in ranges. The following returns the last two characters:
             */
            char[] lastTwo = vowels[^2..]; // 'o', 'u'

            Range firstTwoRange = 0..2;
            char[] firstTwos = vowels[firstTwoRange]; // 'a', 'e'
        }
    }
}
