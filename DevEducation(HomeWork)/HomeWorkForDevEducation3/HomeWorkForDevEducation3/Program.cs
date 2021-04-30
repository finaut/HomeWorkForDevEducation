using System;

namespace HomeWorkForDevEducation3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();

        }
        public static void Task8()
        {
            // 8.Пользователь вводит 2 числа.
            // Сообщите, есть ли в написании двух чисел одинаковые цифры.
            // Например, для пары 123 и 3456789, ответом будет являться “ДА”,
            // а, для пары 500 и 99 - “НЕТ”.
            bool cont = true;
            do
            {
                long firstNumber;
                long secondNumber;
                bool compatibility = false;

                Console.WriteLine("Please entry first number: ");
                string firstNumberStr = Console.ReadLine().Replace(" ", "");
                bool input1 = long.TryParse(firstNumberStr, out firstNumber);

                Console.WriteLine("Entry second number: ");
                string secondNumberStr = Console.ReadLine().Replace(" ", "");
                bool input2 = long.TryParse(secondNumberStr, out secondNumber);

                if (input1 != true && input2 != true)
                    Console.WriteLine("Please entry currect number.");
                else if  ( firstNumberStr.Length > 18 && secondNumberStr.Length > 18)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Please enter a number up to 18 characters.");
                }
                else
                {
                    if (firstNumber < 0)
                        firstNumberStr = Convert.ToString(firstNumber *= -1);
                    if (secondNumber < 0)
                        secondNumberStr = Convert.ToString(secondNumber *= -1);

                    for (int i = 0; i < firstNumberStr.Length; i++)
                    {
                        for (int j = 0; j < secondNumberStr.Length; j++)
                        {
                            if (firstNumberStr[i] == secondNumberStr[j])
                            {
                                compatibility = true;
                                break;
                            }
                        }
                    }
                    if (compatibility == true)
                        Console.WriteLine("========================\nThere are matches.\nYES\n========================");
                    else
                        Console.WriteLine("========================\nThere are not matches.\nNO\n========================");
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        public static void Task7()
        {
            // 7.Простой калькулятор(2 числа и операторы + - * /)
            // с разделением логики на методы. После каждой операции
            // повторно спрашивать числа и производить вычисления.
            bool cont = true;
            do
            {
                double firstNumber;
                double secondNumer;

                Console.WriteLine("Please entry first number: ");
                bool input1 = double.TryParse(Console.ReadLine().Replace(" ", ""), out firstNumber);

                Console.WriteLine("Entry operator (only: +, -, *, /): ");
                string operString = Console.ReadLine().Replace(" ", "");
                
                Console.WriteLine("Entry second number: ");
                bool input2 = double.TryParse(Console.ReadLine().Replace(" ", ""), out secondNumer);

                
                if (input1 == true && input2 == true)
                {
                    switch (operString)
                    {
                        case "+":
                            Console.WriteLine($"Result: {SummationOperation(firstNumber, secondNumer)}");
                            Console.WriteLine("================");
                            break;
                        case "-":
                            Console.WriteLine($"Result: {WithdrawalOperation(firstNumber, secondNumer)}");
                            Console.WriteLine("================");
                            break;
                        case "*":
                            Console.WriteLine($"Result: {MultiplicationOperation(firstNumber, secondNumer)}");
                            Console.WriteLine("================");
                            break;
                        case "/":
                            if (firstNumber == 0 && secondNumer == 0)
                                Console.WriteLine("You cannot divide by zero.");
                            else 
                                Console.WriteLine($"Result: {DivisionOperation(firstNumber, secondNumer)}");
                            break;
                        default:
                            Console.WriteLine("it is impossible to process the operator.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Check the correctness of the entered data.");
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        public static double SummationOperation(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }

        public static double WithdrawalOperation(double firstNumber, double secondNumber)
        {
            double sum = firstNumber - secondNumber;
            return sum;
        }

        private static double DivisionOperation(double fisrtNumber, double secondNumber)
        {
            double sum = fisrtNumber / secondNumber;
            return sum;
        }

        private static double MultiplicationOperation(double firstNumber, double secondNumber)
        {
            double sum = firstNumber * secondNumber;
            return sum;
        }


        public static void Task6()
        {
            // 6.Вывести число, которое является зеркальным отображением последовательности
            // цифр заданного числа, например, задано число 123, вывести 321.
            bool cont = true;
            do
            {
                long number;
                string newString = "";
                Console.WriteLine("Please indicate the number that I will turn: ");
                string numberString = Console.ReadLine();
                numberString = numberString.Replace(" ", "");
                bool inputCheck = long.TryParse(numberString, out number);
                if (numberString.Length == 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Please enter any value.");

                }
                else if (numberString.Length > 18)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Please enter a number up to 18 characters.");
                }
                else if (inputCheck == false)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Please entry correct number. ");
                }
                else
                {
                    bool minus = false;
                    if (number < 0)
                    {
                        number *= -1;
                        minus = true;
                    }

                    for (int i = (numberString.Length - 1); i >= 0; i--)
                    {
                        newString = newString + Convert.ToString(numberString[i]);
                    }

                    if (minus == true)
                    {
                        newString = newString.Replace("-", "");
                       number = (long.Parse(newString) * (-1));
                       Console.WriteLine(number);
                    } else 
                       Console.WriteLine(newString);
                }
                cont = WontContinue(cont);
            } while (cont);
        }

        public static void Task5()
        {
            // 5.Посчитать сумму цифр заданного числа
            bool cont = true;
            do
            {
                long number;
                Console.WriteLine("Entry big number I'll summarize the numbers in it:  ");
                string numberString = Console.ReadLine();
                numberString = numberString.Replace(" ", "");
                bool inputCheck = long.TryParse(numberString, out number);
                if (numberString.Length == 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Please enter any value.");

                }
                else if (numberString[0] == '-')
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Please enter a number without a minus.");
                }
                else if (numberString.Length > 18)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Please enter a number up to 18 characters.");
                }
                else if (inputCheck == false)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Please entry correct number. ");
                }
                else
                {
                    long sum = 0;
                    for (int i = 0; i < numberString.Length; i++)
                    {
                        sum += Convert.ToInt32(Convert.ToString(numberString[i]));
                    }
                    Console.WriteLine(sum);
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        public static void Task4()
        {
            // 4.Вычислить факториал числа n.n! = 1 * 2 *…*n - 1 * n; !
            bool cont = true;
            do
            {
                int factorial;
                
                Console.WriteLine("Entry the you factorial(n!): ");
                string factorialString = Console.ReadLine();
                bool input = int.TryParse(factorialString, out factorial);
                if (input == true)
                {
                    if (factorial <= 0)
                        Console.WriteLine("Factorial for 0 or less does not exist.");
                    else
                    {
                        Console.WriteLine("Which method to use recursion / loop (1/2):");
                        string userAnswer = Console.ReadLine();
                        if (userAnswer == "1")
                        {
                            Console.WriteLine("=============================");
                            Console.WriteLine($"Answer: {FactorialRecursion(factorial)}");
                        }
                        else if (userAnswer == "2")
                        {
                            Console.WriteLine("=============================");
                            Console.WriteLine($"Answer: {FactorialWhile(factorial)}");
                        }
                        else
                        {
                            Console.WriteLine("=============================");
                            break;
                        }
                    }
                } if( !int.TryParse(factorialString, out int temple))
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Please entry integer. ");
                }
                else
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Please entry correct number. ");
                }
                cont = WontContinue(cont);
            } while (cont);

        }
        public static double FactorialWhile(double factorial)
        {
            int i = 0;
            double sum = 1;
            while (i != factorial)
            {
                i++;
                sum = sum * i;
            }
            return sum;
        }

        public static double FactorialRecursion(double factorial, int i = 0, double sum = 1)
        {
            i++;
            sum = sum * i;
            if (i == factorial)
                return sum;
            else
                return FactorialRecursion(factorial, i, sum);
        }
        public static void Task3()
        {
            // 3.Найти корень натурального числа с точностью до целого
            // (рассмотреть вариант последовательного подбора и метод бинарного поиска)
            bool cont = true;
            do
            {
                double rootNumber;
                Console.WriteLine("Enter the root of a natural number: ");
                bool input = double.TryParse(Console.ReadLine(), out rootNumber);
                Console.WriteLine("=============================");
                if (input == true)
                {
                    if (rootNumber == -1)
                        Console.WriteLine("Aswer: i");
                    else if (rootNumber <= -2)
                        Console.WriteLine("Error: dous not exist");
                    else
                    {
                        Console.WriteLine("please select a method: sequential selection / binary search (1/2): ");
                        Console.WriteLine("Binary will be without rounding");
                        string choiceUserSearch = Console.ReadLine();
                        if (choiceUserSearch == "1")
                        {
                            Console.WriteLine($"Answer: {consistentSelection(rootNumber)}");
                            Console.WriteLine("=============================");
                        }
                        else if (choiceUserSearch == "2")
                        {
                            Console.WriteLine($"Answer: {binarySearchSqrt(rootNumber)}");
                            Console.WriteLine("=============================");
                        }
                        else
                        {
                            Console.WriteLine("=============================");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("Please entry correct number. ");
                }
                cont = WontContinue(cont);
            } while (cont);
        }

        public static double binarySearchSqrt(double  rootNumber)
        {
            double min = 1;
            double max = rootNumber;
            double prev = 0;
            
            while (true)

            {
                double mid = (min + max) / 2;
                if (prev == mid)
                    return mid;
                double q = mid * mid;
                if (rootNumber == q)
                    return mid;
                if (rootNumber < q)
                    max = mid;
                else
                    min = mid;
                prev = mid;
            }
        }

        public static double consistentSelection(double rootNumber)
        {
            double r = 1;
            while (true)
            {
                double q = (r + rootNumber / r) / 2;
                if (q == r) break;
                r = q;
            }
            return r;
        }

        public static void Task2()
        {
            // 2. Проверить простое ли число?
            // (число называется простым, если оно делится только само на себя и на 1) 
            bool cont = true;
            do
            {
                long number;
                Console.WriteLine("Entry number: ");
                string integerText = Console.ReadLine();
                Console.WriteLine($"===========================");
                if (integerText.Length > 18)
                {
                    Console.WriteLine("Error: too large number must be < 18 characters.");
                    Console.WriteLine($"===========================");
                }
                else if (!long.TryParse(integerText, out number))
                {
                    Console.WriteLine("Error: entry correct number.");
                    Console.WriteLine($"===========================");
                }
                else if (number <= 1)
                {
                    Console.WriteLine("Error: number outside the rule.");
                    Console.WriteLine($"===========================");
                }
                else
                {
                    if (IsSimple(number) == true)
                    {
                        Console.WriteLine($"Number {number} not simple.");
                        Console.WriteLine($"===========================");
                    }
                    else
                    {
                        Console.WriteLine($"Number {number} simple.");
                        Console.WriteLine($"===========================");
                    }
                }
                cont = WontContinue(cont);
            } while (cont);
        }

        static private bool IsSimple(long number)
        {
            if (number == 2)
            {
                return false;
            }
            else
            {
                long value = number / 2;
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

        public static void Task1()
        {
            // 1.Найти сумму четных чисел и их количество в диапазоне от 1 до 99
            bool cont = true;
            do
            {
                int sum = 0;
                int amuount = 0;
                int range;
                Console.WriteLine("Please entry number for range (MaxValue): ");
                bool input = int.TryParse(Console.ReadLine(), out range);
                Console.WriteLine("===========================");
                if (input == true)
                {
                    if (range <= 0)
                    {
                        if (range < -99)
                            range = -99;

                        for (int i = -1; i >= range; i--)
                        {
                            if (i % 2 == 0)
                            {
                                sum += i;
                                ++amuount;
                                Console.WriteLine($"{i} -- it`s even");
                            }
                            else
                            {
                                Console.WriteLine($"{i} -- it`s odd");
                            }
                        }
                        Console.WriteLine("===========================");
                        Console.WriteLine($"Current sum: {sum} and amuount even number: {amuount}");
                    }
                    else
                    {
                        if (range > 99)
                            range = 99;
                        for (int i = 1; i <= range; i++)
                        {
                            if (i % 2 == 0)
                            {
                                sum += i;
                                ++amuount;
                                Console.WriteLine($"{i} -- it`s even");
                            }
                            else
                            {
                                Console.WriteLine($"{i} -- it`s odd");
                            }
                        }
                        Console.WriteLine("===========================");
                        Console.WriteLine($"Current sum: {sum} and amuount even number: {amuount}");
                    }
                }
                else
                {
                    Console.WriteLine("Please entry current number.");
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
