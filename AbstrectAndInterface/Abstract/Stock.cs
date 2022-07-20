using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3.Abstract
{
    internal class Stock : Asset
    {
        public long SharesOwned;
        public decimal CurrentPrice;

        public decimal A { get; init; }

        public override decimal NetValue => SharesOwned * CurrentPrice;

        public Stock()
        {
            A = 56;
        }
    }
}
