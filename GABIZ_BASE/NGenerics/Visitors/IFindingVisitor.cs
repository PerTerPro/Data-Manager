
using System;

namespace GABIZ.Base.NGenerics.Visitors
{
	interface IFindingIVisitor<T> : IVisitor<T>
	{
		bool Found { get; }
		T SearchValue { get; }
	}
}
