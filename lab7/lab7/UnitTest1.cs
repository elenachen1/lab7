using NUnit.Framework;
using System;

namespace lab7
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            int x = 103;
            int y = Calk.Plus(3, 100);

            Assert.AreEqual(x, y, " x = {0} , y = {1}", x, y);
            Assert.IsTrue(x == y , " x = {0} , y = {1}",x ,y);
        }

        [TestCase(10,5,5, TestName = "test 2")]
        [TestCase(10, 1, 9, TestName = "test 3")]
        [TestCase(10, 10, 0, TestName = "test 4")]
        [TestCase(10, 15, -5, TestName = "test 5")]
        public void Test2(int x, int y , int z)
        {
            int res = Calk.Sub( x, y);
            Assert.AreEqual(z, res);
        }

        [Test,TestCaseSource("MulCase")]
        public void Test3(int x, int y, int z)
        {
            int res = Calk.Mul(x, y);
            Assert.AreEqual(z, res);
        }
        static object[] MulCase =
        {
            new object[]  { 1,2,2},
            new object[]  { 1,0,0},
            new object[]  { 10,20,200},
            new object[]  { 10,-2,-20}
            
        };
        [Test, TestCaseSource("DivCase")]
        public void Test4(int x, int y, int z)
        {
            int res = Calk.Div(x, y);
            Assert.AreEqual(z, res);
        }
        static object[] DivCase =
        {
            new object[]  { 2,1,2},
            new object[]  { 1,0,404},
            new object[]  { 10,10,1},
            new object[]  { 10,-2,-5}

        };
    }
}