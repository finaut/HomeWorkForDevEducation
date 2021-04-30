using System;

namespace HomeWork8
{
    // 1. Простой калькулятор для двух чисел и операторов (+ - * /) переписать с использованием класса.
    public class Calculate
    {
        
        public double Plus(double firstNumber, double lastNumber)
        {
            double sum = firstNumber + lastNumber;
            return sum;
        }

        public double Multiplication(double firstNumber, double lastNumber)
        {
            double sum = firstNumber * lastNumber;
            return sum;
        }

        public double Minus(double firstNumber, double lastNumber)
        {
            double sum = firstNumber - lastNumber;
            return sum;
        }
        public double Division(double firstNumber, double lastNumber)
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