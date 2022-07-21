using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.InterFace
{
    public interface IEnumerators
    {

        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}
