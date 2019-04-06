// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo.Tests
{
    using FxCopDemo;
    using Xunit;

    public class IEmptyInterfaceTests
    {
        /// <summary>
        /// Returns the correct name for a given number
        /// if exists.
        /// </summary>
        [Fact]
        public void GetNameReturnsTheNameIfExits()
        {
            var mockObject = new MockEmptyInterface();

            var actual = mockObject is IEmptyInterface;

            Assert.True(actual);
        }

        /// <summary>
        /// Implements a mock class.
        /// </summary>
        private class MockEmptyInterface
            : IEmptyInterface
        {
            /// <summary>
            /// Returns the name of the mock object.
            /// </summary>
            /// <returns>The name of mock object.</returns>
            public string GetName()
            {
                return "Mockup Empty Interface";
            }
        }
    }
}
