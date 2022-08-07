using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.GenericCollection
{
    internal class IEnumariblesAndOtherGeneric
    {


        public void OtherGeneric()
        {
           IEnumerable<int> enumerator = new List<int>() { 2,3,4,5,6,7,8,9};

            
            var convertToEnumeratorData = enumerator.GetEnumerator();

            while (convertToEnumeratorData.MoveNext())
            {
                Console.WriteLine(convertToEnumeratorData.Current);
            }
            
        }

        public static int Count(IEnumerable e)
        {

            int count = 0;
            foreach(object element in e)
            {
                var subCollection = element as IEnumerable;
                if(subCollection != null)
                {
                    count += Count  (subCollection);
                } else count++;


               
            }
            return count;
        }

        
    }
}
