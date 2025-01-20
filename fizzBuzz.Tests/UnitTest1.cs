using fizzBuzz;
using Xunit;

namespace fizzBuzz.Tests
{
    public class FizzBuzzHelperTests
    {
        [Fact]
        public void GetFizzBuzz_ReturnsFizz_WhenDivisibleBy3()
        {
            Assert.Equal("Fizz", FizzBuzzHelper.GetFizzBuzz(6));
        }

        [Fact]
        public void GetFizzBuzz_ReturnsBuzz_WhenDivisibleBy5()
        {
            Assert.Equal("Buzz", FizzBuzzHelper.GetFizzBuzz(10));
        }

        [Fact]
        public void GetFizzBuzz_ReturnsFizzBuzz_WhenDivisibleBy15()
        {
            Assert.Equal("FizzBuzz", FizzBuzzHelper.GetFizzBuzz(30));
        }
    }
}