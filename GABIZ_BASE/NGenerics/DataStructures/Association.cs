using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.DataStructures
{
	/// <summary>
	/// The Association performs the same function as a KeyValuePair, but allows the Key and 
	/// Value members to be written to.
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TValue"></typeparam>
	public sealed class Association<TKey, TValue>
	{
		#region Globals

		private TKey thisKey;
		private TValue thisValue;

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="Association&lt;TKey, TValue&gt;"/> class.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		public Association(TKey key, TValue value)
		{
			thisKey = key;
			thisValue = value;
		}

		#endregion

		#region Public Members

		/// <summary>
		/// Gets the key.
		/// </summary>
		/// <value>The key.</value>
		public TKey Key
		{
			get
			{
				return thisKey;
			}
			set
			{
				thisKey = value;
			}
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		public TValue Value
		{
			get
			{
				return thisValue;
			}
			set
			{
				thisValue = value;
			}
		}

        /// <summary>
        /// Construct a KeyValuePair object from the current values.
        /// </summary>
        /// <returns>A key value pair representation of this Association.</returns>
        public KeyValuePair<TKey, TValue> ToKeyValuePair()
        {
            return new KeyValuePair<TKey, TValue>(thisKey, thisValue);
        }

		#endregion
	}
}
