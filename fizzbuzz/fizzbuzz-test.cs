using System;
using Xunit;

namespace fizzbuzz
{
    public class UnitTest1
    {
       
       
        [Theory]
        [InlineData(3, "fizz")]

        [InlineData(1, "1")]

        [InlineData(5, "buzz")]

        public void fizztests(int input, string expected)
        {
            var result = new fizzbuzz().check(input);
            Assert.Equal(expected, result);
        }
    }
}
