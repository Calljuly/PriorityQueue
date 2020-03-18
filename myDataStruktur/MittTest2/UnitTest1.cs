using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datastruktur;

namespace MittTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SwoopsDataTheRightWay()
        {
            MyPriorityQueue<int> sut = new MyPriorityQueue<int>();
            sut.Add(8);
            sut.Add(2);

            int actual = sut.Peek();

            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void CountReturnsRightValue()
        {
            MyPriorityQueue<int> sut = new MyPriorityQueue<int>();
            sut.Add(8);
            sut.Add(2);

            int actual = sut.Count();

            Assert.AreEqual(2, actual);
        }
        [TestMethod]

        public void PopOneValue()
        {
            MyPriorityQueue<int> sut = new MyPriorityQueue<int>();
            sut.Add(8);
            sut.Add(2);
            sut.Pop();

            int actual = sut.Peek();

            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void PopTwoValues()
        {
            MyPriorityQueue<int> sut = new MyPriorityQueue<int>();
            sut.Add(8);
            sut.Add(2);
            sut.Pop();
            sut.Pop();

            int actual = sut.Count();

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void AddNegativeValues()
        {
            MyPriorityQueue<int> sut = new MyPriorityQueue<int>();
            sut.Add(-8);
            sut.Add(-2);

            int actual = sut.Peek();

            Assert.AreEqual(-8, actual);
        }

        [TestMethod]
        public void AddloadsOfValues_IfCountIsRight()
        {
            MyPriorityQueue<int> sut = new MyPriorityQueue<int>();
            
            for(int i = 0; i < 1000; i++)
            {
                sut.Add(i);
            }

            int actual = sut.Count();

            Assert.AreEqual(1000, actual);
        }
        [TestMethod]
        public void AddLettersBigAndSmall()
        {
            MyPriorityQueue<string> sut = new MyPriorityQueue<string>();

            sut.Add("A");
            sut.Add("a");

            string actual = sut.Peek();

            Assert.AreEqual("a", actual);
        }
        [TestMethod]
        public void AddLoadsOfLettersBigAndSmall()
        {
            MyPriorityQueue<string> sut = new MyPriorityQueue<string>();

            sut.Add("y");
            sut.Add("Y");
            sut.Add("a");
            sut.Add("A");
            sut.Add("j");
            sut.Add("L");
            sut.Add("R");
            sut.Add("r");
            sut.Add("B");


            string actual = sut.Peek();

            Assert.AreEqual("a", actual);
        }
        [TestMethod]
        public void AddLoadsOfLettersBigAndSmallAndPop()
        {
            MyPriorityQueue<string> sut = new MyPriorityQueue<string>();

            sut.Add("y");
            sut.Add("Y");
            sut.Add("a");
            sut.Add("A");
            sut.Add("j");
            sut.Add("L");
            sut.Add("R");
            sut.Add("r");
            sut.Add("B");
            sut.Pop();
            sut.Pop();
            sut.Pop();

            string actual = sut.Peek();

            Assert.AreEqual("j", actual);
        }
    }
}

