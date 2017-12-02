/**
 * ComparableExtensions.cs
 * 
 * Author:      Denis Belikov (https://github.com/belikovd)
 * 
 */
namespace DotNetBasics.Common.Extensions
{
    #region Usings

    using System;

    #endregion

    public static class ComparableExtensions
    {
        /// <summary>
        ///     Returns a value indicating whether a <paramref name="value"/> is greater than <paramref name="anotherValue"/>.
        /// </summary>
        /// <typeparam name="T">
        ///     Generic type of parameters. Should implement <see cref="IComparable"/>, <see cref="IComparable{T}"/> and <see cref="IEquatable{T}"/>.
        /// </typeparam>
        /// <param name="value">
        ///     Value to check.
        /// </param>
        /// <param name="anotherValue">
        ///     Value to check against.
        /// </param>
        /// <returns>
        ///     <see cref="bool"/>
        /// </returns>
        public static bool IsGreaterThan<T>(this T value, T anotherValue) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int comparisonValue = value.CompareTo(anotherValue);
            return comparisonValue > 0;
        }

        /// <summary>
        ///     Returns a value indicating whether a <paramref name="value"/> is greater than or equal to <paramref name="anotherValue"/>.
        /// </summary>
        /// <typeparam name="T">
        ///     Generic type of parameters. Should implement <see cref="IComparable"/>, <see cref="IComparable{T}"/> and <see cref="IEquatable{T}"/>.
        /// </typeparam>
        /// <param name="value">
        ///     Value to check.
        /// </param>
        /// <param name="anotherValue">
        ///     Value to check against.
        /// </param>
        /// <returns>
        ///     <see cref="bool"/>
        /// </returns>
        public static bool IsGreaterThanOrEqual<T>(this T value, T anotherValue) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int comparisonValue = value.CompareTo(anotherValue);
            return comparisonValue >= 0;
        }

        /// <summary>
        ///     Returns a value indicating whether a <paramref name="value"/> is lesser than <paramref name="anotherValue"/>.
        /// </summary>
        /// <typeparam name="T">
        ///     Generic type of parameters. Should implement <see cref="IComparable"/>, <see cref="IComparable{T}"/> and <see cref="IEquatable{T}"/>.
        /// </typeparam>
        /// <param name="value">
        ///     Value to check.
        /// </param>
        /// <param name="anotherValue">
        ///     Value to check against.
        /// </param>
        /// <returns>
        ///     <see cref="bool"/>
        /// </returns>
        public static bool IsLesserThan<T>(this T value, T anotherValue) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int comparisonValue = value.CompareTo(anotherValue);
            return comparisonValue < 0;
        }

        /// <summary>
        ///     Returns a value indicating whether a <paramref name="value"/> is lesser than or equal to <paramref name="anotherValue"/>.
        /// </summary>
        /// <typeparam name="T">
        ///     Generic type of parameters. Should implement <see cref="IComparable"/>, <see cref="IComparable{T}"/> and <see cref="IEquatable{T}"/>.
        /// </typeparam>
        /// <param name="value">
        ///     Value to check.
        /// </param>
        /// <param name="anotherValue">
        ///     Value to check against.
        /// </param>
        /// <returns>
        ///     <see cref="bool"/>
        /// </returns>
        public static bool IsLesserThanOrEqual<T>(this T value, T anotherValue) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int comparisonValue = value.CompareTo(anotherValue);
            return comparisonValue <= 0;
        }
    }
}
