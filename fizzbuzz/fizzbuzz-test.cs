using System;
using System.Linq;
using Xunit;

namespace fizzbuzz
{
    public class UnitTest1
    {
       
       
        [Theory]
        [InlineData(3, "fizz")]

        [InlineData(1, "1")]

        [InlineData(5, "buzz")]

        [InlineData(15, "fizzbuzz")]


        public void fizztests(int input, string expected)
        {
            var result = new fizzbuzz().check(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void fizzybuzzarray()
        {
            var numbers = Enumerable.Range(1,20).ToArray();
            var result = new fizzbuzz().check(numbers);
            Assert.Equal("1,2,fizz,4,buzz,fizz,7,8,fizz,buzz,11,fizz,13,14,fizzbuzz,16,17,fizz,19,buzz", result);
        }
    }
}
