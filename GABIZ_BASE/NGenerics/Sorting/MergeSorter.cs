
/*
 * Adapted from CSSorters : http://web6.codeproject.com/cs/algorithms/cssorters.asp
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
	/// <summary>
	/// A merge sorter.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class MergeSorter<T> : Sorter<T>
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

			MergeSort(0, list.Count - 1, list, comparer); 
		}
		
		#endregion

		#region Private Members

        /// <summary>
        /// Perfroms a merge sort.
        /// </summary>
        /// <param name="leftBoundary">The left boundary.</param>
        /// <param name="rightBoundary">The right boundary.</param>
        /// <param name="list">The list.</param>
        /// <param name="comparer">The comparer.</param>
		private void MergeSort(int leftBoundary, int rightBoundary, IList<T> list, IComparer<T> comparer)
		{
			if (leftBoundary < rightBoundary)
			{
				int middle = (leftBoundary + rightBoundary) / 2;

				MergeSort(leftBoundary, middle, list, comparer);
				MergeSort(middle + 1, rightBoundary, list, comparer);

				while ((middle + 1 <= rightBoundary) && (leftBoundary <= middle))
				{
					if (comparer.Compare(list[leftBoundary], list[middle + 1]) < 0)
					{
						leftBoundary++;
					}
					else
					{
						T currentItem = list[middle + 1];

						for (int i = middle; i >= leftBoundary; i--)
						{
							list[i + 1] = list[i];
						}

						list[leftBoundary] = currentItem;
						leftBoundary++;
						middle++;
					}
				}
			}

		}

		#endregion
	}
}
