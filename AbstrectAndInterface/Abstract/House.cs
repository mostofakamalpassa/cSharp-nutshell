using CSharpInNutShell.Chipter3.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Abstract
{
    internal class House : Asset
    {
        public override decimal NetValue => throw new NotImplementedException();
        public decimal Mortgage;
       // public   decimal Liability { get { return Mortgage; } }
        // public sealed override decimal Liability { get { return Mortgage; } }

        /*****
         * 
         * ========================= Sealing Functions and Classes ================
         * An overridden function member can seal its implementation with the sealed keyword to prevent it from being overridden by further subclasses.
         * In our earlier virtual function member example, we could have sealed House’s implementation of Liability, preventing a class that derives from House from overriding Liability, as follows
         * 
         * 
         * ****/

        public override decimal Liability => base.Liability + Mortgage;

        /*********
         * 
         * ================= The base Keyword ====================
         * 
         * The base keyword is similar to the this keyword. It serves two essential purposes
         * Accessing an overridden function member from the subclass
         * 
         * Calling a base-class constructor (see the next section)
         * With the base keyword, we access Asset’s Liability property nonvirtually.
         * This means that we will always access Asset’s version of this property—regardless of the instance’s actual runtime type
         * 
         * *******/
    }
}
