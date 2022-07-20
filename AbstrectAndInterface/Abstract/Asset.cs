using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3.Abstract
{
    internal abstract class Asset
    {

        /***
         * 
         * ============== Abstract Classes and Abstract Members ===============
         * A class declared as abstract can never be instantiated. Instead, only its concrete subclasses can be instantiated
         * 
         * Abstract classes are able to define abstract members. Abstract members are like virtual members except that they don’t provide a default implementation. That implementation must be provided by the subclass unless that subclass is also declared abstract:
         * 
         * 
         * ***/

        // Note empty implementation
        public abstract decimal NetValue { get; }
     

    }
}
