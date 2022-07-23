using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{

    /****
     * 
     * =============== Multicast Delegates =================
     * All delegate instances have multicast capability.
     * 
     * This means that a delegate instance can reference not just a single target method, but also a list of target methods.
     * The + and += operators combine delegate instances:
     * SomeDelegate d = SomeMethod1; 
     * d += SomeMethod2;
     * The last line is functionally the same as the following:
     * d = d + SomeMethod2;
     * 
     * Invoking d will now call both SomeMethod1 and SomeMethod2. Delegates are invoked in the order in which they are added.
     * 
     * The - and -= operators remove the right delegate operand from the left delegate operand
     * 
     * d -= SomeMethod1;
     * 
     * Invoking d will now cause only SomeMethod2 to be invoked
     * 
     * Delegates are immutable, so when you call += or -=, you’re in fact creating a new delegate instance and assigning it to the existing variable
     * 
     * 
     * ****/

    public delegate void ProgressReporters(int percentComplete);
    public class  Util
    {
       public static void HardWork(ProgressReporters progressReporters)
        {
            for(int i = 0; i < 10; i++)
            {
                progressReporters(i * 100);// Invoke delegate

                System.Threading.Thread.Sleep(100); // Simulate hard work
            }
        }

        public static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }

        public static void WriteProgressToFile(int percentComplte)
        {
            System.IO.File.WriteAllText("progress.txt", percentComplte.ToString());
        }

    }
}
