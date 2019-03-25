// Copyright (c) Adriano Ueda. All rights reserved.

namespace StyleCopDemo.Tests
{
    using Xunit;

    public class SumHelperTests
    {
        [Fact]
        public void AddTwoNumbersReturnsExpectedSum()
        {
            var expected = 31;

            var actual = SumHelper.AddTwoNumbers(10, 21);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTwoNumbersOverflowsIfNumbersAreMaxValue()
        {
            var expected = -2;

            var actual = SumHelper.AddTwoNumbers(int.MaxValue, int.MaxValue);

            Assert.Equal(expected, actual);
        }
    }
}
