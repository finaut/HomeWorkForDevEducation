using System;

namespace HomeWorkForDevEducation14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyDoubleLinkedList array = new MyDoubleLinkedList(new int[] {2, 4, 6, 8, 10});
            Console.WriteLine(array.Show());
            Console.WriteLine(array.Show());
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine( array.Length);

        }
    }
}