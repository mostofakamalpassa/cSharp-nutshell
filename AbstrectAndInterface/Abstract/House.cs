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
        public   decimal Liability { get { return Mortgage; } }
       // public sealed override decimal Liability { get { return Mortgage; } }
    }
}
