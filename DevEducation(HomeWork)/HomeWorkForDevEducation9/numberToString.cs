using System;

namespace TestProject1
{
    public class NumberToString
    {
        public static string Task6(int number)
        {
            //6.Вводим число(0 - 999), получаем строку с прописью числа.
            bool minus = false;
            string soFar = "";
            string[][] array =
            {
                new string[20]
                {
                    "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                    "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
                },
                new string[10]
                {
                    "one hundred", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
                },
                new string[10]
                {
                    "one thousand", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred",
                    "six hundred", "seven hundred", "eight hundred", "nine hundred"
                }
            };
            if (number < -999 || number > 999)
                throw new AggregateException("Error: The value must not be more than 999 or less than -999.");
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
                    }
                    else
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

                return soFar;
            }
        }
    }
}