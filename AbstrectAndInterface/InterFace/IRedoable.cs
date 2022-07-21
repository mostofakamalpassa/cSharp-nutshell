using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface.InterFace
{
    // ================= Extending an interface ===========================
    // Interfaces can derive from other interfaces; for instance:
    internal interface IRedoable : IUndoable
    {
        void Redo();
    }
}
