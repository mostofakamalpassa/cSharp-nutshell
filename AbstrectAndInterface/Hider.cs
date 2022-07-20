using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface
{
    internal class Hider: BaseClass
    {
        public new void Foo() { Console.WriteLine("Hider.Foo"); }
    }
}
