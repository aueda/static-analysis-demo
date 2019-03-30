// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo
{
    using System.Collections.Generic;

#if !DISABLE_FIXES
    using System.Globalization;
#endif

    /// <summary>
    /// Implements methods to convert numbers to string.
    /// </summary>
    public static class ConvertHelper
    {
        /// <summary>
        /// Initializes the <see cref="ConvertHelper"/> class.
        /// </summary>
        static ConvertHelper()
        {
#if DISABLE_FIXES
            names = new Dictionary<int, string>
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }            
            };
#endif
        }

        /// <summary>
        /// Gets or sets the helper name.
        /// </summary>
#if DISABLE_FIXES
        private static IDictionary<int, string> names;
#else
        private static IDictionary<int, string> names =
            new Dictionary<int, string>
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }            
            };
#endif

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

        /// <summary>
        /// Gets the name of the number.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetName(int value)
        {
            return names.ContainsKey(value)
                ? names[value]
                : string.Empty;
        }
    }
}
