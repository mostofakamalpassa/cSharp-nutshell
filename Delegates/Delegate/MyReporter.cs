using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{
    public delegate void ProgressReporter(int percentComplete);

    /***
     * 
     * When an instance method is assigned to a delegate object, the latter maintains a reference not only to the method, but also to the instance to which the method belongs.
     * 
     * The System.Delegate class’s Target property represents this instance (and will be null for a delegate referencing a static method).
     * 
     * Because the instance is stored in the delegate’s Target property, its lifetime is extended to (at least as long as) the delegate’s lifetime.
     * 
     * ****/
    public class MyReporter
    {
       
        public string Prefix = "";

        public void ReportProgress(int percentComplete)
        {
            Console.WriteLine(Prefix + percentComplete);
        }
    }
}
