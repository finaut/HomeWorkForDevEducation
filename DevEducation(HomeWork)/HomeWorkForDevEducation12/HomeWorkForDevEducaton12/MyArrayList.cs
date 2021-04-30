using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWorkForDevEducaton12
{
    public class MyArrayList : IList
    {

        
        private object[] _array = new object[0];

        public int Count => _array.Length;

        public bool IsFixedSize => true;
        public bool IsReadOnly => false;
        public bool IsSynchronized => false;
        public object SyncRoot => this;

        public object this[int index]
        {
            get => _array[index];
            set => _array[index] = (int) value;
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

        public int Add(object value)
        {
            object[] newArr = new object[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
                newArr[i] = _array[i];
            newArr[newArr.Length - 1] = value;
            _array = newArr;
            return _array.Length;
        }
        public string Show => $"[{string.Join(", ", _array)}]";
        
        public bool Contains(object value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if ((int) _array[i] == (int) value)
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if ((int)value ==(int)_array[i])
                {
                    return i;
                    break;
                }
            }
            throw new ArgumentException("Error: no value found in array ");
        }
        public void Insert(int index, object value)
        {
            if ((index < 0) ||  (index > _array.Length))
            {
                throw new ArgumentException("Error: no such index exists.");
            }
            else
            {
                _array[index] = value;
            }
        }
        public void Clear()
        {
            object[] newArray = new object[0];
            _array = newArray;
        }
        public void Remove(object value)
        {
            int count = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if ((int)_array[i] == (int) value)
                    count++;                
            }
            
            if (count == 0)
            {
                throw new ArgumentException("Error: there is no such value in the array.");
            }
            
            for (int i = 0; i < count; i++)
                RemoveAt(IndexOf(value));
        }
        public void RemoveAt(int index)
        {
            if ((index > _array.Length) || (index < 0))
            {
                throw new ArgumentException("Error: no such index exists.");
            }
            else
            {
                object[] newArray = new object[_array.Length - 1];
                for (int i = 0; i < index; i++)
                    newArray[i] = _array[i];
                for (int i = index + 1; i < _array.Length; i++)
                    newArray[i - 1] = _array[i];
                _array = newArray;
            }
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < _array.Length && i + index < array.Length; i++)
                array.SetValue(_array[i], i);
        }

        public void BubbleSortBigSmall()
        {
            for(int i = 0; i < _array.Length - 1; i++)
                for (int j = 0; j < _array.Length - 1; j++)
                    if ((int) _array[j] < (int) _array[j + 1])
                    {
                        object temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
        }
        
        public void BubbleSortSmallBig()
        {
            for(int i = 0; i < _array.Length - 1; i++)
                for (int j = 0; j < _array.Length - 1; j++)
                    if ((int) _array[j] > (int) _array[j + 1])
                    {
                        object temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
        }

        public void Revers()
        {
            object[] newArray = new object[_array.Length];
            int ind = 0;
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                newArray[ind] = _array[i];
                ind++;
            }
            _array = newArray;
        }
    }
}