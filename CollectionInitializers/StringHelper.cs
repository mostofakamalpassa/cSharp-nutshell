using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers
{
    /*****
     * 
     * ================= Extension Methods ====================
     * Extension methods allow an existing type to be extended with new methods without altering the definition of the original type. 
     * An extension method is a static method of a static class, where the this modifier is applied to the first parameter.
     * The type of the first parameter will be the type that is extended:
     * 
     * 
     * 
     * *********/
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }


        public static T First<T>(this IEnumerable<T> sequence)
        {
            foreach (T element in sequence)
                return element;
            throw new InvalidOperationException("No elements!");
        }

        // Extension Method Chaining

        // Extension methods, like instance methods, provide a tidy way to chain functions.Consider the following two functions:

        public static string Pluralize(this string s) { return s; }
        public static string Capitalize(this string s) { return s; }

    }

    // Extension methods versus instance methods

/******
 * 
 * Any compatible instance method will always take precedence over an extension method.
 * In the following example, Test’s Foo method will always take precedence, even when called with an argument x of type int:

    *****/
}
