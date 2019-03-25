#if !DISABLE_FIXES
// Copyright (c) Adriano Ueda. All rights reserved.
#endif

namespace StyleCopDemo
{
    /// <summary>
    /// Implements help methods to sum numbers.
    /// </summary>
    public static class SumHelper
    {
        /// <summary>
        /// Adds two integer numbers.
        /// </summary>
        /// <param name="leftNumber">The first number.</param>
        /// <param name="rightNumber">The second number.</param>
        /// <returns>A integer result.</returns>
#if DISABLE_FIXES
        public static int AddTwoNumbers(int leftNumber,
            int rightNumber)
#else
        public static int AddTwoNumbers(
            int leftNumber,
            int rightNumber)
#endif
        {
            var result = 0;

#if DISABLE_FIXES
            //returns the sum of the numbers
#else
            // returns the sum of the numbers
#endif
            unchecked
            {
#if DISABLE_FIXES
                result = leftNumber+rightNumber;
#else
                result = leftNumber + rightNumber;
#endif
            }

            return result;
        }
    }
}