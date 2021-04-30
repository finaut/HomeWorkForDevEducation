using System.Collections;
using System.Collections.Generic;

namespace HomeWorkForDevEducation14
{
    public interface IDoubleLinkedList<T>
    {
        void AddLast(T value);
        void AddFist(T value);
        int IndexOf(T index);
        bool Remove(T value);
        bool Contains(T value);
        void Clear();
        int Count { get; }
        bool isEmpty { get; }
        string Show();
        IEnumerable<T> backEnumerable();
    }
    
}