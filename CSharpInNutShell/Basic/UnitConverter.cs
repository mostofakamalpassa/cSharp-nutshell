using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Basic
{
    internal class UnitConverter
    {
        int ratio; // Field  or variable or property

        public UnitConverter(int unitRatio ) //  Constructor 
        {
            ratio = unitRatio;
        }

        public int Convert(int unit)
        {
            return ratio * unit;
        }
    }
}
