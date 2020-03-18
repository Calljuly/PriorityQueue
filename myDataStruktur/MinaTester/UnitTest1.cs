using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStruktur;




namespace MinaTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SwoopsDataTheRightWay()
        {
            MyPriorityQueue sut = new MyPriorityQueue();
            sut.Add(8);
            sut.Add(2);

            int actual = sut.Peek();

            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void CountReturnsRightValue()
        {
            MyPriorityQueue sut = new MyPriorityQueue();
            sut.Add(8);
            sut.Add(2);

            int actual = sut.Count();

            Assert.AreEqual(2, actual);
        }
        public void PopOneValue()
        {
            MyPriorityQueue sut = new MyPriorityQueue();
            sut.Add(8);
            sut.Add(2);
            sut.Pop();

            int actual = sut.Peek();

            Assert.AreEqual(8, actual);
        }
        public void PopTwoValues()
        {
            MyPriorityQueue sut = new MyPriorityQueue();
            sut.Add(8);
            sut.Add(2);
            sut.Pop();
            sut.Pop();

            int actual = sut.Count();

            Assert.AreEqual(0, actual);
        }
    }
}
