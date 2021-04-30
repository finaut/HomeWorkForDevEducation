using System;
using System.Runtime.InteropServices;

namespace HomeWork8
{
    public class Masivator
    {
        private int[] _array;
        
        public Masivator()
        {
            _array = new int[] {1, 2, -3, 7, -4, 12, 8, 9};
        }

        public int GetValueByIndex(int index)
        {
            if (index >= _array.Length || index < 0 )
                throw new ArgumentException("Error: This index is missing");
            else
                return _array[index];
        }
        public int CurrentIndexValue(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value) 
                    return i;
            }
            throw new ArgumentException("Error: This value is missing");
        }
        public int Delete(int index)
        {
            if (index >= _array.Length || index < 0)
                throw new ArgumentException("Error: No such index exists");
            else
                return _array[index] = 0;
        }
        public int Add(int index, int value)
        {
            if (index >= _array.Length || index < 0)
                throw new ArgumentException("Error: no such index exists.");
            else
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (i == index)
                    {
                        return _array[i] = value;
                    }
                }     
            }
            throw new Exception("Try to enter the values again.");
        }
        public int[] Sort()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < _array.Length; j++)
                    if (_array[j] < _array[min])
                        min = j;
                
                int dummy = _array[i];
                _array[i] = _array[min];
                _array[min] = dummy;
            }
            return _array;
        }
        public int[] Clear()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = 0;
            }
            return _array;
        }
    }
}