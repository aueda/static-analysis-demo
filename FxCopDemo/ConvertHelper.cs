// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo
{
#if !DISABLE_FIXES
    using System.Globalization;
#endif

    /// <summary>
    /// Implements methods to convert numbers to string.
    /// </summary>
    public static class ConvertHelper
    {
        /// <summary>
        /// Converts an integer number to a string.
        /// </summary>
        /// <param name="value">The integer number.</param>
        /// <returns>A string version of the number.</returns>
        public static string ConvertToString(int value)
        {
#if DISABLE_FIXES
            return value.ToString();
#else
            return value.ToString(CultureInfo.InvariantCulture);
#endif
        }
    }
}
