using System;
using HomeWork8;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private Calculate _calculate;
        private Masivator _array;
        
        [SetUp]
        public void SetUp()
        { 
            _calculate = new Calculate();
            _array = new Masivator();
            // _array = new int[] {1, 2, -3, 7, -4, 12, 8, 9};
        }
        
        [TestCase("one hundred twenty three", 123)]
        [TestCase("minus one hundred twenty three", -123)]
        [TestCase("nine hundred ninety nine", 999)]
        [TestCase(" forty three", 43)]
        [TestCase("twelve", 12)]
        [TestCase("nine", 9)]
        [TestCase("zero", 0)]
        public void TestNumberToString(string expectString, int number)
        {
            Assert.AreEqual(expectString, NumberToString.Task6(number));
        }
        
        [Test]
        public void TestMasivatorClear()
        {
            int[] arrayMustBe = new int[] {0, 0, 0, 0, 0, 0, 0, 0};
            Assert.AreEqual(arrayMustBe, _array.Clear());
        }
        
        [Test]
        public void TestMasivatorSort()
        {
            int[] arrayMustBe = new int[] {-4, -3, 1, 2, 7, 8, 9, 12};
            Assert.AreEqual(arrayMustBe, _array.Sort());
        }
            
        [TestCase(10, 4, 10)]
        public void TestMasivatorAdd(int expectValue, int index, int value)
        {
            Assert.AreEqual(expectValue, _array.Add(index, value));
        }
        
        [TestCase(0, 4)]
        public void TestMasivatorDelete(int expectValue, int index)
        {
            int currentValue = _array.Delete(index);
            Assert.AreEqual(expectValue, currentValue);
        }
        
        
        [TestCase(7, 3)]
        public void TestGetValueByIndex(int expectValue, int index)
        {
            int currentValue = _array.GetValueByIndex(index);
            Assert.AreEqual(expectValue, currentValue );
        }
        
        [TestCase(1,  2)]
        public void TestMasivatorGetIndex(int expectIndex, int value)
        {
            Assert.AreEqual(expectIndex, _array.CurrentIndexValue(value));
        }
        
        
        [TestCase(0, 0,  0)]
        [TestCase(1, -2, -1)]
        [TestCase(1, 1, 2)]
        public void TestPlus(double firstNumber, double secondNumber, double expectResult)
        {
            Assert.AreEqual(expectResult, _calculate.Plus(firstNumber, secondNumber) );
        }
        
        [TestCase(10, -5, 15)]
        [TestCase(-5.55, 5.55, -11.1)]
        [TestCase(-5.5,  -3.3, -2.2)]
        [TestCase(5, 10, -5)]
        [TestCase(10, 5, 5)]
        public void TestMinus(double firstNumber, double secondNumber, double expectResult)
        {
            Assert.AreEqual(expectResult, _calculate.Minus(firstNumber, secondNumber));
        }
        
        [TestCase( -3,  1.5,  -2)]
        [TestCase(-25, -5, 5.0)]
        [TestCase(25, 5, 5.0)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        public void TestDivision(double firstNumber, double secondNumber, double expectResult)
        {
            Assert.AreEqual(expectResult, _calculate.Division(firstNumber, secondNumber));
        }

        [TestCase( 1, 1, 1)]
        [TestCase(0,0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0.5,  0.5, 0.25)]
        [TestCase(0.5, -0.5, -0.25)]
        [TestCase(-0.5, -0.5, 0.25)]
        public void TestMultiplication(double firstNumber,  double secondNumber, double expectResult)
        {
            Assert.AreEqual(expectResult,  _calculate.Multiplication(firstNumber, secondNumber));
        }
    }
}