using System;

namespace HomeWork8
{
    // 1. Простой калькулятор для двух чисел и операторов (+ - * /) переписать с использованием класса.
    public class Calculate
    {
        
        public double Plus(int firstNumber, int lastNumber)
        {
            double sum = firstNumber + lastNumber;
            return sum;
        }

        public double Multiplication(int firstNumber, int lastNumber)
        {
            double sum = firstNumber * lastNumber;
            return sum;
        }

        public double Minus(int firstNumber, int lastNumber)
        {
            double sum = firstNumber - lastNumber;
            return sum;
        }
        public double Division(int firstNumber, int lastNumber)
        {
            if (firstNumber != 0 && lastNumber != 0)
            {
                double sum = firstNumber - lastNumber;
                return sum;
            }
            else
            {
                return 0;
            }
        }
    }
}