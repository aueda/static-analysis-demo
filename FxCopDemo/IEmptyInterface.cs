// Copyright (c) Adriano Ueda. All rights reserved.

namespace FxCopDemo
{
    /// <summary>
    /// Empty interface for demo purposes.
    /// </summary>
    public interface IEmptyInterface
    {
#if !DISABLE_FIXES
        /// <summary>
        /// Gets the property name.
        /// </summary>
        /// <returns>The name.</returns>
        string GetName();
#endif
    }
}
