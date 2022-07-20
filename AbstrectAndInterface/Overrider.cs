using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface
{
    internal class Overrider : BaseClass
    {
        public override void Foo() { Console.WriteLine("Overrider.Foo"); }
    }
}
