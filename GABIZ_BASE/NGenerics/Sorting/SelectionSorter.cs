using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// A sorter implemeting the Selection Sort algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public sealed class SelectionSorter<T> : Sorter<T>
	{
		#region Globals

		/// <summary>
		/// Initializes a new instance of the <see cref="SelectionSorter&lt;T&gt;"/> class.
		/// </summary>
		public SelectionSorter() { }

		#endregion

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
			
			if (list.Count <= 1)
			{
				return;
			}

			int minIndex;

			for (int i = 0; i < list.Count; i++)
			{
				minIndex = i;

				// Find the smallest item in what's left of the array
				for (int j = i + 1; j < list.Count; j++)
				{
					if (comparer.Compare(list[j], list[minIndex]) < 0)
					{
						minIndex = j;
					}
				}

				// Swap the minimum and the current item at index i.
				Swap(list, i, minIndex);
			}
		}

		#endregion
	}
}
