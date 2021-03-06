﻿namespace Machete
{
    using System;


    /// <summary>
    /// A layout defines a series of entities which compose a structure
    /// </summary>
    public interface Layout
    {
        /// <summary>
        /// The layout type
        /// </summary>
        Type LayoutType { get; }
    }


    public interface Layout<out TLayout> :
        ILayout
        where TLayout : Layout
    {
        /// <summary>
        /// The layout value
        /// </summary>
        TLayout Value { get; }
    }
}