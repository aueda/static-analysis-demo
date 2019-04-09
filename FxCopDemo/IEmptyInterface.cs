// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo
{
    /// <summary>
    /// Empty interface for demo purposes.
    /// </summary>
    /// <remarks>
    /// Set DISABLE_FIXES to see FxCop in action.
    /// </remarks>
    public interface IEmptyInterface
    {
        // Example 3: FxCop will throw a CA1040 warning.
        // Implements an empty interface.
#if !DISABLE_FIXES
        /// <summary>
        /// Gets the property name.
        /// </summary>
        /// <returns>The name.</returns>
        string GetName();
#endif
    }
}
