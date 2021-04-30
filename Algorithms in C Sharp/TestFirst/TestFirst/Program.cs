using System;

namespace TestFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * int - значение
             * string - ссылочные
             * boolean - значение
             * char - значение 
             * object - ссылочное
             * Console.WriteLine(
             */

            //int a = 8;
            //Console.WriteLine(a);
            //Console.ResetColor(blue);
            //int b = ++a;
            //Console.WriteLine(b);
            //Console.WriteLine(a);
            //int c = a++;

            //Console.WriteLine(c);

            //var pleaseText = "Please,  Entry you name";
            //Console.WriteLine(pleaseText);
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            //Console.WiteLine("Please, Entry you age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //age = age * 100;
            //Console.WriteLine("Age: " + age);

            //Console.WriteLine("Please, Entry 3 number: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());


            //int FirstSum = (int)(a + b + c);
            //int SecondSum = (int)(a * b / c);
            //int ThreeSum = (int)(a % b);

            //Console.WriteLine("===============");
            //Console.WriteLine($"First sum ({a} + {b} + {c}): " + FirstSum);
            //Console.WriteLine($"Second sum ({a} * {b} / {c}): " + SecondSum);
            //Console.WriteLine($"Three sum ({a} % {b} ): " + ThreeSum);

            Console.WriteLine("Please, Entry first number: ");
            double  firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Entry first number: ");
            double secondNumber = double.Parse(Console.ReadLine());


        }
    }
}
