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
    }
}
