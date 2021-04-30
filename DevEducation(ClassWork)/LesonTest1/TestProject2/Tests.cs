using System;
using HomeWork8;
using NUnit.Framework;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        [Test]
        public void Test1()
        {
            Calculate calculate = new Calculate();
            double result = calculate.Plus(1, 2);
            var exp = 3;
            Assert.AreEqual(result, exp);
        }
    }
}