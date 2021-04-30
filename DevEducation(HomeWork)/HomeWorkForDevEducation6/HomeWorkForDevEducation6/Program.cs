using System;

namespace HomeWorkForDevEducation6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {
                int columns;
                int rows;
                int startRange;
                int finishRange;

                Console.WriteLine("Please entry value columns: ");
                bool input1 = int.TryParse(Console.ReadLine(), out columns);

                Console.WriteLine("Entry value rows: ");
                bool input2 = int.TryParse(Console.ReadLine(), out rows);

                Console.WriteLine("Enter the start number for the range of values (from lowest to highest).");
                bool input3 = int.TryParse(Console.ReadLine(), out startRange);

                Console.WriteLine("Enter the finish number for the range of values (from lowest to highest).");
                bool input4 = int.TryParse(Console.ReadLine(), out finishRange);

                if (input1 != true && input2 != true && input3 != true && input4 != true)
                    Console.WriteLine("Error: Invalid input format all values ​​must be integers.");
                else if (columns <= 0 || rows <= 0)
                    Console.WriteLine("Error: The values ​​for the row and column were entered incorrectly.");
                else if (columns > 20 || rows > 20)
                    Console.WriteLine("Error: Table size exceeded.");
                else if (startRange <= -1000 || finishRange >= 1000)
                    Console.WriteLine("Error: The range must be between -999 and 999. ");
                else if (startRange > finishRange)
                {
                    int temp = startRange;
                    startRange = finishRange;
                    finishRange = startRange;
                }
                else
                {
                    int[,] array = new int[columns, rows];
                    array = (int[,])FullThisArray(array, startRange, finishRange);
                    ShowThisArray(array);

                    Task1(array);
                    Task2(array);
                    Task3(array);
                    Task4(array);
                    Task5(array);
                    Task6();
                    Task7();
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        private static void Task7()
        {
            //7.Вводим строку, которая содержит число, написанное прописью(0 - 999). Получить само число. 
            bool cont = true;
            do
            {
                Console.WriteLine("Task 7: Enter the input, which contains a number written in words (0 - 999).");
                Console.WriteLine("Will ignore invalid data. ");
                string[] number = Console.ReadLine().Split(" ");
                int answer = 0;
                bool minus = false;
                string[][] array = {
                    new string[2] {"zero", "0"},
                    new string[2] {"one", "1"},
                    new string[2] {"two", "2"},
                    new string[2] {"three", "3"},
                    new string[2] {"four", "4"},
                    new string[2] {"five", "5"},
                    new string[2] {"six", "6"},
                    new string[2] {"seven", "7"},
                    new string[2] {"eight", "8"},
                    new string[2] {"nine", "9"},
                    new string[2] {"ten", "10"},
                    new string[2] {"eleven", "11"},
                    new string[2] {"twelve", "12"},
                    new string[2] {"thirteen", "13"},
                    new string[2] {"fourteen", "14"},
                    new string[2] {"fifteen", "15"},
                    new string[2] {"sixteen", "16"},
                    new string[2] {"seventeen", "17"},
                    new string[2] {"eighteen", "18"},
                    new string[2] {"nineteen", "19"},
                    new string[2] {"twenty", "20"},
                    new string[2] {"thirty", "30"},
                    new string[2] {"forty", "40"},
                    new string[2] {"fifty", "50"},
                    new string[2] {"sixty", "60"},
                    new string[2] {"seventy", "70"},
                    new string[2] {"eighty", "80"},
                    new string[2] {"ninety", "90"},
                    new string[2] {"one hundred", "100"},
                    new string[2] {"two hundred", "200"},
                    new string[2] {"three hundred", "300"},
                    new string[2] {"four hundred", "400"},
                    new string[2] {"five hundred", "500"},
                    new string[2] {"six hundred", "600"},
                    new string[2] {"seven hundred", "700"},
                    new string[2] {"eight hundred", "800"},
                    new string[2] {"nine hundred", "900"}
                };
                // определяем есть ли в строке минус если да то запоминаем
                if (number[0] == "minus")
                {
                    minus = true;

                    for (int i = 0; i < number.Length - 1; i++)
                        number[i] = number[i + 1];

                    string[] snumber = new string[number.Length - 1];

                    for (int i = 0; i < snumber.Length; i++)
                        snumber[i] = number[i];
                    number = snumber;
                }
                // валидируем через строку через if
                if (number[number.Length - 1] == "")
                    Console.WriteLine("Error: Value empty.");
                else if (number.Length == 1)
                {
                    for (int i = 0; i < array.Length; i++)
                        for (int j = 0; j < array[i].Length; j++)
                            if (number[0] == array[i][j])
                            {
                                answer += int.Parse(array[i][j + 1]);
                                break;
                            }
                    string strAnswer = minus ? ("-" + Convert.ToString(answer)) : Convert.ToString(answer);
                    Console.WriteLine(strAnswer);
                }
                else
                {
                    if (number[1] == "hundred")
                    {
                        number[0] += $" {number[1]}";

                        for (int i = 1; i < number.Length - 1; i++)
                            number[i] = number[i + 1];

                        string[] snumber = new string[number.Length - 1];

                        for (int i = 0; i < snumber.Length; i++)
                            snumber[i] = number[i];
                        number = snumber;
                    }

                    for (int k = 0; k < number.Length; k++)
                        for (int i = 0; i < array.Length; i++)
                            for (int j = 0; j < array[i].Length; j++)
                                if (number[k] == array[i][j])
                                {
                                    answer += int.Parse(array[i][j + 1]);
                                    break;
                                }


                    string strAnswer = minus ? ("-" + Convert.ToString(answer)) : Convert.ToString(answer);
                    Console.WriteLine($"Answer: {strAnswer}");
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        private static void Task6()
        {
            //6.Вводим число(0 - 999), получаем строку с прописью числа.
            bool cont = true;
            do
            {
                bool minus = false;
                string soFar = "";
                int number;
                string[][] array = {
                        new string[20]{ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" },
                        new string[10]{ "one hundred", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" },
                        new string[10]{ "one thousand", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" }
                    };

                Console.WriteLine("======================================================");
                Console.WriteLine("Task 6: Please entry number: ");
                bool input = int.TryParse(Console.ReadLine(), out number);
                if (input != true)
                    Console.WriteLine("Error: Number not correct.");
                else if ( number < -999 || number > 999)
                    Console.WriteLine("Error: The number does not fall within the range -999 and 999.");
                else

                {
                    if (number < 0)
                    {
                        minus = true;
                        number *= (-1);
                    }

                    if (number < 20 && number > 0)
                    {
                        for (int i = 0; i < array[0].Length; i++)
                        {
                            if (number == i)
                            {
                                soFar = array[0][i];
                            }
                        }
                    }
                    else if (number == 100)
                    {
                        soFar = array[1][0];
                    }
                    else if (number == 0)
                    {
                        soFar = array[0][0];
                    }
                    else
                    {
                        if (number > 100)
                        {
                            int remainder = number % 100;
                            int hundereds = (number - remainder) / 100;
                            for (int i = 0; i < array[2].Length; i++)
                            {
                                if (hundereds == i)
                                {
                                    soFar += array[2][i];
                                    break;
                                }
                            }
                            number = remainder;
                        }

                        if (number < 20 && number > 0)
                        {
                            for (int i = 0; i < array[0].Length; i++)
                            {
                                if (number == i)
                                {
                                    soFar += " " + array[0][i];
                                }
                            }
                        } else
                        {
                            string s = " " + array[0][number % 10];
                            number /= 10;

                            soFar += " " + array[1][number % 10] + s;
                            number /= 10;
                        }

                    }



                    if (minus == true)
                    {
                        soFar = "minus " + soFar;
                    }
                    Console.WriteLine(soFar);
                    Console.WriteLine("======================================================");
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        private static void Task5(int[,] array)
        {
            //5.Найти количество элементов массива, которые больше всех своих соседей одновременно.
            // я хз какой диапазон считается соседним но я так понял что 1й элемент слева и справа.
            int counter = 0;
            int columns = array.GetUpperBound(0) + 1;
            int rows = array.GetUpperBound(1) + 1;
            for(int i = 0; i < columns; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    int currentValue = array[i, j];
                    int previousValue = 0;
                    int nextValue = 0;
                    if (j != 0)
                        previousValue = array[i, j - 1];
                    else if ( j < (rows - 1) )
                        nextValue = array[i, j + 1];

                    if(currentValue > nextValue && currentValue > previousValue)
                        counter++;
                }
            }
            Console.WriteLine("======================================================");
            Console.WriteLine($"Task 5: The number of array elements that are larger than all their neighbors at the same time: {counter}");
        }
        private static void Task4(int[,] array)
        {
            //4.Найти индекс максимального элемента массива
            int tempI = 0;
            int tempJ = 0;
            int columns = array.GetUpperBound(0) + 1;
            int rows = array.GetUpperBound(1) + 1;
            int maxValueInArray = array[0, 0];
            for ( int i = 0; i < columns; i++)
            {
                for (int j = 0; j <  rows; j++)
                {
                    if (maxValueInArray < array[i, j])
                    {
                        maxValueInArray = array[i, j];
                        tempI = i;
                        tempJ = j;
                    }
                }
            }
            Console.WriteLine("======================================================");
            Console.WriteLine($"Task 4: In array {tempI} most biger index element of an array {tempJ} (night count from 0).");
        }
        private static void Task3(int[,] array)
        {
            //3.Найти индекс минимального элемента массива
            int tempI = 0;
            int tempJ = 0;
            int columns = array.GetUpperBound(0) + 1;
            int rows = array.GetUpperBound(1) + 1;
            int minValueInArray = array[0, 0];
            for ( int i = 0; i < columns; i++)
            {
                for ( int j = 0; j < rows; j++)
                {
                    if ( minValueInArray > array[i, j])
                    {
                        minValueInArray = array[i, j];
                        tempI = i;
                        tempJ = j;
                    }
                }
            }
            Console.WriteLine("======================================================");
            Console.WriteLine($"Task 3: In array {tempI} most small index element of an array {tempJ} (night count from 0).");
        }
        private static void Task2(int[,] array)
        {
            //2.Найти максимальный элемент массива
            int columns = array.GetUpperBound(0) + 1;
            int rows = array.GetUpperBound(1) + 1;
            int maxValueInArray = array[0, 0];

            for ( int i = 0; i < columns; i++)
            {
                for ( int j = 0; j < rows; j++)
                {
                    if (maxValueInArray < array[i, j])
                    {
                        maxValueInArray = array[i, j];
                    }
                }
            }
            Console.WriteLine($"======================================================");
            Console.WriteLine($"Task 2: Maximum element of an array. {maxValueInArray}");
        }
        private static void Task1(int[,] array)
        {
            //1.Найти минимальный элемент массива
            int columns = array.GetUpperBound(0) + 1;
            int rows = array.GetUpperBound(1) + 1;
            int minValueInArray = array[0, 0];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (minValueInArray > array[i, j])
                    {
                        minValueInArray = array[i, j];
                    }
                }
            }
            Console.WriteLine($"======================================================");
            Console.WriteLine($"Task 1: Minimum element of an array. {minValueInArray}");
        }
        private static void ShowThisArray(int[,] array)
        {
            int columns = array.GetUpperBound(0) + 1;
            int rows = array.GetUpperBound(1) + 1;
            for ( int i = 0; i < columns; i++)
            {
                Console.Write("Row: [");
                for ( int j = 0; j < rows; j++)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine("\b\b]");
            }
        }

        private static Array FullThisArray(int[,] array, int startRange, int finishRange)
        {
            Random rand = new Random();

            int columns = array.GetUpperBound(0) + 1;
            int rows = array.GetUpperBound(1) + 1;

            for ( int i = 0; i < columns; i++)
            {   
                for ( int j = 0; j < rows; j++)
                {
                    array[i, j] = rand.Next(startRange, finishRange);
                }
            }
            return array;
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
