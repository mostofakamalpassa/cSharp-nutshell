using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Enums
{
    /*****
     * 
     * You can also explicitly cast one enum type to another. 
     * Suppose that HorizontalAlignment is defined as follows
     * 
     * ****/
    internal enum HorizontalAlignment
    {
        Left = BorderSide.Left,
        Right = BorderSide.Right,
        Center
    }

    // A translation between the enum types uses the underlying integral values:

    // HorizontalAlignment h = (HorizontalAlignment) BorderSide.Right;
    // same as:
    // HorizontalAlignment h = (HorizontalAlignment)(int)BorderSide.Right;

    // There are two reasons for the special treatment of 0:

    // The first member of an enum is often used as the “default” value 

    // For combined enum types, 0 means “no flags.”


}
