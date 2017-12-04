/**
 * MergeSortingAlgorithm.cs
 * 
 * Based on Merge Sorting C implementation from TutorialsPoint:
 * https://www.tutorialspoint.com/data_structures_algorithms/merge_sort_program_in_c.htm
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
    ///     Provides implementation of <see cref="ISortingAlgorithm"/> for Merge Sorting.
    /// </para>
    /// </summary>
    public class MergeSortingAlgorithm : ISortingAlgorithm
    {
        #region ISortingAlgorithm

        public void Sort<T>(T[] source) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            if (source.Length <= 1)
                return;

            var temporary = new T[source.Length];
            SortInternal(source, temporary, 0, source.Length - 1);
        }

        #endregion

        #region Helpers

        private void SortInternal<T>(T[] source, T[] temporary, int leftIndex, int rightIndex)
            where T : IComparable, IComparable<T>, IEquatable<T>
        {
            if (leftIndex >= rightIndex)
                return;

            int midIndex = (leftIndex + rightIndex) / 2;

            SortInternal(source, temporary, leftIndex, midIndex);
            SortInternal(source, temporary, midIndex + 1, rightIndex);

            MergeInternal(source, temporary, leftIndex, midIndex, rightIndex);
        }

        private void MergeInternal<T>(T[] source, T[] temporary, int leftIndex, int midIndex, int rightIndex)
            where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int i;
            int j = midIndex + 1;
            int k = (i = leftIndex);
            
            for (; i <= midIndex && j <= rightIndex; k++)
            {
                if (source[i].IsLesserThanOrEqual(source[j]))
                {
                    temporary[k] = source[i++];
                }
                else
                {
                    temporary[k] = source[j++];
                }
            }

            while (i <= midIndex)
            {
                temporary[k++] = source[i++];
            }

            while (j <= rightIndex)
            {
                temporary[k++] = source[j++];
            }

            for (k = leftIndex; k <= rightIndex; k++)
            {
                source[k] = temporary[k];
            }
        }

        #endregion
    }
}
