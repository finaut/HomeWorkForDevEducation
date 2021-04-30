using System;

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Основная задача
            // Программа должна получать 2 значения А и В
            // A - число  котое нужно возвести в степень
            // B - степень в которую нужно возвести
            // сделать все при помощи while

            Task();

        }
        //// void -- метод ничего не возвращает
        /// <summary>
        ///  спецальные  методы:::
        ///  break -- можно использовать для перебора массива на пару с for
        ///  continue -- пропускае и начинается следующая итерация
        /// </summary>
        /// 
        private static void Task()
        {
            int a;
            int b;
            Console.WriteLine("Please entry number A: ");
            bool inputA = int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Please entry number B: ");
            bool inputB = int.TryParse(Console.ReadLine(), out b);

            if (inputA == true && inputB == true)
            {
                Exponentiation(a, b);
            }
            else
            {
                Console.WriteLine("Please entry correct number ( ");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++");
                Task();
            }
        }
        private static void Exponentiation(int a, int b)
        {
            int sum = 0;
            int i = 0;
            if (i > b)
            {
                while (i > b)
                {
                    i--;
                    sum = sum + (a * b);
                    Console.WriteLine(sum);
                }
            }
            else if (i < b) 
            {
                while (i < b)
                {
                    i++;
                    sum = sum + (a * b);
                    Console.WriteLine(sum);
                }
            }
            else 
            {
                b = 1;
                sum = sum + (a * b);
                if (sum == 0)
                    ++sum;
                Console.WriteLine(sum);
            }
        }


        private static void TaskWhile()
        {
            Console.WriteLine("Please entry A number: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please entry B number: ");
            var b = int.Parse(Console.ReadLine());

            int i = 0;
            int sum = 0 ;

            while (i < b)
            {
                i++;
                sum += (a * b);
                Console.WriteLine(sum);
            }
        }
        private static void TaskFor()
        {
            var sum = 1;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum * i;
                Console.WriteLine(sum);
            }
        }
        private static void DoWhileTask()
        {
            int i = 0;
            int suma = 0;
            do
            {
                i++;
                suma += i;
                Console.WriteLine(suma);
            } while (i < 10);
        }
        private static void ExampleWhileContinue()
        {
            int a = 10;
            for (int i = 0; i<a; i++)
            {
                if(i == 5 )
                {
                    continue;
                }
                Console.WriteLine(i);
            }
}
private static void ExampleWhileBreak()
        {
            int a = 10;
            for (int i = 0; i < a; i++)
            {
                if( i == 5 )
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        private static void ExampleWithWhile3()
        {
            int i = 5;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i > 0);
        }
        private static void ExampleWithWhile2()
        {
            int j = 2;
            for (int i = 0; i < 100; i = i + 2)
            {
                j = j - 1;
                Console.WriteLine($"before while {j}");
                while(j < 15)
                {
                    j = j + 5;
                    Console.WriteLine($"in while {j}");
                }
            }
        }
        private static void ExampleWithWhile()
        {
            int i = 5; 
            while( i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        private static void Example4()
        {
            Console.WriteLine("Please entry you number: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                var firstName = GetName();
                var lastName = GetLastName();
                WriteFullName(firstName, lastName);
            }
        }
        private static void WriteFullName(string first_name, string last_name)
        {
            Console.WriteLine($"You full name: {first_name} {last_name}");
        }
        private static string GetName()
        {
            Console.WriteLine("Please entry you fisrt name: ");
            var firstName = Console.ReadLine();
            return firstName;
        }

        private static string GetLastName()
        {
            Console.WriteLine("Please entry you last name: ");
            var lastName = Console.ReadLine();
            return lastName;
        }
        private static void Example3()
        {
            Console.WriteLine("Please entry number: ");
            bool result = int.TryParse(Console.ReadLine(), out int number);
            if (result == true)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("Entry you Fist name: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Entry you Last name: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine($"Your first name: {firstName}, your last name: {lastName}");
                }
            } else
            {
                Console.WriteLine("Please Entry correct number");
            }
            
        }
        private static void Example2()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            for(int i = 0; i < a; i++)
            {
                Console.WriteLine($"i = {i}");
                for (int j  = 0; j <= b; j ++)
                {
                    Console.WriteLine($" j  = {j}");
                }
            }
        }
    }
}
