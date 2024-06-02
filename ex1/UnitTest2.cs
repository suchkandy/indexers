using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Indexers;

namespace ex1
{
    [TestClass]
    public class UnitTest2
    {
        int[,] array = new int[,] { {1,2, 3}, {3, 4, 5} };


        //верность возвращаемой длины массива по строкам
        [TestMethod]
        public void HaveCorrectLengthRows()
        {
            var indexers = new Indexers<int>(array, 2, 3, 2, 3);
            Assert.AreEqual(2, indexers.NLength);
        }

        //верность возвращаемой длины массива по колоннам
        [TestMethod]
        public void HaveCorrectLengthColommuns()
        {
            var indexers = new Indexers<int>(array, 2, 3, 2, 3);
            Assert.AreEqual(3, indexers.MLength);
        }

        //верность возвращаемой длины массива
        [TestMethod]
        public void HaveCorrectLength()
        {
            var indexers = new Indexers<int>(array, 2, 3, 2, 3);
            Assert.AreEqual(6, indexers.NLength * indexers.MLength);
        }


        //верность получаемых данных Indexers
        [TestMethod]
        public void GetCorrectly()
        {
            var indexers = new Indexers<int>(array, 2, 3, 2, 3);
            Assert.AreEqual(2, indexers[0, 0]);
            Assert.AreEqual(3, indexers[1, 2]);
        }


        //Indexers верно устанавливает элементы подмассива
        [TestMethod]
        public void SetCorrectly()
        {
            var indexers = new Indexers<int>(array, 2, 2, 2, 3);
            indexers[0, 0] = 10;
            Assert.AreEqual(10, array[0,0]);
        }


        //не создаются ли копии при изменении и отображаются в исходном массиве
        [TestMethod]
        public void IndexersDoesNotCopyArray()
        {
            var indexers1 = new Indexers<int>(array, 2, 2, 2, 3);
            var indexers2 = new Indexers<int>(array, 2, 2, 2, 3);
            indexers1[0, 0] = 100500;
            Assert.AreEqual(100500, indexers2[1, 1]);
        }


        //при неверных аргументах
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailWithWrongArguments1()
        {
            Assert.Equals(typeof(ArgumentException), new Indexers<int>(array, 2, 2, 4));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailWithWrongArguments2()
        {
            Assert.Equals(typeof(ArgumentException), new Indexers<int>(array, 2, 2, 4));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailWithWrongArguments3()
        {
            Assert.Equals(typeof(ArgumentException), new Indexers<int>(array, 2, 2, 4));
        }


        //при неверных индексах
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void FailWithWrongIndexing1()
        {
            var indexers = new Indexers<int>(array, 2, 2, 4);
            Assert.Equals(typeof(IndexOutOfRangeException), indexers[-1, -1]);
        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void FailWithWrongIndexing2()
        {
            var indexers = new Indexers<int>(array, 2, 2, 4);
            Assert.AreNotEqual(typeof(IndexOutOfRangeException), indexers[10, 10]);
        }
    }
}
