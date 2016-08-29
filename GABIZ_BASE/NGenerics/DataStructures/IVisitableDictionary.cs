using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.DataStructures
{
    /// <summary>
    /// An Interface for the combining the IDictionary and IVisitableCollection interface.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
	public interface IVisitableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IComparable, IVisitableCollection<KeyValuePair<TKey, TValue>>
	{
		
	}
}
