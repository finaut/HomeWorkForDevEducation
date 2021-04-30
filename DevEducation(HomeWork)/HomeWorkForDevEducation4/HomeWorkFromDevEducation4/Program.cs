using System;

namespace HomeWorkFromDevEducation4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
        }
        public static void Task2()
        {
            // 2.Пользователь вводит 1 число(A).
            // Найдите количество положительных целых чисел, квадрат которых меньше A.

            bool cont = true;
            do
            {
                int iter = 0;
                long number;
                Console.WriteLine("Please entry your number: ");
                bool input = long.TryParse(Console.ReadLine(), out number);
                if (input != true)
                {
                    Console.WriteLine("Error: please entry correct number.");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Error: impossible.");
                }
                else
                {
                    for (int i = 1; i <= number; i++)
                    {
                        if ((i * i) > number)
                        {
                            iter = i;
                            break;
                        }
                    }
                    Console.WriteLine($"largest root value: {iter - 1}");
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        public static void Task1()
        {
            // 1.Пользователь вводит 2 числа(A и B).
            // Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
            // (Учтите, что при вводе B может оказаться меньше A).
            // Я оставил с отрдательным значением так как мож  кому-то  пригодится.


            bool cont = true;
            do
            {
                int a;
                int b;
                int sum = 0;

                Console.WriteLine("Please entry number A:");
                bool input1 = int.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Entry number B:");
                bool input2 = int.TryParse(Console.ReadLine(), out b);

                if ( input1 != true && input2 != true)
                    Console.WriteLine("Error: number not correct(most be like: 1000, 432).");
                else
                {
                    if (a > b)
                    {
                        int c = b;
                        b = a;
                        a = c;
                    }
                    for ( int i = a; i <= b; i++ )
                    {
                        if (i % 7 == 0)
                            sum += i;
                    }
                    Console.WriteLine($"Current sum all number: {sum}");
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        public static bool WontContinue(bool cont)
        {
            Console.WriteLine("Do you want to continue ? (y/n)");
            string choiceContinue = Console.ReadLine();
            choiceContinue = choiceContinue.Replace(" ", "");
            if (choiceContinue != "y" && choiceContinue != "Y")
                cont = false;
            Console.WriteLine("=================");
            return cont;
        }
    }
}
