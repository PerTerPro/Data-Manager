using System;
using System.Collections.Generic;
using System.Text;

namespace GABIZ.Base.NGenerics.Comparers
{
    /// <summary>
    /// A Comparer using a Comparison delegate for comparisons between items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class ComparisonComparer<T> : IComparer<T>
    {
        #region Globals

        private Comparison<T> comparison;

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonComparer&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="comparison">The comparison.</param>
        public ComparisonComparer(Comparison<T> comparison)
        {
            if (comparison == null)
            {
                throw new ArgumentNullException("comparison");
            }

            this.comparison = comparison;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets or sets the comparison used in this comparer.
        /// </summary>
        /// <value>The comparison used in this comparer.</value>
        public Comparison<T> Comparison
        {
            get
            {
                return comparison;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                comparison = value;
            }
        }

        #endregion

        #region IComparer<T> Members

        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>
        /// Value Condition Less than zerox is less than y.Zerox equals y.Greater than zerox is greater than y.
        /// </returns>
        public int Compare(T x, T y)
        {
            return comparison.Invoke(x, y);
        }

        #endregion
    }
}
