using AbstrectAndInterface.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Struct
{
    /********
     * 
     * Converting a struct to an interface causes boxing.
     * Calling an implicitly implemented member on a struct does not cause boxing:
     * 
     * ********/
    internal struct StructsToBoxing : Iinterfacesan_Boxing
    {
        public void Foo()
        {
            throw new NotImplementedException();
        }

        void Draw(BorderSide border)
        {
            

        }
    }
}
