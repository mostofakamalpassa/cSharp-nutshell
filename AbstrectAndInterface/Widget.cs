using AbstrectAndInterface.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface
{
    public class Widget : I1, I2
    {

        /***
         * 
         * ============= Explicit Interface Implementation ================
         * Implementing multiple interfaces can sometimes result in a collision between member signatures. 
         * You can resolve such collisions by explicitly implementing an interface member.
         * 
         * 
         * ***/
        public int Foo()
        {
            throw new NotImplementedException();
        }

        void I2.Foo()
        {
            throw new NotImplementedException();
        }

        /***********
         * 
         * Because I1 and I2 have conflicting Foo signatures, Widget explicitly implements I2’s Foo method. 
         * This lets the two methods coexist in one class.
         * The only way to call an explicitly implemented member is to cast to its interface
         * 
         * **********/
    }
}
