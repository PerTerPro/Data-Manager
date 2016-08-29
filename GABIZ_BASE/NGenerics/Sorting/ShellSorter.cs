using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// A sorter that implements the Shell Sort algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public sealed class ShellSorter<T> : Sorter<T>
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

			int delta = list.Count;

			do
			{
				delta = 1 + (delta / 3);

				for (int i = 0; i < delta; i++)
				{
					int counter = delta + i;

					// Insertion sort the segments
					while (counter < list.Count)
					{
						int start = counter;
						T tmp = list[start];
					
						while (start != i)
						{
							if (comparer.Compare(list[start - delta], tmp) > 0)
							{
								list[start] = list[start - delta];
								start -= delta;
							}
							else
							{
								break;
							}
						}

						list[start] = tmp;
						counter += delta;
					}
				}
			}
			while (delta > 1);
		}

		#endregion
	}
}
