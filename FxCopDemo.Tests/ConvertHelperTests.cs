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

        /// <summary>
        /// Returns the correct name for a given number
        /// if exists.
        /// </summary>
        [Fact]
        public void GetNameReturnsTheNameIfExists()
        {
            var actual = ConvertHelper.GetName(1);
            var expected = "one";

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Returns an empty for a given number
        /// if not exists.
        /// </summary>
        [Fact]
        public void GetNameReturnsTheNameIfNotExists()
        {
            var actual = ConvertHelper.GetName(15);
            var expected = string.Empty;

            Assert.NotNull(actual);
            Assert.Equal(expected, actual);
        }
    }
}
