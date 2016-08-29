using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.Comparers;

namespace GABIZ.Base.NGenerics.Sorting
{
    /// <summary>
    /// The base class used for all Sorters in the library.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public abstract class Sorter<T> : ISorter<T>
	{
		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="Sorter&lt;T&gt;"/> class.
		/// </summary>
		protected Sorter()
		{
			
		}		

		#endregion
								
		#region ISorter<T> Members

		/// <summary>
		/// Sorts the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="comparer">The comparer to use in comparing items.</param>
		public abstract void Sort(IList<T> list, IComparer<T> comparer);

        /// <summary>
        /// Sorts the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="comparison">The comparison to use.</param>
        public void Sort(IList<T> list, Comparison<T> comparison)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }

            if (comparison == null)
            {
                throw new ArgumentNullException("comparison");
            }

            Sort(list, new ComparisonComparer<T>(comparison));
        }


		/// <summary>
		/// Sorts the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		public void Sort(IList<T> list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}

			Sort(list, Comparer<T>.Default);
		}

        /// <summary>
        /// Sorts the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="order">The order in which to sort the list.</param>
		public void Sort(IList<T> list, SortOrder order)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}

			if (order == SortOrder.Ascending)
			{
				Sort(list, Comparer<T>.Default);
			}
			else if (order == SortOrder.Descending)
			{
				Sort(list, new ReverseComparer<T>(Comparer<T>.Default));
			}
		}

		#endregion

		#region Protected Members

		/// <summary>
		/// Swaps items in the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="pos1">The position of the first item.</param>
		/// <param name="pos2">The position of the last item.</param>
		protected void Swap(IList<T> list, int pos1, int pos2)
		{
			T tmp = list[pos1];
			list[pos1] = list[pos2];
			list[pos2] = tmp;
		}
		
		#endregion
	}
}
