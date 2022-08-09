using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Interface
{
    internal interface ICollections<T> : IEnumerable<T>,IEnumerable
    {
        int Count { get; }
        bool IsReadOnly { get; }
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex);
        void CopyTo(T[] array, int arrayIndex, int count);
        void Add(T item);
        void Clear();
        bool Remove(T item);

    }


    public interface ICollection : IEnumerable
    {
        int Count { get; }
        bool IsSynchronized { get; }
        object SyncRoot { get; }
        void CopyTo(Array array, int index);
    }

    public interface IList<T>: IEnumerable<T>, IEnumerable, ICollection<T>
    {
        T this [int index] { get; set; }
       int IndexOf(T item);
        int IndexOf(T item, int index);
        void Insert(int index, T item);
        void RemoveAt(int index);
        void RemoveAt(int index, int count);

    }

    public interface IList : ICollection, IEnumerable
    {
        Object this [int index] { get; set; }
        bool IsFixedSize { get; }
        bool IsReadOnly { get; }
        void Add(object item);
        void Clear();
        void Insert(int index, object item);
        bool Remove(object item);
        bool RemoveAt(int index, int count);
        int IndexOf(object item);
        int IndexOf(object item, int count);

    }


    public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }
    }
    public interface IReadOnlyList<out T> : IReadOnlyCollection<T>,
    IEnumerable<T>, IEnumerable
    {
        T this[int index] { get; }
    }
}
