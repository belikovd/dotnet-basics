/**
 * SelectionSortingtAlgorithm.cs
 * 
 * Author:      Denis Belikov (https://github.com/belikovd)
 * License:     See LICENSE.txt in the project root for more information.
 * 
 */
namespace DotNetBasics.Library.Sorting
{
    #region Usings

    using Common.Interfaces;
    using System;

    #endregion

    /// <summary>
    ///     Provides implementation of <see cref="ISortingAlgorithm"/> for Selection Sorting.
    /// </summary>
    public class SelectionSortingtAlgorithm : ISortingAlgorithm
    {
        #region ISortingAlgorithm

        public void Sort<T>(T[] source) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int currentIndex, lastIndex = source.Length - 1;
            T tmpElement;

            for (int i = 0; i <= lastIndex; i++)
            {
                currentIndex = i;

                for (int j = i + 1; j <= lastIndex; j++)
                {
                    int comparisonValue = source[j].CompareTo(source[currentIndex]);

                    if (comparisonValue < 0)
                    {
                        currentIndex = j;
                    }
                }

                tmpElement = source[i];
                source[i] = source[currentIndex];
                source[currentIndex] = tmpElement;
            }
        }

        #endregion
    }
}
