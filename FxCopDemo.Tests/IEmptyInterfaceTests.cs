// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo.Tests
{
    using FxCopDemo;
    using Xunit;

    public class IEmptyInterfaceTests
    {
        /// <summary>
        /// Tests if mock class implements interface.
        /// </summary>
        [Fact]
        public void TestsIfObjectImplementsInterface()
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
