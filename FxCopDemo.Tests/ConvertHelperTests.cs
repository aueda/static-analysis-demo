// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo.Tests
{
    using FxCopDemo;
    using Xunit;

    public class ConvertHelperTests
    {
        /// <summary>
        /// Converts the number to a string.
        /// </summary>
        /// <param name="input">The input number.</param>
        /// <param name="expected">The expected string.</param>
        [InlineData(255, "255")]
        [InlineData(1, "1")]
        [Theory]
        public void ConvertoToStringReturnsIntAsString(
            int input,
            string expected)
        {
            var actual = ConvertHelper.ConvertToString(input);

            Assert.Equal(expected, actual);
        }
    }
}
