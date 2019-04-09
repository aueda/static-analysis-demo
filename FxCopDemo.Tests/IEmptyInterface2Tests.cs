// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo.Tests
{
    using FxCopDemo;
    using Xunit;

    public class IEmptyInterface2Tests
    {
        /// <summary>
        /// Tests if mock class implements interface.
        /// </summary>
        [Fact]
        public void TestsIfObjectImplementsInterface()
        {
            var mockObject = new MockEmptyInterface();

            var actual = mockObject is IEmptyInterface2;

            Assert.True(actual);
        }

        /// <summary>
        /// Implements a mock class.
        /// </summary>
        private class MockEmptyInterface
            : IEmptyInterface2
        {
        }
    }
}
