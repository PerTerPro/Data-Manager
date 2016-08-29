using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Enumerations
{
    /// <summary>
    /// Specifies the Priority Queue type (min or max).
    /// </summary>
	public enum PriorityQueueType
	{
        /// <summary>
        /// Specify a Max Priority Queue.
        /// </summary>
		MinPriorityQueue = 0,

        /// <summary>
        /// Specify a Min Priority Queue.
        /// </summary>
		MaxPriorityQueue = 1
	}
}
