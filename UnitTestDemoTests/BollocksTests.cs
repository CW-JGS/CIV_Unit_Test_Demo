using System;
using Xunit;
using UnitTestDemo;

namespace UnitTestDemoTests
{
    public class BollocksTests
    {
        [Fact]
        public void ConstructorTest()
        {
            Bollocks b = new Bollocks(5, "bollocks1");

            Assert.Equal(5, b.bollNum);
            Assert.Equal("bollocks1", b.bollString);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        public void AddToTest()
        {
            Assert.True(false);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 3, 3)]
         public void DivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks2");
            int result = b.DivBy(divisor);
            Assert.Equal(expected, result);
        }
        
        [Fact]
         public void DivBy_Zero_Test()
        {
            Assert.True(false);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        public void ModOfDivByTest()
        {
            Assert.True(false);
        }
    }
}
