using System;
using System.Collections.Generic;
using System.Text;
using GABIZ.Base.NGenerics.Enumerations;

namespace GABIZ.Base.NGenerics.DataStructures
{
	internal class RedBlackTreeNode<TKey, TValue>
	{
		#region Globals

		private TKey thisKey;
        private TValue thisValue;
		private RedBlackTreeNode<TKey, TValue> leftSubtree;
		private RedBlackTreeNode<TKey, TValue> rightSubtree;
		private NodeColor thisColor;

		#endregion

		#region Construction

		internal RedBlackTreeNode(TKey key, TValue value)
		{
			thisKey = key;
            thisValue = value;
			thisColor = NodeColor.Red;
			leftSubtree = null;
            rightSubtree = null;
		}

		#endregion

		#region Properties

		internal TKey Key
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

        internal TValue Value
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
		/// Gets or sets the left child node.
		/// </summary>
		/// <value>The left child node.</value>
		internal RedBlackTreeNode<TKey, TValue> Left
		{
			get
			{
				return leftSubtree;
			}
			set {
				leftSubtree = value;
			}
		}

		/// <summary>
		/// Gets or sets the right child node.
		/// </summary>
		/// <value>The right child of the current node.</value>
        internal RedBlackTreeNode<TKey, TValue> Right
		{
			get
			{
				return rightSubtree;
			}
			set
			{
				rightSubtree = value;
			}
		}

        internal RedBlackTreeNode<TKey, TValue> this[bool direction]
        {
            get {
                if (direction)
                {
                    return this.rightSubtree;
                }
                else
                {
                    return this.leftSubtree;
                }
            }
            set {
                if (direction)
                {
                    this.rightSubtree = value;
                }
                else
                {
                    this.leftSubtree = value;
                }
            }
        }

        /// <summary>
        /// Determines whether the specified node is red.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        /// 	<c>true</c> if the specified node is red; otherwise, <c>false</c>.
        /// </returns>
        internal static bool IsRed(RedBlackTreeNode<TKey, TValue> node)
        {
            return (node != null) && (node.Color == NodeColor.Red);
        }

        /// <summary>
        /// Determines whether the specified node is black.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        /// 	<c>true</c> if the specified node is black; otherwise, <c>false</c>.
        /// </returns>
        internal static bool IsBlack(RedBlackTreeNode<TKey, TValue> node)
        {
            return (node == null) || (node.Color == NodeColor.Black);
        }


		/// <summary>
		/// Gets or sets the color of the current node.
		/// </summary>
		/// <value>The color of the node.</value>
		internal NodeColor Color
		{
			get
			{
				return thisColor;
			}
			set
			{
				thisColor = value;
			}
		}		

		#endregion

	}
}
