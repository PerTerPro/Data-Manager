
/*
 * Adapted from http://www.cs.rit.edu/~atk/Java/Sorting/sorting.html
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
	/// <summary>
	/// An OddEvenTransport sorter.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class OddEvenTransportSorter<T> : Sorter<T>
	{
		#region Sorter<T> Members

		/// <summary>
		/// Sorts the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="comparer">The comparer to use in comparing items.</param>
		public override void Sort(IList<T> list, IComparer<T> comparer) {
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}

			if (comparer == null) {
				throw new ArgumentNullException("comparer");
			}

			if (list.Count < 2)
			{
				return;
			}

			for (int i = 0; i < list.Count / 2; ++i)
			{
				for (int j = 0; j + 1 < list.Count; j += 2)
				{
					if (comparer.Compare(list[j], list[j + 1]) > 0)
					{
						this.Swap(list, j, j + 1);
					}
				}

				for (int j = 1; j + 1 < list.Count; j += 2)
				{
					if (comparer.Compare(list[j], list[j + 1]) > 0)
					{
						this.Swap(list, j, j + 1);
					}
				}
			}
		}

		#endregion
	}
}
