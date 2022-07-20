using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3.Inheritance
{
    internal class House : Asset // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage;

        /**
         * 
         * The signatures, return types, and accessibility of the virtual and overridden methods must be identical. An overridden method can call its base class implementation via the base keyword (we cover this in “The base Keyword”).
         * 
         * **/
    }
}
