/**
 * ShellSortingAlgorithm.cs
 * 
 * Based on Python implementation of Shell Sort from
 * http://interactivepython.org/runestone/static/pythonds/SortSearch/TheShellSort.html
 * 
 * Author:      Denis Belikov (https://github.com/belikovd)
 * 
 */
namespace DotNetBasics.Library.Sorting
{
    #region Usings

    using Common.Extensions;
    using Common.Interfaces;
    using System;
    using System.Linq;

    #endregion

    /// <summary>
    /// <para>
    ///     Provides implementation of <see cref="ISortingAlgorithm"/> for Shell Sorting.
    /// </para>
    /// </summary>
    public class ShellSortingAlgorithm : ISortingAlgorithm
    {
        #region ISortingAlgorithm

        public void Sort<T>(T[] source) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int subArraySize = source.Length / 2;

            while (subArraySize > 0)
            {
                foreach (int startPosition in Enumerable.Range(0, subArraySize))
                {
                    SortInternal(source, startPosition, subArraySize);
                }

                subArraySize = subArraySize / 2;
            }
        }

        #endregion

        #region Helpers

        private void SortInternal<T>(T[] source, int startPosition, int subArraySize) 
            where T : IComparable, IComparable<T>, IEquatable<T>
        {
            for (int i = startPosition + subArraySize; i < source.Length; i++)
            {
                T currentValue = source[i];
                int position = i;

                while (position >= subArraySize && source[position - subArraySize].IsGreaterThan(currentValue))
                {
                    source[position] = source[position - subArraySize];
                    position = position - subArraySize;
                }

                source[position] = currentValue;
            }
        }

        #endregion
    }
}
