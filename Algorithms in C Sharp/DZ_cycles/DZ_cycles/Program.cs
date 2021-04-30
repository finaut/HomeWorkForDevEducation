using System;
using System.Collections.Generic;

namespace DZ_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please entry number: ");
            string input = Console.ReadLine();
            List<int> array = new List<int>();

            for ( int i = 0; i < input.Length; i++ )
            {
                string currentString = Convert.ToString(input[i]);
                int currentNumber = Convert.ToInt32(currentString);
                array.Add(currentNumber);
                Console.WriteLine(input[i]);
            }
            int firstNumber;
            int mostBigNumber = 0;
            foreach (int i in array)
            {
                firstNumber = i;
                if (mostBigNumber < firstNumber) 
                {
                    mostBigNumber = firstNumber;
                }
            }
            Console.WriteLine($"{mostBigNumber} it`s most big number");
        }
    }
}
