using System;

namespace HomeWork8
{
    // 1. Простой калькулятор для двух чисел и операторов (+ - * /) переписать с использованием класса.
    public class Calculate
    {
        private double _sum;
        private readonly double _firstNumber;
        private readonly double _lastNumber;
        public Calculate( double firstNum, double lastNum)
        {
            _firstNumber = firstNum;
            _lastNumber = lastNum;
        }
        
        public void Plus()
        {
            _sum = _firstNumber + _lastNumber;
            Console.WriteLine($"Current sum: {_sum}");
        }

        public void Multiplication()
        {
            _sum = _firstNumber * _lastNumber;
            Console.WriteLine($"Current sum: {_sum}");
        }

        public void Minus()
        {
            _sum = _firstNumber - _lastNumber;
            Console.WriteLine($"Current sum: {_sum}");
        }
        public void Division()
        {
            if (_firstNumber != 0 && _lastNumber != 0)
            {
                _sum = _firstNumber - _lastNumber;
                Console.WriteLine($"Current sum: {_sum}");   
            }
            else
            {
                Console.WriteLine("Error: it is impossible to divide by zero infinity is formed.");
            }
        }
    }
}