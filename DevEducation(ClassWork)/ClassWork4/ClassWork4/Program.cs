using System;

namespace ClassWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            // пользователь воодит 2 числа посчитать с  помощью алгоритм эвклида
            //Evclid();
            Console.WriteLine(Fibonacci(10));
        }
        static private int Fibonacci(int n)
        {
            if (n < 3)
                return 1;
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
        static private void Evclid()
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Entry first number: ");
            bool input1 = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Entry second number: ");
            bool input2 = int.TryParse(Console.ReadLine(), out secondNumber);
            if (input1 == true && input2 == true)
            {
               while ( firstNumber != 0 && secondNumber != 0)
                {
                    if ( firstNumber > secondNumber)
                    {
                        firstNumber = firstNumber % secondNumber;
                    } else
                    {
                        secondNumber = secondNumber % firstNumber;
                    }
                }
                Console.WriteLine(firstNumber + secondNumber);
            }
            else
            {
                Console.WriteLine("Error: not correct number.");
            }

        }
        static private void sss()
        {
            bool cont = true;
            do
            {
                int number;
                Console.WriteLine("Entry number: ");
                string integerText = Console.ReadLine();
                if (!int.TryParse(integerText, out number))
                {
                    Console.WriteLine("Error: entry correct number");
                }
                else
                {
                    if (IsPrimare(number) == true)
                    {
                        Console.WriteLine($"Number {number} not prime.");
                    }
                    else
                    {
                        Console.WriteLine($"Number {number} nprime.");
                    }
                    Console.WriteLine("Wont continue ? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer != "y")
                        cont = false;
                }

            } while (cont);
        }
        static private bool IsPrimare(int number)
        {
            if ( number < 2)
            {
                return false;
            } else
            {
                int value = number / 2;
                for (int i = 2; i <= value; i++)
                {
                    if (number % i == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
