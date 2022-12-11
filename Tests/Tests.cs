using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var a = 1; 
            var b = 2;
            Assert.Equal(3, a + b);
        }
        [Fact]
        public void Test2()
        {
            var a = 3;
            var b = 4;
            Assert.Equal(7, a + b);
        }
        [Fact]
        public void Test3()
        {
            var a = 20;
            var b = 7;
            Assert.Equal(13, a - b);
        }
    }
}
