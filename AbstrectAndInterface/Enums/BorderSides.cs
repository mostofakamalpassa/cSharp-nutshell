using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.Enums
{
    [Flags]
    internal enum BorderSides:byte
    {
        Left = 1, Right =2, Top =3, Bottom =10
    }
}
