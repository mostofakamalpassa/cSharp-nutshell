using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInitializers.Nullable
{
    public struct Nullable<T> where T : struct
    {
        public T Value { get; set; }
        public bool HasValue { get; }
        //public T GetValueOrDefault();
        public T GetValueOrDefault()
        {
            return Value;
        }
        //public T GetValueOrDefault(T defaultValue);
        public T GetValueOrDefault(T defaultValue)
        {
            return defaultValue;
        }

        /*************
         * 
         * Attempting to retrieve Value when HasValue is false throws an InvalidOperationException. GetValueOrDefault() returns Value if HasValue is true; otherwise, it returns new T() or a specified custom default value.
         * 
         * 
         * The default value of T? is null.
         * ***********/

    }
}
