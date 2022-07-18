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


        public void StringType()
        {
            /*
             * aliasing the System.String
             * represents an immutable (unmodifiable) sequence of Unicode characters. 
             * A string literal is specified within double quotes:
             * string is a reference type rather than a value type.
             *  Its equality operators, however, follow valuetype semantics:
             */

            string a = "Heat";
            string b = "test";
            Console.Write(a == b); // False

            /*
             * The escape sequences that are valid for char literals also work inside
             * 
             * 
             */
            string d = "Here's a tab:\t";
            string a1 = "\\\\server\\fileshare\\helloworld.cs";
            string a2 = @"\\server\fileshare\helloworld.cs";
            /*
             * A verbatim string literal is prefixed with @ and does not support escape sequences
             * A verbatim string literal can also span multiple lines:
             */

            string escaped = "First Line\r\nSecond Line";
            string verbatim = @"First Line Second Line";
            string xml = @"<customer id=""123""></customer>";

            /*
             * Sring Concatination
             * The + operator concatenates two strings:
             * One of the operands might be a nonstring value, in which case ToString() is called on that value
             * System.Text.StringBuilder
             * 
             */
            string s = "a" + "b";

            /*
             * String interpolation
             * A string preceded with the $ character is called an interpolated string. Interpolated strings can include expressions enclosed in braces
             * 
             * Any valid C# expression of any type can appear within the braces, and C# will convert the expression to a string by calling its ToString method or equivalent.
             */


            int x = 4;
            Console.Write($"A square has {x} sides"); // Prints: A square has 4 sides
            string s2 = $"255 in hex is {byte.MaxValue:X2}"; // X2 = 2-digit hexadecimal
                                                             // Evaluates to "255 in hex is FF"
            bool bb = true;
            Console.WriteLine($"The answer in binary is {(bb ? 1 : 0)}");

            /*
             * Interpolated strings must complete on a single line, unless you also specify the verbatim string operator:
             * 
             * To include a brace literal in an interpolated string, repeat the desired brace character.
             * 
             */

            int x3 = 2;
            // Note that $ must appear before @ prior to C# 8:
            string s3 = $@"this interpolation spans {
            x3} lines";
        }





    }


    public class Dude
    {
        public string Name;
        public Dude(string n) { Name = n; }
    }
}
