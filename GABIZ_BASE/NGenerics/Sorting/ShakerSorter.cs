using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
	/// <summary>
	/// A Shaker Sorter.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class ShakerSorter<T> : Sorter<T>
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

			if (list.Count < 2) {
				return;
			}

			int i;
			int j;
			int k;
			int min;
			int max;

			i = 0;
			k = list.Count - 1;
			
			while (i < k)
			{
				min = i;
				max = i;
				
				for (j = i + 1; j <= k; j++)
				{
					if (comparer.Compare(list[j], list[min]) < 0)
					{
						min = j;
					}
					if (comparer.Compare(list[j], list[max]) > 0)
					{
						max = j;
					}
				}
				
				this.Swap(list, min, i);
				
				if (max == i)
				{
					this.Swap(list, min, k);
				}
				else
				{
					this.Swap(list, max, k);
				}
				
				i++;
				k--;
			}
		}

		#endregion
	}
}
