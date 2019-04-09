// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Empty interface for demo purposes.
    /// </summary>
#if !DISABLE_FIXES
    [SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces")]
#endif
    public interface IEmptyInterface2
    {
    }
}