using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.InterFace
{
    /***
     * 
     * you can add a default implementation to an interface member, making it optional to implement:
     * 
     * ****/
    internal interface ILogger
    {
        static string Prefix = "";
        void Log(string text) => Console.WriteLine(text);

        /****
         * 
         * This is advantageous if you want to add a member to an interface defined in a popular library without breaking (potentially thousands of) implementations. Default implementations are always explicit, so if a class implementing ILogger fails to define a Log method, the only way to call it is through the interface:
         * 
         * ****/
    }
}
