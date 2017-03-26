/*************************************************************************
* SardezExer2 - BST: A Binary Search Tree Implementation for CMSC 204: EXERCISE 2
* Student ID: 2016-30105
* Name: Sardez, Angelito Jr. Ortiz
* Master of Information Systems Student
* University of the Philippines - Open University
*
* Copyright (C) 2017 Angelito (Jojo) O. Sardez, Jr.
* This file is part of SardezExer2.
*
* SardezExer2 is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* SardezExer2 is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License.
* If not, see <http://www.gnu.org/licenses/>
*/

using System;
using System.Collections.Generic;
using SardezExer2.Common;

namespace SardezExer2.BST
{
    /// <summary>
    ///     My binary search tree implementation.
    /// </summary>
    /// <typeparam name="T">A value type.</typeparam>
    public class MyBST<T> where T : struct
    {
        public delegate void BSTAction(string action);

        private readonly Logger _logger;

        /// <summary>
        ///     Creates a new instance of MyBST.
        /// </summary>
        /// <param name="logger">Logger object.</param>
        public MyBST(Logger logger)
        {
            try
            {
                if (logger == null)
                    throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
                _logger = logger;
                _logger.LogInfo(GetSourceName(), "MyBST initialization started.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action("BST Initialization");
                _logger.LogInfo(GetSourceName(), "MyBST initialization ended.");
            }
        }

        /// <summary>
        ///     Gets the root node of the BST.
        /// </summary>
        public MyNode<T> Root { get; private set; }

        /// <summary>
        ///     Gets the count of nodes in the BST.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        ///     Gets the last action done in the BST.
        /// </summary>
        public string LastAction { get; private set; }

        public event BSTAction OnBSTAction;

        /// <summary>
        ///     Insert a new node to the BST.
        /// </summary>
        /// <param name="data">Data to insert.</param>
        public void Insert(T data)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Insert of data {data} started.");
                MyNode<T> newNode = MyNode<T>.Create(data);
                if (Root == null)
                {
                    Root = newNode;
                }
                else
                {
                    MyNode<T> node = Root;
                    while (node != null)
                    {
                        // Go left
                        if (Comparer<T>.Default.Compare(data, node.Data) < 0)
                        {
                            if (node.Left == null)
                            {
                                node.Left = newNode;
                                break;
                            }
                            node = node.Left;
                        }
                        // Go right
                        else
                        {
                            if (node.Right == null)
                            {
                                node.Right = newNode;
                                break;
                            }
                            node = node.Right;
                        }
                    }
                    newNode.Parent = node;
                }
                Count++;
                _logger.LogInfo(GetSourceName(), $"Node of the data {data} was added to the BST.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Insert));
                _logger.LogInfo(GetSourceName(), $"Insert of data {data} ended.");
            }
        }

        /// <summary>
        ///     Search a data in the BST.
        /// </summary>
        /// <param name="data">Data to search.</param>
        /// <returns>MyBSTSearchResult object.</returns>
        public MyBSTSearchResult<T> Search(T data)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Search of data {data} started.");
                return SearchNode(data);
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Search));
                _logger.LogInfo(GetSourceName(), $"Search of data {data} ended.");
            }
        }

        /// <summary>
        ///     Seach a node in the BST.
        /// </summary>
        /// <param name="data">Data of the node to search.</param>
        /// <returns>MyBSTSearchResult object.</returns>
        private MyBSTSearchResult<T> SearchNode(T data)
        {
            _logger.LogInfo(GetSourceName(),
                $"(Internal Search) Looking for the node of {data} starting from the root.");
            bool found = false;
            bool left = false;
            MyNode<T> node = Root;
            while (node != null)
            {
                // Node found
                if (EqualityComparer<T>.Default.Equals(data, node.Data))
                {
                    _logger.LogInfo(GetSourceName(), $"(Internal Search) Node of {data} was found.");
                    found = true;
                    break;
                }
                // Search left
                if (Comparer<T>.Default.Compare(data, node.Data) < 0)
                {
                    _logger.LogInfo(GetSourceName(),
                        $"(Internal Search) {data} is less than the current node's data of {node.Data}. Continue the search on the node's left sub-tree.");
                    left = true;
                    node = node.Left;
                }
                // Search right
                else
                {
                    _logger.LogInfo(GetSourceName(),
                        $"(Internal Search) {data} is greater than the current node's data of {node.Data}. Continue the search on the node's right sub-tree.");
                    left = false;
                    node = node.Right;
                }
            }
            if (!found)
                _logger.LogInfo(GetSourceName(), $"(Internal Search) Node of {data} was not found.");
            return MyBSTSearchResult<T>.Create(found, node, left);
        }

        /// <summary>
        ///     Remove a node from the BST.
        /// </summary>
        /// <param name="data">Data of the node to remove.</param>
        public void Remove(T data)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Remove of data {data} started.");
                MyBSTSearchResult<T> searchResult = SearchNode(data);
                if (searchResult.Found)
                {
                    // Node has no children
                    if (searchResult.Node.Left == null && searchResult.Node.Right == null &&
                        searchResult.Node.Parent != null)
                    {
                        _logger.LogInfo(GetSourceName(),
                            $"Applying algorithm for removing node with no children to the node of {data}.");
                        if (searchResult.LeftSearched)
                            searchResult.Node.Parent.Left = null;
                        else
                            searchResult.Node.Parent.Right = null;
                    }
                    // Node has 2 children
                    else if (searchResult.Node.Left != null && searchResult.Node.Right != null)
                    {
                        _logger.LogInfo(GetSourceName(),
                            $"Applying algorithm for removing node with two children to the node of {data}.");
                        // Set right child as successor
                        MyNode<T> successorParent = searchResult.Node;
                        MyNode<T> successor = searchResult.Node.Right;
                        bool left = successor.Left != null;
                        // Loop to the successor's left most child to be the new successor
                        while (successor.Left != null)
                        {
                            successorParent = successor;
                            successor = successor.Left;
                        }
                        // Set node's data with succesor's data
                        searchResult.Node.Data = successor.Data;
                        // Unlink the successor from its parent
                        if (left)
                            successorParent.Left = successor.Right;
                        else
                            successorParent.Right = successor.Right;
                        if (successor.Right != null)
                            successor.Right.Parent = successorParent;
                    }
                    // Node has 1 child
                    else
                    {
                        _logger.LogInfo(GetSourceName(),
                            $"Applying algorithm for removing node with only one child to the node of {data}.");
                        MyNode<T> successor = searchResult.Node.Left ?? searchResult.Node.Right;
                        if (searchResult.Node.Parent == null)
                        {
                            Root = successor;
                        }
                        else
                        {
                            if (searchResult.LeftSearched)
                                searchResult.Node.Parent.Left = successor;
                            else
                                searchResult.Node.Parent.Right = successor;
                            successor.Parent = searchResult.Node.Parent;
                        }
                    }
                    Count--;
                    _logger.LogInfo(GetSourceName(), $"Node of the data {data} was removed from the BST.");
                }
                else
                    throw new Exception($"Node of the data {data} not found.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Remove));
                _logger.LogInfo(GetSourceName(), $"Remove of data {data} ended.");
            }
        }

        /// <summary>
        ///     Get the minimum data in the BST.
        /// </summary>
        /// <returns>The minimum data.</returns>
        public T Minimum()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Get minimum data in the BST started.");
                if (Root == null)
                    throw new InvalidOperationException("Tree is empty.");
                MyNode<T> node = GetMinimumNode(Root);
                return node.Data;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Minimum));
                _logger.LogInfo(GetSourceName(), "Get minimum data in the BST ended.");
            }
        }

        /// <summary>
        ///     Get the node with the minimum data in the BST.
        /// </summary>
        /// <param name="node">The starting node.</param>
        /// <returns>The node with the minimum data.</returns>
        private MyNode<T> GetMinimumNode(MyNode<T> node)
        {
            _logger.LogInfo(GetSourceName(),
                $"(Internal Get Minimum) Getting node with minimum data starting from node of {node.Data}.");
            while (node?.Left != null)
            {
                node = node?.Left;
            }
            _logger.LogInfo(GetSourceName(),
                $"(Internal Get Minimum) Node with data {node.Data} was found as the node with the minimum data.");
            return node;
        }

        /// <summary>
        ///     Get the maximum data in the BST.
        /// </summary>
        /// <returns>The maximum data.</returns>
        public T Maximum()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Get maximum data in the BST started.");
                if (Root == null)
                    if (Root == null)
                        throw new InvalidOperationException("Tree is empty.");
                MyNode<T> node = GetMaximumNode(Root);
                return node.Data;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Maximum));
                _logger.LogInfo(GetSourceName(), "Get maximum data in the BST ended.");
            }
        }

        /// <summary>
        ///     Get the node with the maximum data in the BST.
        /// </summary>
        /// <param name="node">The starting node.</param>
        /// <returns>The node with the maximum data.</returns>
        private MyNode<T> GetMaximumNode(MyNode<T> node)
        {
            _logger.LogInfo(GetSourceName(),
                $"(Internal Get Maximum) Getting node with maximum data starting from node of {node.Data}.");
            while (node?.Right != null)
            {
                node = node?.Right;
            }
            _logger.LogInfo(GetSourceName(),
                $"(Internal Get Maximum) Node with data {node.Data} was found as the node with the maximum data.");
            return node;
        }

        /// <summary>
        ///     Get the predecessor of a given data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The predecesor of the data.</returns>
        public T? Predecessor(T data)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Get predecessor of {data} started.");
                MyBSTSearchResult<T> searchResult = SearchNode(data);
                if (searchResult.Found)
                {
                    MyNode<T> node;
                    // Node has left sub-tree. Get maximum node from it.
                    if (searchResult.Node.Left != null)
                    {
                        _logger.LogInfo(GetSourceName(), $"Getting predecessor of {data} from its left sub-tree.");
                        node = GetMaximumNode(searchResult.Node.Left);
                    }
                    // Get the first parent (of parent(s)) which has value lower than the data.
                    else
                    {
                        _logger.LogInfo(GetSourceName(),
                            $"Getting predecessor of {data} from its parent (of parent(s)).");
                        node = searchResult.Node.Parent;
                        while (node != null && Comparer<T>.Default.Compare(data, node.Data) < 0)
                        {
                            node = node.Parent;
                        }
                    }
                    return node?.Data;
                }
                throw new Exception($"Node of the data {data} not found.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Predecessor));
                _logger.LogInfo(GetSourceName(), $"Get predecessor of {data} ended.");
            }
        }

        /// <summary>
        ///     Get the successor of a given data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>The successor of the data.</returns>
        public T? Successor(T data)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Get successor of {data} started.");
                MyBSTSearchResult<T> searchResult = SearchNode(data);
                if (searchResult.Found)
                {
                    MyNode<T> node;
                    // Node has right sub-tree. Get minimum from it.
                    if (searchResult.Node.Right != null)
                    {
                        _logger.LogInfo(GetSourceName(), $"Getting successor of {data} from its right sub-tree.");
                        node = GetMinimumNode(searchResult.Node.Right);
                    }
                    // Get the first parent (of parent(s)) which has value higher than the data.
                    else
                    {
                        _logger.LogInfo(GetSourceName(),
                            $"Getting successor of {data} from its parent (of parent(s)).");
                        node = searchResult.Node.Parent;
                        while (node != null && Comparer<T>.Default.Compare(data, node.Data) > 0)
                        {
                            node = node.Parent;
                        }
                    }
                    return node?.Data;
                }
                throw new Exception($"Node of the data {data} not found.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Successor));
                _logger.LogInfo(GetSourceName(), $"Get successor of {data} ended.");
            }
        }

        /// <summary>
        ///     Gets the data in the BST ordered by the given traversal mode.
        /// </summary>
        /// <param name="mode">The traversal mode.</param>
        /// <returns>The data.</returns>
        public T[] GetNodeData(MyBSTTraversalMode mode)
        {
            List<T> dataList = new List<T>();
            Traverse(mode, dataList, Root);
            return dataList.ToArray();
        }

        /// <summary>
        ///     Traverse the BST.
        /// </summary>
        /// <param name="mode">Traversal mode.</param>
        /// <param name="dataList">Data list object.</param>
        /// <param name="node">The current node.</param>
        private void Traverse(MyBSTTraversalMode mode, List<T> dataList, MyNode<T> node)
        {
            if (node != null)
            {
                if (mode == MyBSTTraversalMode.PreOrder)
                    dataList.Add(node.Data);
                Traverse(mode, dataList, node.Left);
                if (mode == MyBSTTraversalMode.InOrder)
                    dataList.Add(node.Data);
                Traverse(mode, dataList, node.Right);
                if (mode == MyBSTTraversalMode.PostOrder)
                    dataList.Add(node.Data);
            }
        }

        /// <summary>
        ///     Clears the nodes of the BST.
        /// </summary>
        public void Clear()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Clear the BST's nodes started.");
                Root = null;
                Count = 0;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Clear));
                _logger.LogInfo(GetSourceName(), "Clear the BST's nodes ended.");
            }
        }

        /// <summary>
        ///     Gets the source name for logging.
        /// </summary>
        /// <returns>The source name.</returns>
        private string GetSourceName()
        {
            return $"MyBST<{typeof(T).Name}>";
        }

        /// <summary>
        ///     Sets the last action made and broadcast to subscribers.
        /// </summary>
        /// <param name="action">The action.</param>
        private void Action(string action)
        {
            LastAction = action;
            OnBSTAction?.Invoke(action);
        }
    }
}