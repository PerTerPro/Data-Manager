using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// A sorter implementing the Gnome sort algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public sealed class GnomeSorter<T> : Sorter<T>
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

			if (list.Count <= 1)
			{
				return;
			}

			int i = 1;

			while (i < list.Count)
			{
				if (comparer.Compare(list[i - 1], list[i]) <= 0)
				{
					i++;
				}
				else
				{
					Swap(list, i - 1, i);

					if (i > 1)
					{
						i--;
					}					
				}
			}
		}

		#endregion
	}
}
