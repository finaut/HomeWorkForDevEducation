using System;
using ClassWork13;
using NUnit.Framework;

namespace TestList
{
    [TestFixture]
    public class Tests
    {
        private ArrayList _currentArray;

        [SetUp]
        public void SetUp()
        {
           _currentArray = new ArrayList(new int[] {2, 4, 6, 8});
        }

        [Test]
        public void IndexOfTest()
        {
            Assert.AreEqual(2, _currentArray.IndexOf(6));    
        }
        
        [Test]
        public void ValueByIndexTest()
        {
            Assert.AreEqual(6, _currentArray.ValueByIndex(2));
        }
        
        [Test]
        public void ReversTest()
        {
            _currentArray.Revers();
            Assert.AreEqual("[8, 6, 4, 2]",  _currentArray.Show());    
        }
        
        [Test]
        public void GetMinValueTest()
        {
            Assert.AreEqual(2, _currentArray.GetMinValue());
        }
        
        [Test]
        public void GetMaxValueTest()
        {
            Assert.AreEqual(8, _currentArray.GetMaxValue());
        }
        
        [Test]
        public void AddFirst()
        {
            _currentArray.AddFirst(10);
            Assert.AreEqual(5, _currentArray.Length);
            Assert.AreEqual("[10, 2, 4, 6, 8]", _currentArray.Show());
        }
        
        [Test]
        public void AddItemByIndexTest()
        {
            _currentArray.AddItemByIndex(2, 5);
            Assert.AreEqual(5, _currentArray.Length);
            Assert.AreEqual( "[2, 4, 5, 6, 8]", _currentArray.Show());
        }
        
        [Test]
        public void RemoveItemByIndexTest()
        {
            _currentArray.RemoveItemByIndex(1);
            Assert.AreEqual(3, _currentArray.Length);
            Assert.AreEqual("[2, 6, 8]", _currentArray.Show());
        }

        [Test]
        public void RemoteFirstTest()
        {
            _currentArray.RemoveFirst();
            Assert.AreEqual(3, _currentArray.Length);
            Assert.AreEqual("[4, 6, 8]", _currentArray.Show());
        }
        
        [Test]
        public void AddTest()
        {
            _currentArray.Add(10);
            Assert.AreEqual(5, _currentArray.Length);
            Assert.AreEqual("[2, 4, 6, 8, 10]", _currentArray.Show());
        }

        [Test]
        public void GetLengthGetShowTest()
        {
            Assert.AreEqual("[2, 4, 6, 8]", _currentArray.Show());
            Assert.AreEqual(4, _currentArray.Length);
        }
    }
}