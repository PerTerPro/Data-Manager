using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.DataStructures
{
	/// <summary>
	/// A generic Singleton pattern implementation.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public static class Singleton<T> where T:new()
	{
		#region Globals

		private static T instance = new T();

		#endregion

		#region Public Members

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>The instance.</value>
		public static T Instance
		{
			get
			{
				return instance;
			}
			internal set
			{
				instance = value;
			}
		}
		
		#endregion
	}
}
