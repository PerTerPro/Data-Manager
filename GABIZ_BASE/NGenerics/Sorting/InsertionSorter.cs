using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// A sorter that implements the Insertion sort algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public sealed class InsertionSorter<T> : Sorter<T>
	{
		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="InsertionSorter&lt;T&gt;"/> class.
		/// </summary>
		public InsertionSorter() { }

		#endregion

		#region Private Members

		private void Insert(IList<T> list, int sortedSequenceLength, T val, IComparer<T> comparer) {
			int i = sortedSequenceLength - 1;

			while ((i >= 0) && (comparer.Compare(list[i], val) > 0))
			{
				list[i + 1] = list[i];
				i--;
			}

			list[i + 1] = val;
		}

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

			Sort(list, comparer, 0, list.Count - 1);
		}

        /// <summary>
        /// Sorts the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="comparer">The comparer.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
		public void Sort(IList<T> list, IComparer<T> comparer, int start, int end)
		{
			if (end - start + 1 <= 1)
			{
				return;
			}

			int counter = start;

			while (counter < end + 1)
			{
				Insert(list, counter, list[counter], comparer);
				counter++;
			}
		}

		#endregion
	}
}
