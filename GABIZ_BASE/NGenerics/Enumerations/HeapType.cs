using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Enumerations
{
    /// <summary>
    /// The type of Heap to implemented.
    /// </summary>
	public enum HeapType
	{
        /// <summary>
        /// Makes the heap a Min-Heap - the smallest item is kept in the root of the heap.
        /// </summary>
		MinHeap,

        /// <summary>
        /// Makes the heap a Max-Heap - the largest item is kept in the root of the heap.
        /// </summary>
		MaxHeap
	}
}
