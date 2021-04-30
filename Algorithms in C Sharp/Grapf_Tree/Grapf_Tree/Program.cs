using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    class Program
    {
        // Recursiv funtion
        static int Factorial(int number)
        {
            int result;

            if (number == 1)
            {
                return 1;
            }
            result = Factorial(number - 1) * number;
            return result;
        }

        static void Main(string[] args)
        {
            label1:
            Console.WriteLine("Entry number: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}! = {1}",i,Factorial(i));
            }
            catch (FormatException)
            {
                Console.WriteLine("Not correct number.");
                goto label1;
            }
            finally
            {
                Console.WriteLine("All okey.");
            }
            Console.ReadLine();
        }
    }
}
