using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Comparers
{
	/// <summary>
	/// A comparer that wraps the IComparable interface to reproduce the opposite comparison result.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class ReverseComparer<T> : IComparer<T>
	{
		#region Globals

		private IComparer<T> comparerToUse;

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="ReverseComparer&lt;T&gt;"/> class.
		/// </summary>
		public ReverseComparer()
		{
			comparerToUse = Comparer<T>.Default;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ReverseComparer&lt;T&gt;"/> class.
		/// </summary>
		/// <param name="comparer">The comparer to reverse.</param>
		public ReverseComparer(IComparer<T> comparer)
		{
			if (comparer == null) {
				throw new ArgumentNullException("comparer");
			}

			comparerToUse = comparer;
		}

		#endregion

		#region IComparer<T> Members

		/// <summary>
		/// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
		/// </summary>
		/// <param name="x">The first object to compare.</param>
		/// <param name="y">The second object to compare.</param>
		/// <returns>
		/// Value Condition Less than zerox is less than y.Zerox equals y.Greater than zerox is greater than y.
		/// </returns>
		public int Compare(T x, T y)
		{
			return (comparerToUse.Compare(y, x));
		}

		#endregion
	}
}
