using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class MultidimensionalArrays
    {

        /*
         * 
         * Multidimensional arrays come in two varieties: rectangular and jagged. Rectangular arrays represent an n-dimensional block of memory, and jagged arrays are arrays of arrays.
         * 
         * 
         */


        public void RectangularArray()
        {
            /*
             * Rectangular arrays are declared using commas to separate each dimension
             */

            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;

            /*
             * You can initialize a rectangular array with explicit values.
             */

            int[,] matrixs = new int[,]{
                                            {0,1,2},
                                            {3,4,5},
                                            {6,7,8}
                                        };
        }
        public void JaggedArrays()
        {

            /*
             * Jagged arrays are declared using successive square brackets to represent each dimension.
             * 
             */

            int[][] matrix = new int[3][];

            /*
             * The inner dimensions aren’t specified in the declaration because, unlike a rectangular array, each inner array can be an arbitrary length. Each inner array is implicitly initialized to null rather than an empty array
             * 
             */

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3]; // Create inner array
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = i * 3 + j;
            }


            /*
             * You can initialize a jagged array with explicit values
             * 
             */

            int[][] matrixs = new int[][] {
                                            new int[] {0,1,2},
                                            new int[] {3,4,5},
                                            new int[] {6,7,8,9}
                                            };
        }



        public void ArrayInitializationExpressions()
        {
            /*
             * There are two ways to shorten array initialization expressions. The first is to omit the new operator and type qualifications
             * 
             */

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int[,] rectangularMatrix =
                            {
                            {0,1,2},
                            {3,4,5},
                            {6,7,8}
                            };

            int[][] jaggedMatrix =
                                    {
                                    new int[] {0,1,2},
                                    new int[] {3,4,5},
                                    new int[] {6,7,8,9}
                                    };

            /*
             * The second approach is to use the var keyword, which instructs the compiler to implicitly type a local variable
             * 
             * 
             */


            var i = 3; // i is implicitly of type int
            var s = "sausage"; // s is implicitly of type string
                               // Therefore:
            var rectMatrix = new int[,] // rectMatrix is implicitly of type int[,]
                            {
                                    {0,1,2},
                                    {3,4,5},
                                    {6,7,8}
                            };
            var jaggedMat = new int[][] // jaggedMat is implicitly of type int[][]
                                        {
                                        new int[] {0,1,2},
                                        new int[] {3,4,5},
                                        new int[] {6,7,8,9}
                                        };
        }
    }
}
