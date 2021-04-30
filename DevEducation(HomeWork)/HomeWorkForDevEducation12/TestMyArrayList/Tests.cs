using System;
using HomeWorkForDevEducaton12;
using NUnit.Framework;

namespace TestMyArrayList
{
    [TestFixture]
    public class Tests
    {
        private MyArrayList list;
        
        [SetUp]
        public void SetUp()
        {
             list = new MyArrayList( );
             list.Add(1);
             list.Add(2);
             list.Add(3);
             list.Add(4);
        }

        // TDD
        [Test]
        public void TestRevers()
        {
            list.Revers();
            Assert.AreEqual(4, list.Count );
            Assert.AreEqual("[4, 3, 2, 1]",  list.Show);
        }
        
        [Test]
        public void TestBubbleSortSmallBig()
        {
            list.Add(3);
            list.Add(2);
            list.BubbleSortSmallBig();
            Assert.AreEqual ("[1, 2, 2, 3, 3, 4]", list.Show);
        }
        
        [Test]
        public void TestBubbleSortBigSmall()
        {
                list.BubbleSortBigSmall();
                Assert.AreEqual("[4, 3, 2, 1]", list.Show);
        }
        
        [Test]
        public void TestRemove()
        {
            list.Add(2);
            list.Remove(2);
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("[1, 3, 4]", list.Show);
        }
        [Test]
        public void TestRemoveAt()
        {
            list.RemoveAt(1);
            Assert.AreEqual("[1, 3, 4]",  list.Show);  
        }
        [Test]
        public void TestInsert()
        {
            list.Insert(1,  8);
            Assert.AreEqual(1, list.IndexOf(8));
        }
        [Test]
        public void TestIndexOf()
        {
            Assert.AreEqual(2, list.IndexOf(3));
        }
        [Test]
        public void TestClear()
        {
            list.Clear();
            Assert.AreEqual(0, list.Count );
            Assert.AreEqual("[]", list.Show);    
        }
        [Test]
        public void TestCount()
        {
            Assert.AreEqual(4, list.Count);
        }     
        
        [Test]
        public void TestAdd()
        {
            list.Add(3);
            Assert.AreEqual(3, list[2] );
            Assert.AreEqual(3, list[4] );
            Assert.AreEqual(5, list.Count);
        }

        [Test]
        public void TestSyncRoot()
        {
            Assert.AreEqual(list, list.SyncRoot);
        }

        [Test]
        public void TestIsSynchronized()
        {
            Assert.AreEqual(false, list.IsSynchronized);
        }

        [Test]
        public void TestIsReadOnly()
        {
            Assert.AreEqual(false, list.IsReadOnly);
        }

        [Test]
        public void TestIsFixedSize()
        {
            Assert.AreEqual(true, list.IsFixedSize);
        }

        [Test]
        public void TestContainer()
        {
            Assert.AreEqual(true, list.Contains(2));
        }
        [Test]
        public void TestShow()
        {
            Assert.AreEqual("[1, 2, 3, 4]", list.Show);
        }
    }
}