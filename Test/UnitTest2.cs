using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// test written in Microsoft.VisualStudio.TestTools.UnitTesting
/// </summary>
namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int a = 11;
            int b = 7;
            //act
            String wynik = MyMath.WiekszeMniejsze(a, b);
            //assert
            Assert.AreEqual("11>7", wynik);
        }
    }
}
