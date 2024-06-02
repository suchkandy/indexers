using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using classIndexers;

namespace ex1
{
    [TestClass]
    public class UnitTest1
    {
        int[] array = new int[] { 1, 2, 3, 4 };


        //верность возвращаемой длины массива
        [TestMethod]
        public void HaveCorrectLength()
        {
            var indexer = new Indexer<int>(array, 1, 2);
            Assert.AreEqual(2, indexer.Length);
        }


        //верность получаемых данных Indexers
        [TestMethod]
        public void GetCorrectly()
        {
            var indexers = new Indexer<int>(array, 1, 2);
            Assert.AreEqual(2, indexers[0]);
            Assert.AreEqual(3, indexers[1]);
        }


        //Indexers верно устанавливает элементы подмассива
        [TestMethod]
        public void SetCorrectly()
        {
            var indexers = new Indexer<int>(array, 1, 2);
            indexers[0] = 10;
            Assert.AreEqual(10, array[1]);
        }


        //не создаются ли копии при изменении и отображаются в исходном массиве
        [TestMethod]
        public void IndexersDoesNotCopyArray()
        {
            var indexers1 = new Indexer<int>(array, 1, 2);
            var indexers2 = new Indexer<int>(array, 0, 2);
            indexers1[0] = 100500;
            Assert.AreEqual(100500, indexers2[1]);
        }


        //при неверных аргументах
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailWithWrongArguments1()
        {
            Assert.Equals(typeof(ArgumentException), new Indexer<int>(array, -1, 3));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailWithWrongArguments2()
        {
            Assert.Equals(typeof(ArgumentException), new Indexer<int>(array, 1, -1));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailWithWrongArguments3()
        {
            Assert.Equals(typeof(ArgumentException), new Indexer<int>(array, 1, 10));
        }


        //при неверных индексах
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void FailWithWrongIndexing1()
        {
            var indexers = new Indexer<int>(array, 1, 2);
            Assert.Equals(typeof(IndexOutOfRangeException), indexers[-1]);
        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void FailWithWrongIndexing2()
        {
            var indexers = new Indexer<int>(array, 1, 2);
            Assert.AreNotEqual(typeof(IndexOutOfRangeException), indexers[10]);
        }
    }
}
