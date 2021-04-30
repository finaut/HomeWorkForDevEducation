using System;
using System.Runtime.InteropServices;

namespace HomeWork8
{
    public class Masivator
    {
        private int[] _array;
        
        public Masivator(int sizeArray )
        { 
            _array = FullArrayRandomInt(sizeArray);
        }
        public void CurrentIndexValue(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                    Console.WriteLine($"Current index number {value} : {i}");
            }
        }
        public void Delete(int index)
        {
            if (index >= _array.Length || index < 0 )
                Console.WriteLine("Error: Index is incorrect.");
            else
                _array[index] = 0;
        }
        public void Add(int index, int value)
        {
            if (index >= _array.Length)
                Console.WriteLine("Error: no such index exists.");
            else
            {
                for (int i = 0; i < _array.Length; i++)
                    if (i == index)
                        _array[i] = value;
            }
        }
        public void Sort()
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
        }
        public void Clear()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = 0;
            }
        }
        public void Show()
        {
            Console.WriteLine($"[{string.Join(", ", _array)}]");
        }
        

        public int[] FullArrayRandomInt(int sizeArray)
        {
            Random rand = new Random();
            int[] array = new int[sizeArray];
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-100, 100);
            return array;
        }
        
    }
}