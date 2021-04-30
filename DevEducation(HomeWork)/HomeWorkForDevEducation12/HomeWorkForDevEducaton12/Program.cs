using System;
using System.Collections;

namespace HomeWorkForDevEducaton12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyArrayList myArrayList = new MyArrayList();
            myArrayList.Add(4);
            myArrayList.Add(7);
            myArrayList.Add(12);
            myArrayList.Add(8);

            object[] array = new object[3];
            myArrayList.CopyTo(array, 0);
            foreach (var value in array )
                Console.WriteLine(value);
        }
    }
}