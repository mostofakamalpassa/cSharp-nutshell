using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Rectangle
    {
       

        public readonly float Width, Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;

        }

        

        /*
        * Deconstructors
        * A deconstructor (also called a deconstructing method) acts as an approximate opposite to a constructor: whereas a constructor typically takes a set of values (as parameters) and assigns them to fields, a deconstructor does the reverse and assigns fields back to a set of variables.
        * 
        * A deconstruction method must be called Deconstruct, and have one or more out parameters
        */

        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;


        }

        // The following special syntax calls the deconstructor


        //  This is called a deconstructing assignment.You can use a deconstructing
        //  assignment to simplify your class’s constructor:

        // public Rectangle(float width, float height) =>(Width, Height) = (width, height);

    }
}
