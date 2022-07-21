using AbstrectAndInterface.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface
{
    internal class RichTextBox: TextBox, IUndoable
    {
        /*********
         * 
         * Calling the interface member through either the base class or the interface calls the subclass’s implementation:
         * 
         * ********/


        // public override void Undo() => Console.WriteLine("RichTextBox.Undo");




        /****
         * 
         *============= Reimplementing an Interface in a Subclass ============== 
         *
         *A subclass can reimplement any interface member already implemented by a base class.
         * Reimplementation hijacks a member implementation (when called through the interface) and works whether or not the member is virtual in the base class. 
         * 
         * It also works whether a member is implemented implicitly or explicitly—although it works best in the latter case, as we will  demonstrate. 
         * In the following example, TextBox implements IUndoable.Undo explicitly, and so it cannot be marked as virtual.
         * To “override” it, RichTextBox must reimplement IUndoable’s Undo method:
         * 
         * 
         * ***/

        public void Undo() => Console.WriteLine("RichTextBox.Undo");
    }
}
