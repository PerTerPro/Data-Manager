using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.Misc;

namespace GABIZ.Base.NGenerics.DataStructures
{
    /// <summary>
    /// A class representing an edge in a graph.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public class Edge<T>
	{
		#region Globals

		Vertex<T> from;
		Vertex<T> to;
		double edgeWeight;
		bool edgeIsDirected;

		#endregion

		#region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="fromVertex">From vertex.</param>
        /// <param name="toVertex">To vertex.</param>
        /// <param name="isDirected">if set to <c>true</c> [is directed].</param>
		public Edge(Vertex<T> fromVertex, Vertex<T> toVertex, bool isDirected) : this(fromVertex, toVertex, 0, isDirected) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="fromVertex">From vertex.</param>
        /// <param name="toVertex">To vertex.</param>
        /// <param name="weight">The weight associated with the edge.</param>
        /// <param name="isDirected">if set to <c>true</c> [is directed].</param>
		public Edge(Vertex<T> fromVertex, Vertex<T> toVertex, double weight, bool isDirected)
		{
			if (fromVertex == null)
			{
				throw new ArgumentNullException("fromVertex");
			}

			if (toVertex == null)
			{
				throw new ArgumentNullException("toVertex");
			}

			from = fromVertex;
			to = toVertex;
			edgeWeight = weight;
			edgeIsDirected = isDirected;
		}

		#endregion

		#region Public Members

		/// <summary>
		/// Gets the from vertex.
		/// </summary>
		/// <value>The from vertex.</value>
		public Vertex<T> FromVertex
		{
			get
			{
				return from;
			}
		}

		/// <summary>
		/// Gets the to vertex.
		/// </summary>
		/// <value>The to vertex.</value>
		public Vertex<T> ToVertex
		{
			get
			{
				return to;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this edge is directed.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this edge is directed; otherwise, <c>false</c>.
		/// </value>
		public bool IsDirected
		{
			get
			{
				return edgeIsDirected;
			}
		}

		/// <summary>
		/// Gets the weight associated with this edge.
		/// </summary>
		/// <value>The weight associated with this edge.</value>
		public double Weight
		{
			get
			{
				return edgeWeight;
			}
		}

        /// <summary>
        /// Gets the partner vertex in this edge relationship.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>The partner of the vertex specified in this edge relationship.</returns>
		public Vertex<T> GetPartnerVertex(Vertex<T> vertex)
		{
			if (from == vertex)
			{
				return to;
			}
			else if (to == vertex)
			{
				return from;
			}
			else
			{
				throw new ArgumentException(Resources.VertexNotPartOfEdge);
			}
		}

		#endregion
	}

}