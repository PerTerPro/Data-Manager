using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.DataStructures;
using GABIZ.Base.NGenerics.Enumerations;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// An sorter for the Heap Sort algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public sealed class HeapSorter<T> : Sorter<T>
	{
		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="HeapSorter&lt;T&gt;"/> class.
		/// </summary>
		public HeapSorter() { }

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

			// TODO : Make this a real Heap Sort and not use the provided Heap<T> data structure.
			if (list.Count <= 1)
			{
				return;
			}

			Heap<T> heap = new Heap<T>(HeapType.MinHeap, list.Count, comparer);

			for (int i = 0; i < list.Count; i++)
			{
				heap.Add(list[i]);
			}

			for (int i = 0; i < list.Count; i++)
			{
				list[i] = heap.RemoveRoot();
			}
		}

		#endregion
	}
}
