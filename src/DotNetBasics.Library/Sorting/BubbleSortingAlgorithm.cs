/**
 * BubbleSortingAlgorithm.cs
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
    /// <para>
    ///     Provides implementation of <see cref="ISortingAlgorithm"/> for Bubble Sorting.
    /// </para>
    /// </summary>
    public class BubbleSortingAlgorithm : ISortingAlgorithm
    {
        #region ISortingAlgorithm

        public void Sort<T>(T[] source) where T : IComparable, IComparable<T>, IEquatable<T>
        {
            T tempElement;
            int lastIndex = source.Length - 1;

            for (int i = lastIndex; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    int comparisonValue = source[j].CompareTo(source[j + 1]);

                    if (comparisonValue > 0)
                    {
                        tempElement = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = tempElement;
                    }
                }
            }
        }

        #endregion
    }
}
