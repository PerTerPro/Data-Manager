using System;
using System.Collections.Generic;
using System.Text;

using GABIZ.Base.NGenerics.Misc;

namespace GABIZ.Base.NGenerics.Algorithms.Math
{
	/// <summary>
	/// A class using Euclid's algorithm for providing the greatest common divisor.
	/// </summary>
	public static class Euclid
	{
		#region Public Methods

        /// <summary>
        /// Finds the greatest common divisor.
        /// </summary>
        /// <param name="x">The first number.  Must be larger than y.</param>
        /// <param name="y">The second number</param>
        /// <returns>The greatest common divisor between the two integers supplied.</returns>
		public static int FindGreatestCommonDivisor(int x, int y)
		{
			if ((y < 0) || (x < 0))
			{
				throw new ArgumentException(Resources.NumbersGreaterThanZero);
			}

			// This algorithm only works if x >= y.
			// If x < y, swap the two variables.
			if (x < y)
			{
				int tmp = x;
				x = y;
				y = tmp;
			}			

			return FindGreatestCommonDivisorInternal(x, y);
		}

		#endregion

		#region Private Members

		private static int FindGreatestCommonDivisorInternal(int x, int y)
		{
			if (y == 0)
			{
				return x;
			}
			else
			{
				return FindGreatestCommonDivisorInternal(y, x % y);
			}
		}
			
		#endregion

	}
}
