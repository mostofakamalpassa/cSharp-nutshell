using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3.Inheritance
{
    internal class Stock : Asset // inherits from Asset
    {
        public override decimal Liability => 50; // Expression-bodied property

        public long SharesOwned;
    }
}
