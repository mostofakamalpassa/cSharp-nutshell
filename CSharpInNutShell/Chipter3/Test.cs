using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Test
    {

        string name;
        // The this reference also disambiguates a local variable or parameter from a field
        public Test(string name) { this.name = name; }

        //The this reference is valid only within nonstatic members of a class or struct.

    }
}
