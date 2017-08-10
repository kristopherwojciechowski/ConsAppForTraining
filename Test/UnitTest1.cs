using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 7;

            String wynik = MyMath.WiekszeMniejsze(a, b);

            Assert.ReferenceEquals("5<7",wynik);
        }
    }
}
