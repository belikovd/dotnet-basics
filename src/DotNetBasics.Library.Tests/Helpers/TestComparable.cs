/**
 * TestComparable.cs
 * 
 * Author:      Denis Belikov (https://github.com/belikovd)
 * License:     See LICENSE.txt in the project root for more information.
 * 
 */
using System;

namespace DotNetBasics.Library.Tests.Helpers
{
    /// <summary>
    /// <para>
    ///     Represents a simple class implementing <see cref="IComparable"/> interfaces.
    /// </para>
    /// </summary>
    public class TestComparable : IComparable, IComparable<TestComparable>, IEquatable<TestComparable>
    {
        #region Properties

        public int Number { get; }

        #endregion

        #region .ctor

        public TestComparable(int number)
        {
            Number = number;
        }

        #endregion

        #region IComparable

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            var otherTestComparable = obj as TestComparable;

            if (otherTestComparable == null)
                throw new ArgumentException($"Specified value does not represent a {nameof(TestComparable)} object.");

            return Number.CompareTo(otherTestComparable.Number);
        }

        #endregion

        #region IComparable<TestComparable>

        public int CompareTo(TestComparable other)
        {
            if (other == null)
                return 1;

            return Number.CompareTo(other.Number);
        }        

        public static bool operator > (TestComparable instance1, TestComparable instance2)
        {
            return instance1.CompareTo(instance2) > 0;
        }

        public static bool operator < (TestComparable instance1, TestComparable instance2)
        {
            return instance1.CompareTo(instance2) < 0;
        }

        public static bool operator >= (TestComparable instance1, TestComparable instance2)
        {
            return instance1.CompareTo(instance2) >= 0;
        }

        public static bool operator <= (TestComparable instance1, TestComparable instance2)
        {
            return instance1.CompareTo(instance2) <= 0;
        }

        #endregion

        #region IEquatable<TestComparable>

        public bool Equals(TestComparable other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.Number == other.Number)
                return true;

            return false;
        }

        public static bool operator == (TestComparable instance1, TestComparable instance2)
        {
            if (((object)instance1) == null || ((object)instance2) == null)
            {
                return object.Equals(instance1, instance2);
            }

            return instance1.Equals(instance2);
        }

        public static bool operator != (TestComparable instance1, TestComparable instance2)
        {
            if (((object)instance1) == null || ((object)instance2) == null)
            {
                return !object.Equals(instance1, instance2);
            }

            return !instance1.Equals(instance2);
        }

        #endregion

        #region Object Overrides

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var objAsTestComparable = obj as TestComparable;

            if (objAsTestComparable == null)
            {
                return false;
            }

            return Equals(objAsTestComparable);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        #endregion
    }
}
