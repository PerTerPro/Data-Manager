using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// A Bubble Sorter.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public sealed class BubbleSorter<T> : Sorter<T>
	{
		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="BubbleSorter&lt;T&gt;"/> class.
		/// </summary>
		public BubbleSorter() { }

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

			for (int i = list.Count - 1; i >= 0; i--)
			{
				for (int j = 0; j < i; j++)
				{
					if (comparer.Compare(list[j], list[j + 1]) > 0)
					{
						Swap(list, j, j + 1);
					}
				}
			}
		}

		#endregion
	}
}
