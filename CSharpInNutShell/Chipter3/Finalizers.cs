using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Finalizers
    {

        /*****
         * 
         * Finalizers are class-only methods that execute before the garbage collector reclaims the memory for an unreferenced object. 
         * 
         * The syntax for a finalizer is the name of the class prefixed with the ~ symbol:
         * 
         * *****/
        ~Finalizers() { }

    }
}
