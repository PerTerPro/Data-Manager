using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.DataStructures;

namespace GABIZ.Base.NGenerics.Visitors
{
    /// <summary>
    /// A visitor that tracks (stores) keys from KeyValuePairs in the order they were visited.
    /// </summary>
    /// <typeparam name="TKey">The type of key of the KeyValuePair.</typeparam>
    /// <typeparam name="TValue">The type of value of the KeyValuePair.</typeparam>
    public sealed class ValueTrackingVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
    {
        #region Globals

        private VisitableList<TValue> tracks;

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingVisitor&lt;T&gt;"/> class.
        /// </summary>
        public ValueTrackingVisitor()
        {
            tracks = new VisitableList<TValue>();
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets the tracking list.
        /// </summary>
        /// <value>The tracking list.</value>
        public VisitableList<TValue> TrackingList
        {
            get
            {
                return tracks;
            }
        }

        #endregion

        #region IVisitor<KeyValuePair<TKey,TValue>> Members


        /// <summary>
        /// Visits the specified object.
        /// </summary>
        /// <param name="obj">The object to visit.</param>
        public void Visit(KeyValuePair<TKey, TValue> obj)
        {
            tracks.Add(obj.Value);
        }

        /// <summary>
        /// Gets a value indicating whether this instance is done performing it's work..
        /// </summary>
        /// <returns><c>true</c> if this instance is done; otherwise, <c>false</c>.</returns>
        /// <value><c>true</c> if this instance is done; otherwise, <c>false</c>.</value>
        public bool HasCompleted
        {
            get
            {
                return false;
            }
        }

        #endregion
    }
}
