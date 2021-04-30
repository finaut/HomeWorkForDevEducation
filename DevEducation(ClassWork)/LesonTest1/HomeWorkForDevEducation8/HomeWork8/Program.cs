using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace HomeWork8
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Task1();
            Task2();
        }

        private static void Task2()
        {
            // 2. Класс для работы с массивом (добавление, удаление, сортировка, печать в консоль, очистка )
            bool cont = true;
            int sizeArray = 10;
            string instruction = "A <index> <value> --(For add value be index)\n" +
                                 "D <index> --(For delete value be index)\n" +
                                 "I <value> --(For to find the index of the desired value)\n" +
                                 "B --(Sort be Booble)\n" +
                                 "S --(Show array)\n" +
                                 "C --(For full delete all value from array)\n" +
                                 "H --(Help for see the list of commands)\n" +
                                 "E --(For exit in Program.)\n";

            Console.WriteLine("INTEGERS VALUES ONLY!!!");
            Console.WriteLine(
                "Warehouse program, manipulate your array as you want.\nEntry size for you array(default: 10)");
            string input = Console.ReadLine()?.Replace(" ", "");
            if (input != "")
            {
                bool answerSizeArray = int.TryParse(input, out sizeArray);
                if (answerSizeArray != true)
                {
                    sizeArray = 10;
                    Console.WriteLine("Error: entry correct number.");   
                }
                else if (sizeArray > 1000)
                {
                    sizeArray = 10;
                    Console.WriteLine("Error: very large array.");                    
                }
            }
            Masivator array = new Masivator(sizeArray);
            Console.WriteLine(instruction);
            do
            {
                string answerStr = Console.ReadLine();
                string[] answerArray = SplitIntoArray(answerStr);
                if (answerArray[0] != null)
                {
                    bool inputIndex = int.TryParse(answerArray[1], out int index);
                    bool inputValue = int.TryParse(answerArray[2], out int value);

                    switch (answerArray[0].ToUpper())
                    {
                        case "A":
                            if (inputIndex != true)
                                Console.WriteLine("Error: An incorrect params passed to the index.");
                            else if (inputValue != true)
                                Console.WriteLine("Error: An incorrect params passed to the value.");
                            else
                                array.Add(index, value);
                            break;

                        case "D":
                            
                             if (inputIndex != true)
                                Console.WriteLine("Error: An incorrect params passed to the index.");
                             else
                                 array.Delete(index);
                             break;
                        
                        case "I":
                            if (inputIndex != true)
                                Console.WriteLine("Error: An incorrect params passed to the value.");
                            else
                                array.CurrentIndexValue(index);
                            break;
                        
                        case "B":
                            array.Sort();
                            break;
                        case "S":
                            array.Show();
                            break;
                        case "C":
                            array.Clear();
                            break;
                        case "H":
                            Console.WriteLine(instruction);
                            break;
                        case "E":
                            cont = false;
                            Console.WriteLine("Bye Bye!!!");
                            break;
                        default:
                            Console.WriteLine("Error: the first argument is incorrect.");
                            break;
                    }
                }
            } while (cont);
        }

        private static void Task1()
        {
            // 1. Простой калькулятор для двух чисел и операторов (+ - * /) переписать с использованием класса.
            bool cont = true;
            double lastNumber;
            double firstNumber;
            do
            {
                Console.WriteLine("Only standard operations and only 2 numbers.");
                Console.WriteLine("Please entry equation (like: 2 + 2 ): ");
                string equation = Console.ReadLine();
                string[] array = SplitIntoArray(equation);
                bool input1 = double.TryParse(array[0], out firstNumber);
                bool input3 = double.TryParse(array[2], out lastNumber);
                if (array.Length > 3)
                    Console.WriteLine("Error: Many arguments passed.");
                else if (input1 != true && input3 != true)
                    Console.WriteLine("Error: Numbers were entered incorrectly.");
                else
                {
                    string operation = array[1];
                    Calculate calculate = new Calculate(firstNumber, lastNumber);
                    switch (operation)
                    {
                        case "+":
                            calculate.Plus();
                            break;
                        case "-":
                            calculate.Minus();
                            break;
                        case "*":
                            calculate.Multiplication();
                            break;
                        case "/":
                            calculate.Division();
                            break;
                        default:
                            Console.WriteLine("Error: Operation not recognized.");
                            break;
                    }
                }
                cont = WontContinue();
            } while (cont);
        }

        private static string[] SplitIntoArray(string str)
        {
            var strArray = str.Split(' ');
            strArray = ClearArray(strArray);
            return strArray;
        }

        private static string[] ClearArray(string[] str)
        {   
            if (str.Length > 3)
                for (int i = 3; i < str.Length; i++)
                    str[i] = "";
            
            string[] newArray = new string[3];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                {
                    newArray[j] = str[i];
                    j++;
                }
            }

            return newArray;
        }

        private static void ShowMeNormalArray(string[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        public static bool WontContinue()
        {
            bool cont = true;
            Console.WriteLine("Do you want to continue ? (y/n)");
            string choiceContinue = Console.ReadLine();
            choiceContinue = choiceContinue.Replace(" ", "");
            if (choiceContinue != "y" && choiceContinue != "Y")
                cont = false;
            Console.WriteLine("================================");
            return cont;
        }
    }
}