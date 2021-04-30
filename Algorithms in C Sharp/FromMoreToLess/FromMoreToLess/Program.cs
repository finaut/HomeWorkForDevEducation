using System;

namespace FromMoreToLess
{
    class Program
    {
        static void SortArrayFromMoreToLess(string number)
        {
            char[] charArray = number.ToCharArray();
            foreach (int i in charArray)
            {
                Char.ToString(i);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            string ReadNumber = Console.ReadLine();
            SortArrayFromMoreToLess(ReadNumber);  
        }
    }
}
