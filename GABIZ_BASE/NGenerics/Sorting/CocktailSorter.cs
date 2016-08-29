/*
 * Adapted from http://en.wikipedia.org/wiki/Cocktail_sort.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Sorting
{
    
	/// <summary>
	/// A Bi-Directional Bubble sorter.  
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class CocktailSorter<T> : Sorter<T>
	{
		#region Sorter<T> Members

		/// <summary>
		/// Sorts the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="comparer">The comparer.</param>
		public override void Sort(IList<T> list, IComparer<T> comparer) {

			if (list == null)
			{
				throw new ArgumentNullException("list");
			}

			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}

			if (list.Count < 2)
			{
				return;
			}

			int bottom = 0;
			int top = list.Count - 1;
			bool swapped = true; 
			
			while(swapped) 
			{
				swapped = false; 
				
				for(int i = bottom; i < top; i++)
				{
					if (comparer.Compare(list[i], list[i + 1]) > 0) 
					{
						this.Swap(list, i, i + 1);
						swapped = true;
					}
				}

				top--;

				for(int j = top; j > bottom; j--)
				{
					if(comparer.Compare(list[j], list[j - 1]) < 0) 
					{
						this.Swap(list, j, j - 1);
						swapped = true;
					}
				}

				bottom++;
			}
		}

		#endregion
	}
}
