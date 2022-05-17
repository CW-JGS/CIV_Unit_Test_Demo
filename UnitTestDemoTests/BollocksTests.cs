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

        [Fact]
        public void AddToTest()
        {
            Bollocks b = new Bollocks(10, "bollocks2");
            int sum = b.AddTo(10);
            Assert.Equal(20, sum);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 3, 3)]
         public void DivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks3");
            int result = b.DivBy(divisor);
            Assert.Equal(expected, result);
        }
        
        [Fact]
         public void DivBy_Zero_Test()
        {
            Bollocks b = new Bollocks(15, "bollocks4");
            try
            {
                int n = b.DivBy(0);
                Assert.True(false);
            }
            catch
            {
                
                Assert.True(true);
            }
        }

        [Fact]
        public void ModOfDivByTest()
        {
            Bollocks b = new Bollocks(55, "bollocks5");
            int n = b.ModBy(11);
            Assert.Equal(0, n);

        }
    }
}
