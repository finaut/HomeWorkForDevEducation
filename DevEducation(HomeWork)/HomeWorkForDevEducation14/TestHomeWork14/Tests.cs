using System;
using HomeWorkForDevEducation14;
using NUnit.Framework;

namespace TestHomeWork14
{
    [TestFixture]
    public class Tests
    {
        private MyDoubleLinkedList _array;

        [SetUp]
        public void SetUp()
        {
            _array = new MyDoubleLinkedList(new int[] {2, 4, 6, 8, 10});
        }
        
        [Test]
        public void AddLast()
        {
            _array.AddLast(11);
            Assert.AreEqual(6, _array.Length);
            Assert.AreEqual("[2, 4, 6, 8, 10, 11]", _array.Show());
        }
        
        [Test]
        public void AddFirst()
        {
            _array.AddFist(1);
            Assert.AreEqual( 6,  _array.Length);
            Assert.AreEqual( "[1, 2, 4, 6, 8, 10]", _array.Show());
        }
        
        [Test]
        public void IndexOf()
        {
            Assert.Throws<ArgumentException>(() => _array.IndexOf(12));
            Assert.AreEqual(4, _array.IndexOf(10));
        }    
        
        [Test]
        public void RemoveTest()
        {
            Assert.AreEqual(true, _array.Remove(6));
            Assert.AreEqual(4, _array.Count);
            Assert.AreEqual("[2, 4, 8, 10]", _array.Show());
            Assert.Throws<ArgumentException>(() => _array.Remove(12));
        }
        
        [Test]
        public void ClearTest()
        {
            _array.Clear();
            Assert.AreEqual("[]", _array.Show());
            Assert.AreEqual(0, _array.Count);
        }
        [Test]
        public void ContainersTest()
        {
            Assert.AreEqual(true, _array.Contains(2));
            Assert.AreEqual(false, _array.Contains(12));
        }
        [Test]
        public void ShowTest()
        {
            Assert.AreEqual("[2, 4, 6, 8, 10]", _array.Show());    
        }
        
        [Test]
        public void isEmptyTest()
        {

            MyDoubleLinkedList secondArray = new MyDoubleLinkedList();
            Assert.AreEqual(false, _array.isEmpty);
            Assert.AreEqual(true, secondArray.isEmpty);
        }
        
        [Test]
        public void CountTest()
        {
            Assert.AreEqual(5, _array.Count);
        }
    }
}