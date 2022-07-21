using AbstrectAndInterface.Enums;
using AbstrectAndInterface.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface
{
    internal class TextBox : IUndoable
    {
        /*********
       * 
       * Implementing Interface Members Virtually An implicitly implemented interface member is, by default, sealed. It must be marked virtual or abstract in the base class in order to be overridden:
       * 
       * ********/
        public virtual void Undo() => Console.WriteLine("TextBox.Undo");

        void Draw(BorderSide border)
        {
            border.CompareTo(border);
        }
    }
}
