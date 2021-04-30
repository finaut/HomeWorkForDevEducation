using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplicationOfKaratsuba
{
    class Program
    {
        static List<string> SplitString(string str)
        {
            List<string> list = new List<string>();
            int i = 0;
            while (i < str.Length - 1)
            {
                list.Add(str.Substring(i, 2));
                i += 2;
            }
            return list;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, it`s simple calculate witch using algoritm Kararsuba");
            Console.WriteLine("Entry first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Entry second number: ");
            string secondNumber = Console.ReadLine();

            List<string> list1 = SplitString(firstNumber);
            List<string> list2 = SplitString(secondNumber);
            int a, b, c, d;
            // сделать рефакторинг и переписать это все в метод 
            for ( int i = 0; i < list1.Count; i++ )
            {
                if (i == 0)
                {
                    a = Convert.ToInt32(list1.ElementAt(i));
                    Console.WriteLine(a);
                }
                else
                {
                    b = Convert.ToInt32(list1.ElementAt(i));
                    Console.WriteLine(b);
                }
            }
            for ( int i = 0;  i < list2.Count;  i++ )
            {
                if (i == 0)
                {
                    c = Convert.ToInt32(list2.ElementAt(i));
                    Console.WriteLine(c);
                }
                else
                {
                    d = Convert.ToInt32(list2.ElementAt(i));
                    Console.WriteLine(d);
                }
            }
            int SumAC = a * c;
            int SumBD = b * d;
        }
    }
}
