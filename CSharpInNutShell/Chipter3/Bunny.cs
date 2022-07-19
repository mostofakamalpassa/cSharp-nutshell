using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Bunny
    {

        /*
         * 
         * Object Initializers
         * 
         * To simplify object initialization, any accessible fields or properties of an object can be set via an object initializer directly after construction. 
               For example, consider the following class:
         * 
         * 
         * 
         */


        public string Name;
        public bool LikeCarrots;
        public bool LikeHumans;

        public Bunny() { }
        public Bunny(string name)
        {
            Name = name;
        }

        public Bunny(string name, bool likesCarrots = false, bool likesHumans = false)
        {
            Name = name;
            LikeCarrots = likesCarrots;
            LikeHumans = likesHumans;
        }

    }
}
