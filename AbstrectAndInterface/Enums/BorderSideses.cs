using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Enums
{
    [Flags]
    enum BorderSides1 { None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 }
    // or 
    internal enum BorderSideses
    {
        None = 0, Left = 1, Right = 1 << 1, Top = 1 << 2, Bottom = 1 << 3
    }

    /****
     * 
     * To work with combined enum values, you use bitwise operators such as | and &.
     * These operate on the underlying integral values:
     * 
     * ****/

    public enum BorderSides2
    {
        None = 0,
        Left = 1, Right = 1 << 1, Top = 1 << 2, Bottom = 1 << 3,
        LeftRight = Left | Right,
        TopBottom = Top | Bottom,
        All = LeftRight | TopBottom
    }

    /************
     * 
     * Enum Operators
     * = == != < > <= >= + - ^ & | ˜
     * += -= ++ -- sizeof
     * 
     * The bitwise, arithmetic, and comparison operators return the result of processing the underlying integral values.
     * Addition is permitted between an enum and an integral type, but not between two enums.
     * 
     * ************/
}
