/**
* InsertionSortingAlgorithm.cs
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

    #endregion

    /// <summary>
    /// <para>
    ///     Provides implementation of <see cref="ISortingAlgorithm"/> for Insertion Sorting.
    /// </para>
    /// </summary>
    public class InsertionSortingAlgorithm : ISortingAlgorithm
    {
        #region ISortingAlgorithm

        public void Sort<T>(T[] source) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            T tmpElement;
            int j, lastIndex = source.Length - 1;

            for (int i = 1; i <= lastIndex; i++)
            {
                tmpElement = source[i];
                j = i;

                while (j > 0 && source[j - 1].IsGreaterThanOrEqual(tmpElement))
                {
                    source[j] = source[j - 1];
                    j -= 1;
                }

                source[j] = tmpElement;
            }
        }

        #endregion
    }
}
