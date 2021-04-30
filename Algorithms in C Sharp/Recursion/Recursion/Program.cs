using System;

namespace Recursion
{
    class Program
    {
        static int AddOneNumber(int number)
        {
            if (number > 5)
            {
                return number;
            }
            Console.WriteLine(number);
            return AddOneNumber(number + 1);
        }
        static void Main(string[] args)
        {
            AddOneNumber(1);   
        }
    }
}
