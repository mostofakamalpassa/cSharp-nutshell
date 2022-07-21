using AbstrectAndInterface.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrectAndInterface
{
    internal class Countdown : IEnumerators
    {

        int count = 11;
        public object Current => count;

        public bool MoveNext()
        {
          if(count > 0)
            {
               count--;
                return true;
            };
            return false;
           
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
