using System;
using Xunit;

namespace fizzbuzz
{
    public class UnitTest1
    {
        [Fact]
        public void divisibleBy3ReturnFizz()
        {
            var result = new fizzbuzz().check(3);
            Assert.Equal("fizz", result);

        }

        [Fact]
        public void given1return1()
        {
            var result = new fizzbuzz().check(1);
            Assert.Equal("1", result);

        }

        [Fact]
        public void given2return2()
        {
            var result = new fizzbuzz().check(2);
            Assert.Equal("2", result);

        }




    }
}
