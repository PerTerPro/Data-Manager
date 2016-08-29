using System;
using System.Collections.Generic;
using System.Text;

using GABIZ.Base.NGenerics.Enumerations;
using GABIZ.Base.NGenerics.Misc;
using GABIZ.Base.NGenerics.DataStructures;

namespace GABIZ.Base.NGenerics.Algorithms.Graph
{
    /// <summary>
    /// An implementation of Djikstras single source shortest path algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public static class DijkstrasAlgorithm<T>
	{
		#region Public Methods

        /// <summary>
        /// Finds the shortest paths to all other vertices from the specified source vertex.
        /// </summary>
        /// <param name="weightedGraph">The weighted graph.</param>
        /// <param name="fromVertex">The source vertex.</param>
        /// <returns>A graph representing the shortest paths from the source node to all other nodes in the graph.</returns>
		public static Graph<T> FindShortestPaths(Graph<T> weightedGraph, Vertex<T> fromVertex)
		{
			#region Parameter Checks

			if (weightedGraph == null)
			{
				throw new ArgumentNullException("weightedGraph");
			}

			if (fromVertex == null)
			{
				throw new ArgumentNullException("fromVertex");
			}

			if (!weightedGraph.ContainsVertex(fromVertex))
			{
				throw new ArgumentException(Resources.VertexCouldNotBeFound);
			}

			#endregion

			Heap<Association<double, Vertex<T>>> heap = 
				new Heap<Association<double, Vertex<T>>>(
					HeapType.MinHeap, 
					new Comparers.AssociationKeyComparer<double, Vertex<T>>());

			Dictionary<Vertex<T>, VertexInfo<T>> vertexStatus = new Dictionary<Vertex<T>, VertexInfo<T>>();

			// Initialise the vertex distances to 
			using (IEnumerator<Vertex<T>> verticeEnumerator = weightedGraph.Vertices) {
				while (verticeEnumerator.MoveNext())
				{
					vertexStatus.Add(verticeEnumerator.Current, new VertexInfo<T>(double.MaxValue, null, false));
				}
			}

			vertexStatus[fromVertex].Distance = 0;
									
			// Add the source vertex to the heap - we'll be branching out from it.		
			heap.Add(new Association<double, Vertex<T>>(0, fromVertex));
									
			while (heap.Count > 0)
			{
				Association<double, Vertex<T>> item = heap.RemoveRoot();

				VertexInfo<T> vertexInfo = vertexStatus[item.Value];

				if (!vertexInfo.IsFinalised) {
					List<Edge<T>> edges = item.Value.EmanatingEdgeList;

					vertexStatus[item.Value].IsFinalised = true;

					// Enumerate through all the edges emanating from this node					
					for (int i = 0; i< edges.Count; i++) {
						Vertex<T> partnerVertex = edges[i].GetPartnerVertex(item.Value);
												
						// Calculate the new distance to this distance
						double distance = vertexInfo.Distance + edges[i].Weight;

						VertexInfo<T> newVertexInfo = vertexStatus[partnerVertex];

						// Found a better path, update the vertex status and add the 
						// vertex to the heap for further analysis
						if (distance < newVertexInfo.Distance) {
							newVertexInfo.EdgeFollowed = edges[i];
							newVertexInfo.Distance = distance;
							heap.Add(new Association<double, Vertex<T>>(distance, partnerVertex));
						}
					}
				}
			}

			// Now build the new graph
			Graph<T> newGraph = new Graph<T>(weightedGraph.IsDirected);

			Dictionary<Vertex<T>, VertexInfo<T>>.Enumerator enumerator = vertexStatus.GetEnumerator();
			
			// This dictionary is used for mapping between the old vertices and the new vertices put into the graph
			Dictionary<Vertex<T>, Vertex<T>> vertexMap = new Dictionary<Vertex<T>, Vertex<T>>(vertexStatus.Count);

			Vertex<T>[] newVertices = new Vertex<T>[vertexStatus.Count];

			while (enumerator.MoveNext())
			{
				Vertex<T> newVertex = new Vertex<T>(
					enumerator.Current.Key.Data, 
					enumerator.Current.Value.Distance
				);

				vertexMap.Add(enumerator.Current.Key, newVertex);

				newGraph.AddVertex(newVertex);
			}

			enumerator = vertexStatus.GetEnumerator();

			while (enumerator.MoveNext())
			{
				VertexInfo<T> info = enumerator.Current.Value;

				// Check if an edge has been included to this vertex
				if ((info.EdgeFollowed != null) && (enumerator.Current.Key != fromVertex))
				{
					newGraph.AddEdge(
						vertexMap[info.EdgeFollowed.GetPartnerVertex(enumerator.Current.Key)], 
						vertexMap[enumerator.Current.Key], 
						info.EdgeFollowed.Weight);
				}
			}
						

			return newGraph;
		}		

		#endregion		
	}
}
