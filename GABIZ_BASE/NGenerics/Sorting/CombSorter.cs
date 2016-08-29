
/*
 * Adapted from wikipedia : http://en.wikipedia.org/wiki/Comb_sort
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
	/// <summary>
	/// A comb sorter.  
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class CombSorter<T> : Sorter<T>
	{
		#region Sorter<T> Members

		/// <summary>
		/// Sorts the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="comparer">The comparer to use in comparing items.</param>
		public override void Sort(IList<T> list, IComparer<T> comparer)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}

			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}

			if (list.Count < 2)
			{
				return;
			}

			int gap = list.Count;
			int swaps = 0;

			while (!((gap == 1) && swaps == 0))
			{
				if (gap > 1)
				{
					gap = (int)(gap / 1.3);

					if ((gap == 10) || (gap == 9))
					{
						gap = 11;
					}
				}

				int i = 0;

				while ((i + gap) != list.Count)
				{
					if (comparer.Compare(list[i], list[i + gap]) > 0)
					{
						this.Swap(list, i, i + gap);

					}
					i++;
				}
			}
		}

		#endregion
	}
}
