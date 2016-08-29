using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.Visitors;

namespace GABIZ.Base.NGenerics.DataStructures
{
    /// <summary>
    /// The IVisitable interface provides data structures a method of allowing a visitor
    /// to visit every object contained in the structure.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public interface IVisitable<T>
	{
		/// <summary>
		/// Accepts the specified visitor.
		/// </summary>
		/// <param name="visitor">The visitor.</param>
		void Accept(IVisitor<T> visitor);
	}
}
