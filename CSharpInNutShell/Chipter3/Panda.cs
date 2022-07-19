﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Panda
    {
        string name; // Define field
        //Instance constructors allow the following modifiers:

        public Panda(string n) // Define constructor
        {
            name = n; // Initialization code (set up field)

        }

        // Access modifiers public internal private protected
        // Unmanaged code modifiers unsafe extern
        // public Panda(string n) => name = n;

        // Overloading constructors

        /*
         * A class or struct may overload constructors.
         * To avoid code duplication, one constructor can call another, using the this keyword
         * 
         */
    }
}
