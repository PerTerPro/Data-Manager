using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.DataStructures;

namespace GABIZ.Base.NGenerics.Comparers
{
	/// <summary>
	/// An wrapper around a standard IComparer to compare the values of Associations.
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TValue"></typeparam>
	public sealed class NestedAssociationValueComparer<TKey, TValue> : IComparer<Association<TKey, TValue>>
	{
		#region Globals

		IComparer<TValue> nestedComparer;

		#endregion

		#region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedAssociationValueComparer&lt;TKey, TValue&gt;"/> class.
        /// </summary>
        /// <param name="comparer">The nested comparer to use.</param>
		public NestedAssociationValueComparer(IComparer<TValue> comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}

			this.nestedComparer = comparer;
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
			return nestedComparer.Compare(x.Value, y.Value);
		}

		#endregion
	}
}
