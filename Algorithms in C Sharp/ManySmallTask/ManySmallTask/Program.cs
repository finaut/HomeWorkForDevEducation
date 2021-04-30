using System;

namespace ManySmallTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task  first
            // если пользователь велл  10 то верно остальное не верно 

            //int number;
            //Console.WriteLine("Please, entry number 10: ");
            //var input = Console.ReadLine();
            //var result = int.TryParse(input, out number);
            //if (result == true )
            //{
            //    if (number == 10)
            //    {
            //        Console.WriteLine($"Current number: {number} == 10");
            //    } else
            //    {
            //        Console.WriteLine($"Current number: {number} != 10");
            //    }
            //} else
            //{
            //    Console.WriteLine("Program entry error.");
            //}


            // Task second
            // В переменной min лежит число от 0 до 59.
            // Определите в какую четверть часа попадает это число
            // (в первую, вторую, третью или четвертую).

            int number;
            Console.WriteLine("Entry current value minuts: ");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out number);
            if (number < 0)
            {
                
            }
        }
    }
}
