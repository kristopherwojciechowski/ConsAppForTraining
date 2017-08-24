using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            //arrange
            int a = 11;
            int b = 7;
            //act
            String wynik = MyMath.WiekszeMniejsze(a, b);
            //assert
            Assert.Equal("11>7",wynik);
        }
    }
}
