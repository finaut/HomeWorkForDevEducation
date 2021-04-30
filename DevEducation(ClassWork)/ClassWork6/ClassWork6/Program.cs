using System;

namespace ClassWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            CreateArray(array);
            bool cont = true;
            do
            {
                int number;
                Console.WriteLine("Please entry number with you wont found(1..9): ");
                bool input = int.TryParse(Console.ReadLine(), out number);
                if ( input != true)
                {
                    Console.WriteLine("Please entry correct number.");
                } else if ( number < 0 && number > 9)
                {
                    Console.WriteLine("Number lost diapason.");
                } else
                {
                    ViewsArray(array);
                    int quntityNumberWithWiFound = NumberWitchFound(array, number);
                    Console.WriteLine($"Quntity number found: {quntityNumberWithWiFound}");
                }
               cont = WontContinue(cont);
            } while (cont);
        }
        private static Array CreateArray(int[,]  array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 9);
                }
            }
            return array;
        }
        private static void ViewsArray(int[,] array)
        {
            foreach (int i in array)
            {
                foreach (int j in array)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine("\n");
            }
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
        private static int NumberWitchFound(int[,]  array, int number)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(i); i++)
            {
                for (int j = 0; j < array[array.GetLength(i), j]; j++)
                {
                    if ( array[i, j] == number)
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
    }
}
