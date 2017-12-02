/**
 * ISortingAlgorithm.cs
 * 
 * Author:      Denis Belikov (https://github.com/belikovd)
 * 
 */
namespace DotNetBasics.Common.Interfaces
{
    #region Usings

    using System;

    #endregion

    #region Interface definition

    public interface ISortingAlgorithm
    {
        /// <summary>
        ///     Sorts the specified <paramref name="source"/> array.
        /// </summary>
        /// <typeparam name="T">
        ///     Type of array elements.
        /// </typeparam>
        /// <param name="source">
        ///     Array to sort.
        /// </param>
        void Sort<T>(T[] source) where T : IComparable, IComparable<T>, IEquatable<T>;
    }

    #endregion
}
