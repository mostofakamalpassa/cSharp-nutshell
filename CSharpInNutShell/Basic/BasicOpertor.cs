using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class BasicOpertor
    {

        public void Arithmetic()
        {

            /*
             *  + Addition
                - Subtraction
                * Multiplication
                / Division
                % Remainder after division

            */
        }


        public void IncrementAdnDecrementOparator()
        {
            /*
             * (++, --, respectively)
             * 
             */
        }


        public void OverFlowCheackOperator()
        {

            /*
                The checked operator instructs the runtime to generate an
OverflowException rather than overflowing silently when an integral-type
expression or statement exceeds the arithmetic limits of that type
             */
            int a = 1000000;
            int b = 1000000;
            int c = checked(a * b); // Checks just the expression.
            checked // Checks all expressions
            { // in statement block.

                c = a * b;

            }
        }

        public void BooleanConversion()
        {
            int x = 1;
            int y = 2;
            int z = 1;
            Console.WriteLine(x == y); // False
            Console.WriteLine(x == z); // True

            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2); // False
            Dude d3 = d1;
            Console.WriteLine(d1 == d3); // True

            /*
             * The equality and comparison operators, ==, !=, <, >, >=, and <=, work for all
numeric types, but you should use them with caution with real numbers (as
we saw in “Real Number Rounding Errors”).
            */


        }

        static bool UseUmbrella(bool rainy, bool sunny, bool windy)
        {
            /*
             
                The && and || operators test for and and or conditions. They are frequently
used in conjunction with the ! operator, which expresses not.
             */
            return !windy && (rainy || sunny);

            /*
             * 
             *  The && and || operators short-circuit evaluation when possible. In the
preceding example, if it is windy, the expression (rainy || sunny) is not
even evaluated.
             */

        }

        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }


        public int TernaryOperator(int a, int b)
        {
            /*
             The conditional operator (more commonly called the ternary operator
because it’s the only operator that takes three operands) has the form q ? a
: b; thus, if condition q is true, a is evaluated, else b is evaluated:
             */

            return (a > b) ? a : b;
        }


        public void Characters()
        {
            /*
                C#’s char type (aliasing the System.Char type) represents a Unicode
character and occupies 2 bytes (UTF-16). A char literal is specified within
single quotes: 

             */

            char c = 'A'; // Simple character

            /*
                Escape sequences express characters that cannot be expressed or interpreted
literally. An escape sequence is a backslash followed by a character with a
special meaning; for example: 

             */
            char newLine = '\n';
            char backSlash = '\\';
            /*
             * \' Single quote 0x0027
             * \" Double quote 0x0022
             * \\ Backslash 0x005C
             * \0 Null 0x0000
             * \a Alert 0x0007
             * \b Backspace 0x0008
             * \f Form feed 0x000C
             * \n New line 0x000A
             * \r Carriage return 0x000D
             * \t Horizontal tab 0x0009
             * \v Vertical tab 0x000B
             * 
             */

        }






    }


    public class Dude
    {
        public string Name;
        public Dude(string n) { Name = n; }
    }
}
