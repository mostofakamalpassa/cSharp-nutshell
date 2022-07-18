using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class Foo
    {
        System.Text.StringBuilder sb;

        public Foo(string initialize)
        {
            sb = new (initialize);
        }

        /*
         * Target-typed new expressions are also helpful in the following scenario:
         * MyMethod (new ("test"));
         * void MyMethod (System.Text.StringBuilder sb) { ... } 
         * 
         */
    }
}
