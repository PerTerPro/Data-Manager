using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// A sorter that implements the Bucket Sort algorithm.
    /// </summary>
	public sealed class BucketSorter : Sorter<int>
	{
		#region Globals

		private int max;

		#endregion

		#region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketSorter"/> class.
        /// </summary>
        /// <param name="maxUniverse">The max universe.</param>
		public BucketSorter(int maxUniverse)
		{
			this.max = maxUniverse;
		}

		#endregion

		#region Sorter<T> Members

        /// <summary>
        /// Sorts the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="comparer">The comparer to use in comparing items.</param>
		public override void Sort(IList<int> list, IComparer<int> comparer)
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

			int maxIndex = max + 1;
			int[] counters = new int[maxIndex];

			for (int i = 0; i < list.Count; i++)
			{
				counters[list[i]]++;
			}

			int position = 0;
			

			for (int i = 0; i < maxIndex; i++)
			{
				for (int j = 0; j < counters[i]; j++)
				{
					list[position] = i;
					position++;
				}
			}
		}

		#endregion
	}
}
