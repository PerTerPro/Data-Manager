using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.DataStructures;

namespace GABIZ.Base.NGenerics.Comparers
{
    /// <summary>
    /// A comparer for comparing keys using the Association class.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
	public sealed class AssociationKeyComparer<TKey, TValue> : IComparer<Association<TKey, TValue>> where TKey : IComparable
	{
		#region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationKeyComparer&lt;TKey, TValue&gt;"/> class.
        /// </summary>
		public AssociationKeyComparer()
		{

		}

		#endregion

		#region IComparer<Association<TKey,TValue>> Members

        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>
        /// Value Condition Less than zerox is less than y.Zerox equals y.Greater than zerox is greater than y.
        /// </returns>
		public int Compare(Association<TKey, TValue> x, Association<TKey, TValue> y)
		{
			return x.Key.CompareTo(y.Key);
		}

		#endregion
	}
}
