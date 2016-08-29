using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// A Quick Sort sorter.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public sealed class QuickSorter<T> : Sorter<T>
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

			QuickSort(list, comparer, 0, list.Count - 1);
		}

		private void QuickSort(IList<T> list, IComparer<T> comparer, int leftBoundary, int rightBoundary)
		{
			// Check for overlapping boundaries
			if (leftBoundary < rightBoundary)
			{
				int pivotIndex = GetPivot(list, comparer, leftBoundary, rightBoundary);
				QuickSort(list, comparer, leftBoundary, pivotIndex - 1);
				QuickSort(list, comparer, pivotIndex + 1, rightBoundary);
			}
		}

		private int GetPivot(IList<T> list, IComparer<T> comparer, int leftBoundary, int rightBoundary)
		{
			int middle = (leftBoundary + rightBoundary) / 2;
			
			if (comparer.Compare(list[leftBoundary], list[rightBoundary]) < 0)
			{
				Swap(list, leftBoundary, rightBoundary);
			}

			if (comparer.Compare(list[middle], list[rightBoundary]) < 0)
			{
				Swap(list, middle, rightBoundary);
			}

			if (comparer.Compare(list[leftBoundary], list[middle]) > 0)
			{
				Swap(list, leftBoundary, middle);
			}

			int pivotIndex = leftBoundary;
			T pivot = list[pivotIndex];

			for (int i = leftBoundary + 1; i <= rightBoundary; i++)
			{
				if (comparer.Compare(list[i], pivot) < 0)
				{
					pivotIndex++;
					Swap(list, pivotIndex, i);
				}
			}

			Swap(list, leftBoundary, pivotIndex);

			return pivotIndex;
		}

		#endregion
	}
}
