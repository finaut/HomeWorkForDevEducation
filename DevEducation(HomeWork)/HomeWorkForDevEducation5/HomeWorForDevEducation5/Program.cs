using System;

namespace HomeWorForDevEducation5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {
                int startRange;
                int finishRange;
                int sizeArray;
                Console.WriteLine("Please entry start Range: ");
                bool input1 = int.TryParse(Console.ReadLine(), out startRange);
                Console.WriteLine("Entry finish Range: ");
                bool input2 = int.TryParse(Console.ReadLine(), out finishRange);
                Console.WriteLine("Entry size array: ");
                bool input3 = int.TryParse(Console.ReadLine(), out sizeArray);
                if (input1 != true && input2 != true && input3 != true)
                    Console.WriteLine("Enter correct value: ");
                else if (sizeArray > 50)
                    Console.WriteLine($"it can make the array size larger than {sizeArray}, but better not needed");
                else if ( startRange > finishRange)
                    Console.WriteLine($"Range start is less than its end: {startRange} > {finishRange} it`s is not right.");
                 else
                {
                    int[] array = new int[sizeArray];
                    array = (int[])GenerateArray(array, startRange, finishRange);
                    ShowMeNormalArray(array);

                    Task1(array);
                    Task2(array);
                    Task3(array);
                    Task4(array);
                    Task5(array);
                    Task6(array);
                    Task7(array);
                    Task8(array);
                    Task9(array);
                    Task10(array);
                }
                cont = WontContinue(cont);
            } while (cont);
        }
        private static void Task10(int[] array)
        {
            // Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) : пузырьком(Bubble), выбором(Select) или вставками(Insert))
            int imin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                imin = MaxValue(array, i);
                int temp = array[i];
                array[i] = array[imin];
                array[imin] = temp;
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 10");
            ShowMeNormalArray(array);
        }

        static int MaxValue(int[] array, int firstIndex)
        {
            int max = array[firstIndex];
            int imax = firstIndex;
            for (int i = firstIndex; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }
            }
            return imax;
        }

        public static void Task9(int[] array)
        {
            // Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert))
            int[] secondArray = (int[])array.Clone();
            int tempest = 0;

            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        tempest++;
                    }
                }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 9");
            ShowMeNormalArray(array);
        }

        private static void Task8(int[] array)
        {
            // Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2, или для 12345 - 45312.
            int middlePlus;
            if (array.Length % 2 == 0)
                middlePlus = 0;
            else
                middlePlus = 1;
           
            int midArray = (array.Length / 2);

            for (int i = 0; i < midArray; i++)
            {
                int temp = array[i];
                array[i] = array[midArray + i + middlePlus];
                array[midArray + i + middlePlus] = temp;
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 8");
            ShowMeNormalArray(array);

        }
        private static void Task7(int[] array)
        {
            // Посчитать количество нечетных элементов массива.
            int quantityOddNumber = 0;
            for ( int i = 0; i < array.Length; i++)
            {
                if ( array[i] % 2 != 0)
                {
                    quantityOddNumber += 1;
                }
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 7: Current quantity odd number: {quantityOddNumber}");
        }
        private static void Task6(int[] array)
        {
            // Сделать реверс массива(массив в обратном направлении)
            int j = array.Length - 1;
            int[] newArray = new int[array.Length];
            for( int i = 0; i < array.Length ; i++)
            {
                newArray[i] = array[j];
                j -= 1;
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine("Task 6: Reverse array.");
            ShowMeNormalArray(newArray);
        }
        private static void Task5(int[] array)
        {
            // Посчитать сумму элементов массива с нечетными индексами
            int sum = 0;
            foreach (int i in array)
            {
                if ( i % 2 != 0)
                    sum += i;              
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 5: The running sum of the odd elements in the array: {sum}");
        }
        private static void Task4(int[] array)
        {
            // Найти индекс максимального элемента массива
            int indexMinValue = 0;
            int firstNumber = 0;
            int minNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                firstNumber = array[i];
                if (minNumber < firstNumber)
                {
                    minNumber = firstNumber;
                    indexMinValue = i;
                }
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 4: The index of the maximum value in the array: {indexMinValue} (counting from 0).");
        }
        private static void Task3(int[] array)
        {
            // Найти индекс минимального элемента массива
            int indexMinValue = 0;    
            int firstNumber = 0;
            int minNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                firstNumber = array[i];
                if (minNumber > firstNumber)
                {
                    minNumber = firstNumber;
                    indexMinValue = i;
                }
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 3: The index of the minimum value in the array: {indexMinValue} (counting from 0).");
        }
        private static void Task2(int[] array)
        {
            // Найти максимальный элемент массива
            int firstNumber = 0;
            int maxNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                firstNumber = array[i];
                if (maxNumber < firstNumber)
                    maxNumber = firstNumber;
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 2: The maxmum value in the array: {maxNumber} (counting from 0).");
        }
        
        private static void Task1(int[] array)
        {
            // Найти минимальный элемент массива
            int firstNumber = 0;
            int minNumber = array[0];
            for ( int i = 0; i < array.Length; i++)
            {
                firstNumber = array[i];
                if (minNumber > firstNumber )
                    minNumber = firstNumber;
            }
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Task 1: The minimum value in the array: {minNumber} (counting from 0).");
        }

        private static void ShowMeNormalArray(int[] array)
        {
            // инкапсуляция, сокрытия деталей реализаций ) из названия метода понятно что он должен выполнять )
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        
        private static Array  GenerateArray(int[] array, int startRange, int finishRange)
        {
            int[] fullArray = new int[array.Length];
            for (int i = 0; i < fullArray.Length; i++)
            {
                Random rnd = new Random();
                int value = rnd.Next(startRange, finishRange);
                fullArray[i] = value;
            }
            return fullArray;
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
