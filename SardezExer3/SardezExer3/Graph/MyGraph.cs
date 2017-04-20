/*************************************************************************
* SardezExer3 - GRAPHS: A Graph Implementation for CMSC 204: EXERCISE 3
* Student ID: 2016-30105
* Name: Sardez, Angelito Jr. Ortiz
* Master of Information Systems Student
* University of the Philippines - Open University
*
* Copyright (C) 2017 Angelito (Jojo) O. Sardez, Jr.
* This file is part of SardezExer3.
*
* SardezExer3 is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* SardezExer3 is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License.
* If not, see <http://www.gnu.org/licenses/>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SardezExer3.Common;
using SardezExer3.Queue;
using SardezExer3.Stack;

namespace SardezExer3.Graph
{
    /// <summary>
    ///     My Graph implementation.
    /// </summary>
    public class MyGraph
    {
        public delegate void GraphAction(string action);

        private readonly Dictionary<int, List<int>> _adjacencyList;

        private readonly Logger _logger;

        private readonly string _name;

        /// <summary>
        ///     Creates a new instance of MyGraph.
        /// </summary>
        /// <param name="name">Graph's name.</param>
        /// <param name="logger">Logger object.</param>
        public MyGraph(string name, Logger logger)
        {
            try
            {
                if (logger == null)
                    throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
                _name = name;
                _logger = logger;
                _adjacencyList = new Dictionary<int, List<int>>();
                _logger.LogInfo(GetSourceName(), "MyGraph initialization started.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action("Queue Initialization");
                _logger.LogInfo(GetSourceName(), "MyGraph initialization ended.");
            }
        }

        /// <summary>
        ///     Gets the last action done in the graph.
        /// </summary>
        public string LastAction { get; private set; }

        public event GraphAction OnGraphAction;

        /// <summary>
        ///     Adds a vertex.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        public void AddVertex(int vertex)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Add vertex {vertex} started.");
                if (!_adjacencyList.ContainsKey(vertex))
                {
                    _adjacencyList.Add(vertex, new List<int>());
                    _logger.LogInfo(GetSourceName(), $"Vertex {vertex} was successfully added.");
                }
                else
                    _logger.LogInfo(GetSourceName(), $"Vertex {vertex} already exists.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(AddVertex));
                _logger.LogInfo(GetSourceName(), $"Add vertex {vertex} ended.");
            }
        }

        /// <summary>
        ///     Adds an edge.
        /// </summary>
        /// <param name="from">From vertex.</param>
        /// <param name="to">To vertex.</param>
        public void AddEdge(int from, int to)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Add edge {from},{to} started.");
                if (!_adjacencyList.ContainsKey(from))
                    AddVertex(from);
                if (!_adjacencyList.ContainsKey(to))
                    AddVertex(to);

                if (!_adjacencyList[from].Contains(to))
                {
                    _adjacencyList[from].Add(to);
                    _logger.LogInfo(GetSourceName(), $"Edge {from},{to} was successfully added.");
                }
                else
                    _logger.LogInfo(GetSourceName(), $"Edge {from},{to} already exists.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(AddEdge));
                _logger.LogInfo(GetSourceName(), $"Add edge {from},{to} ended.");
            }
        }

        /// <summary>
        ///     Traverse the graph using Depth-First algorithm.
        /// </summary>
        /// <param name="startVertex">Starting vertex.</param>
        /// <returns>Traversal path \ order.</returns>
        public List<int> DfsTraverse(int startVertex)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"DFS traverse starting from {startVertex} started.");
                if (!_adjacencyList.ContainsKey(startVertex))
                    return null;

                List<int> traversalOrder;
                DfsTraverseSearch(startVertex, out traversalOrder);
                return traversalOrder;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(DfsTraverse));
                _logger.LogInfo(GetSourceName(), $"DFS traverse starting from {startVertex} ended.");
            }
        }

        /// <summary>
        ///     Search the graph using Depth-First algorithm.
        /// </summary>
        /// <param name="vertex">The vertex to search.</param>
        /// <param name="searchOrder">Traversal path \ order.</param>
        /// <returns>True if found, otherwise false.</returns>
        public bool DfsSearch(int vertex, out List<int> searchOrder)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"DFS search vertex {vertex} started.");
                return DfsTraverseSearch(_adjacencyList.First().Key, out searchOrder, vertex);
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(DfsSearch));
                _logger.LogInfo(GetSourceName(), $"DFS search vertex {vertex} ended.");
            }
        }

        /// <summary>
        ///     Traverse and search the graph using Depth-First algorithm.
        /// </summary>
        /// <param name="startVertex">Starting vertex.</param>
        /// <param name="searchOrder">Traversal path \ order.</param>
        /// <param name="searchVertex">The vertex to search.</param>
        /// <returns>True if found, otherwise false.</returns>
        private bool DfsTraverseSearch(int startVertex, out List<int> searchOrder, int? searchVertex = null)
        {
            searchOrder = new List<int>();
            Dictionary<int, bool> searchDictionary = _adjacencyList.ToDictionary(x => x.Key, x => false);
            MyStack<int> stack = new MyStack<int>(_logger);
            stack.Push(startVertex);
            while (stack.Top >= 0)
            {
                int currentVertex = stack.Pop();
                _logger.LogInfo(GetSourceName(), $"Current vertex is {currentVertex}.");
                if (!searchDictionary[currentVertex])
                {
                    searchOrder.Add(currentVertex);
                    searchDictionary[currentVertex] = true;
                    if (searchVertex.HasValue && searchVertex.Value.Equals(currentVertex))
                    {
                        _logger.LogInfo(GetSourceName(), $"Vertex {searchVertex} was found. Ending traversal.");
                        return true;
                    }
                    foreach (int edge in _adjacencyList[currentVertex])
                    {
                        stack.Push(edge);
                    }
                }
            }
            return false;
        }

        /// <summary>
        ///     Traverse the graph using recursive Depth-First algorithm.
        /// </summary>
        /// <param name="startVertex">Starting vertex.</param>
        /// <returns>Traversal path \ order.</returns>
        public List<int> DfsTraverseRecursive(int startVertex)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Recursive DFS traverse starting from {startVertex} started.");
                if (!_adjacencyList.ContainsKey(startVertex))
                    return null;

                List<int> traversalOrder = new List<int>();
                Dictionary<int, bool> searchDictionary = _adjacencyList.ToDictionary(x => x.Key, x => false);
                DfsTraverseSearchRecursive(searchDictionary, traversalOrder, startVertex);
                return traversalOrder;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(DfsTraverseRecursive));
                _logger.LogInfo(GetSourceName(), $"Recursive DFS traverse starting from {startVertex} ended.");
            }
        }

        /// <summary>
        ///     Search the graph using recursive Depth-First algorithm.
        /// </summary>
        /// <param name="vertex">The vertex to search.</param>
        /// <param name="searchOrder">Traversal path \ order.</param>
        /// <returns>True if found, otherwise false.</returns>
        public bool DfsSearchRecursive(int vertex, out List<int> searchOrder)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Recursive DFS search vertex {vertex} started.");
                searchOrder = new List<int>();
                Dictionary<int, bool> searchDictionary = _adjacencyList.ToDictionary(x => x.Key, x => false);
                return DfsTraverseSearchRecursive(searchDictionary, searchOrder, _adjacencyList.First().Key, vertex);
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(DfsSearchRecursive));
                _logger.LogInfo(GetSourceName(), $"Recursive DFS search vertex {vertex} ended.");
            }
        }

        /// <summary>
        ///     Traverse and search the graph using recursive Depth-First algorithm.
        /// </summary>
        /// <param name="searchDictionary">The search dictionary.</param>
        /// <param name="searchOrder">Traversal path \ order.</param>
        /// <param name="currentVertex">The current vertex.</param>
        /// <param name="searchVertex">The vertex to search.</param>
        /// <returns>True if found, otherwise false.</returns>
        private bool DfsTraverseSearchRecursive(Dictionary<int, bool> searchDictionary, List<int> searchOrder,
            int currentVertex, int? searchVertex = null)
        {
            _logger.LogInfo(GetSourceName(), $"Current vertex is {currentVertex}.");
            searchOrder.Add(currentVertex);
            searchDictionary[currentVertex] = true;
            if (searchVertex.HasValue && searchVertex.Value.Equals(currentVertex))
            {
                _logger.LogInfo(GetSourceName(), $"Vertex {searchVertex} was found. Ending traversal.");
                return true;
            }
            bool found = false;
            foreach (int edge in _adjacencyList[currentVertex])
            {
                if (!searchDictionary[edge])
                    found = DfsTraverseSearchRecursive(searchDictionary, searchOrder, edge, searchVertex);
                if (found)
                    break;
            }
            return found;
        }

        /// <summary>
        ///     Traverse the graph using Breadth-First algorithm.
        /// </summary>
        /// <param name="startVertex">Starting vertex.</param>
        /// <returns>Traversal path \ order.</returns>
        public List<int> BfsTraverse(int startVertex)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"BFS traverse starting from {startVertex} started.");
                if (!_adjacencyList.ContainsKey(startVertex))
                    return null;

                List<int> traversalOrder;
                BfsTraverseSearch(startVertex, out traversalOrder);
                return traversalOrder;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(BfsTraverse));
                _logger.LogInfo(GetSourceName(), $"BFS traverse starting from {startVertex} ended.");
            }
        }

        /// <summary>
        ///     Search the graph using Breadth-First algorithm.
        /// </summary>
        /// <param name="vertex">The vertex to search.</param>
        /// <param name="searchOrder">Traversal path \ order.</param>
        /// <returns>True if found, otherwise false.</returns>
        public bool BfsSearch(int vertex, out List<int> searchOrder)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"BFS search vertex {vertex} started.");
                return BfsTraverseSearch(_adjacencyList.First().Key, out searchOrder, vertex);
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(BfsSearch));
                _logger.LogInfo(GetSourceName(), $"BFS search vertex {vertex} ended.");
            }
        }

        /// <summary>
        ///     Traverse and search the graph using Breadth-First algorithm.
        /// </summary>
        /// <param name="startVertex">Starting vertex.</param>
        /// <param name="searchOrder">Traversal path \ order.</param>
        /// <param name="searchVertex">The vertex to search.</param>
        /// <returns>True if found, otherwise false.</returns>
        private bool BfsTraverseSearch(int startVertex, out List<int> searchOrder, int? searchVertex = null)
        {
            searchOrder = new List<int>();
            MyQueue<int> queue = new MyQueue<int>(_logger);
            queue.Enqueue(startVertex);
            searchOrder.Add(startVertex);
            _logger.LogInfo(GetSourceName(), $"Current vertex is {startVertex}.");
            if (searchVertex.HasValue && searchVertex.Value.Equals(startVertex))
                return true;
            while (queue.Head != null)
            {
                int currentVertex = queue.Dequeue();
                foreach (int edge in _adjacencyList[currentVertex])
                {
                    if (!searchOrder.Contains(edge))
                    {
                        queue.Enqueue(edge);
                        searchOrder.Add(edge);
                        _logger.LogInfo(GetSourceName(), $"Current vertex is {edge}.");
                        if (searchVertex.HasValue && searchVertex.Value.Equals(edge))
                            return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        ///     Prints the adjacency list.
        /// </summary>
        /// <returns>The adjacency list string.</returns>
        public string PrintAdjacencyList()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Printing adjacency list started.");
                StringBuilder list = new StringBuilder();
                foreach (KeyValuePair<int, List<int>> vertex in _adjacencyList)
                {
                    StringBuilder vertexLine = new StringBuilder();
                    vertexLine.Append($"Vertex: {vertex.Key} ");
                    if (vertex.Value.Count > 0)
                        vertexLine.Append($"Edges: {string.Join(" ,", vertex.Value.ToArray())}.");
                    list.AppendLine(vertexLine.ToString());
                }
                return list.ToString();
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(PrintAdjacencyList));
                _logger.LogInfo(GetSourceName(), "Printing adjacency list ended.");
            }
        }

        /// <summary>
        ///     Gets the source name for logging.
        /// </summary>
        /// <returns>The source name.</returns>
        private string GetSourceName()
        {
            return $"{nameof(MyGraph)}({_name})";
        }

        /// <summary>
        ///     Sets the last action made and broadcast to subscribers.
        /// </summary>
        /// <param name="action">The action.</param>
        private void Action(string action)
        {
            LastAction = action;
            OnGraphAction?.Invoke(action);
        }
    }
}