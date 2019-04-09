// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo
{
    using System.Diagnostics.CodeAnalysis;

    // Example 4: FxCop will not throw a CA1040 warning.
    // Implements an empty interface but FxCop will not
    // throw an exception because it was told to ignore
    // it using the SuppressMessage attribute.

    /// <summary>
    /// Empty interface for demo purposes.
    /// </summary>
    /// <remarks>
    /// Set DISABLE_FIXES to see FxCop in action.
    /// FxCop will throw the CA1040 warning.
    /// </remarks>
#if !DISABLE_FIXES
    [SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces")]
#endif
    public interface IEmptyInterface2
    {
    }
}