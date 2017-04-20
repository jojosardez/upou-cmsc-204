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
using System.Windows.Forms;
using SardezExer3.Common;
using SardezExer3.Graph;

namespace SardezExer3.Forms
{
    /// <summary>
    ///     frmSardezExer3 Form.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly InputBox _inputBox;
        private readonly Logger _logger;
        private MyGraph _graph1;
        private MyGraph _graph2;

        /// <summary>
        ///     Initialize frmSardezExer3.
        /// </summary>
        /// <param name="logger">Logger instance.</param>
        /// <param name="inputBox">InputBox instance.</param>
        public MainForm(Logger logger, InputBox inputBox)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
            if (logger == null)
                throw new ArgumentNullException(nameof(inputBox), "InputBox instance provided is null.");

            InitializeComponent();

            // Assign dependencies
            _logger = logger;
            _inputBox = inputBox;

            // Assign event handlers
            _logger.OnMessageLogged += _logger_OnMessageLogged;

            // Graph initialization
            InitializeGraphs();
            _graph1.OnGraphAction += myGraph_OnGraphAction;
            _graph2.OnGraphAction += myGraph_OnGraphAction;
            DisplayAdjacencyList();

            // Update status and log info
            UpdateStatusBar();
            _logger.LogInfo(GetType().Name, "SardezExer3 application successfully started.");
        }

        /// <summary>
        ///     Inititalizes the graphs.
        /// </summary>
        private void InitializeGraphs()
        {
            _graph1 = new MyGraph("Graph 1", _logger);
            _graph1.AddVertex(0);
            _graph1.AddVertex(1);
            _graph1.AddVertex(2);
            _graph1.AddVertex(3);
            _graph1.AddVertex(4);
            _graph1.AddVertex(5);
            _graph1.AddEdge(0, 2);
            _graph1.AddEdge(1, 0);
            _graph1.AddEdge(1, 2);
            _graph1.AddEdge(2, 3);
            _graph1.AddEdge(2, 4);
            _graph1.AddEdge(3, 1);
            _graph1.AddEdge(4, 1);
            _graph1.AddEdge(4, 3);
            _graph1.AddEdge(4, 5);
            _graph1.AddEdge(5, 3);

            _graph2 = new MyGraph("Graph 2", _logger);
            _graph2.AddVertex(0);
            _graph2.AddVertex(1);
            _graph2.AddVertex(2);
            _graph2.AddVertex(3);
            _graph2.AddEdge(0, 1);
            _graph2.AddEdge(1, 2);
            _graph2.AddEdge(1, 3);
            _graph2.AddEdge(2, 0);
            _graph2.AddEdge(2, 3);
            _graph2.AddEdge(3, 0);
        }

        /// <summary>
        ///     Exit event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     DFS Traversal event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnDFSTraversal_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Depth First Traversal", "Please specify graph (1 or 2):") == DialogResult.OK)
                {
                    if (!InputBox.ResultValue.Equals("1") && !InputBox.ResultValue.Equals("2"))
                        MessageBox.Show("Graph specified is invalid.", "Depth First Traversal", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    else
                    {
                        List<int> traverseOrder;
                        if (InputBox.ResultValue.Equals("1"))
                            traverseOrder = _graph1.DfsTraverse(0);
                        else
                            traverseOrder = _graph2.DfsTraverse(0);

                        string message =
                            $"Traversal order: {Environment.NewLine}{string.Join(" => ", traverseOrder.ToArray())}";
                        _logger.LogInfo(nameof(MainForm), message);
                        MessageBox.Show(message, "Depth First Traversal", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     BFS Traversal event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnBFSTraversal_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Breadth First Traversal", "Please specify graph (1 or 2):") ==
                    DialogResult.OK)
                {
                    if (!InputBox.ResultValue.Equals("1") && !InputBox.ResultValue.Equals("2"))
                        MessageBox.Show("Graph specified is invalid.", "Breadth First Traversal", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    else
                    {
                        List<int> traverseOrder;
                        if (InputBox.ResultValue.Equals("1"))
                            traverseOrder = _graph1.BfsTraverse(0);
                        else
                            traverseOrder = _graph2.BfsTraverse(0);

                        string message =
                            $"Traversal order: {Environment.NewLine}{string.Join(" => ", traverseOrder.ToArray())}";
                        _logger.LogInfo(nameof(MainForm), message);
                        MessageBox.Show(message, "Breadth First Traversal", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Recursive DFS Traversal event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnRecurDFSTraversal_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Recursive Depth First Traversal", "Please specify graph (1 or 2):") ==
                    DialogResult.OK)
                {
                    if (!InputBox.ResultValue.Equals("1") && !InputBox.ResultValue.Equals("2"))
                        MessageBox.Show("Graph specified is invalid.", "Recursive Depth First Traversal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    else
                    {
                        List<int> traverseOrder;
                        if (InputBox.ResultValue.Equals("1"))
                            traverseOrder = _graph1.DfsTraverseRecursive(0);
                        else
                            traverseOrder = _graph2.DfsTraverseRecursive(0);

                        string message =
                            $"Traversal order: {Environment.NewLine}{string.Join(" => ", traverseOrder.ToArray())}";
                        _logger.LogInfo(nameof(MainForm), message);
                        MessageBox.Show(message, "Recursive Depth First Traversal", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     DFS Search Graph 1 event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSearchG1DFS_Click(object sender, EventArgs e)
        {
            Search(1, SearchType.DFS);
        }

        /// <summary>
        ///     BFS Search Graph 2 event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSeachG2BFS_Click(object sender, EventArgs e)
        {
            Search(2, SearchType.BFS);
        }

        /// <summary>
        ///     BFS Search Graph 1 event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSearchG1BFS_Click(object sender, EventArgs e)
        {
            Search(1, SearchType.BFS);
        }

        /// <summary>
        ///     DFS Search Graph 2 event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSearchG2DFS_Click(object sender, EventArgs e)
        {
            Search(2, SearchType.DFS);
        }

        /// <summary>
        ///     Recursive DFS Search Graph 1 event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSearchG1RecDFS_Click(object sender, EventArgs e)
        {
            Search(1, SearchType.RecursiveDFS);
        }

        /// <summary>
        ///     Recursive DFS Search Graph 2 event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSearchG2RecDFS_Click(object sender, EventArgs e)
        {
            Search(2, SearchType.RecursiveDFS);
        }

        /// <summary>
        ///     Search graph.
        /// </summary>
        /// <param name="graph">Grpah number.</param>
        /// <param name="type">Search type.</param>
        private void Search(int graph, SearchType type)
        {
            try
            {
                if (_inputBox.ShowDialog($"Graph {graph} - {type}", "Please specify vertex to search:") ==
                    DialogResult.OK)
                {
                    int vertex;
                    if (!int.TryParse(InputBox.ResultValue, out vertex))
                        MessageBox.Show("Vertex specified is invalid.", "Graph 1 - DFS", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    else
                    {
                        List<int> traverseOrder = new List<int>();
                        bool found = false;
                        switch (graph)
                        {
                            case 1:
                                switch (type)
                                {
                                    case SearchType.DFS:
                                        found = _graph1.DfsSearch(vertex, out traverseOrder);
                                        break;
                                    case SearchType.BFS:
                                        found = _graph1.BfsSearch(vertex, out traverseOrder);
                                        break;
                                    case SearchType.RecursiveDFS:
                                        found = _graph1.DfsSearchRecursive(vertex, out traverseOrder);
                                        break;
                                }
                                break;
                            case 2:
                                switch (type)
                                {
                                    case SearchType.DFS:
                                        found = _graph2.DfsSearch(vertex, out traverseOrder);
                                        break;
                                    case SearchType.BFS:
                                        found = _graph2.BfsSearch(vertex, out traverseOrder);
                                        break;
                                    case SearchType.RecursiveDFS:
                                        found = _graph2.DfsSearchRecursive(vertex, out traverseOrder);
                                        break;
                                }
                                break;
                        }

                        string foundFiller = found ? string.Empty : "not ";
                        string traversalFiller = found ? "found" : "visited all";
                        string message =
                            $"Vertex {vertex} was {foundFiller}found. Traversal order: {Environment.NewLine}{string.Join(" => ", traverseOrder.ToArray())} ({traversalFiller})";
                        _logger.LogInfo(nameof(MainForm), message);
                        MessageBox.Show(message, $"Graph {graph} - {type}", MessageBoxButtons.OK,
                            found ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     OnMessageLogged event handler.
        /// </summary>
        /// <param name="message">Message logged</param>
        private void _logger_OnMessageLogged(string message)
        {
            txtEvents.AppendText($"{message}{Environment.NewLine}");
        }

        /// <summary>
        ///     OnGraphAction event handler.
        /// </summary>
        /// <param name="action">Action made.</param>
        private void myGraph_OnGraphAction(string action)
        {
            UpdateStatusBar();
        }

        /// <summary>
        ///     Update the status bar.
        /// </summary>
        private void UpdateStatusBar()
        {
            tsLastAction.Text =
                $"Graph 1's Last Action: {_graph1.LastAction}; Graph 2's Last Action: {_graph2.LastAction}";
        }

        /// <summary>
        ///     Displays the adjacency list.
        /// </summary>
        private void DisplayAdjacencyList()
        {
            txtAdjacencyList.Clear();
            txtAdjacencyList.AppendText($"Graph 1:{Environment.NewLine}");
            txtAdjacencyList.AppendText($"{_graph1.PrintAdjacencyList()}");
            txtAdjacencyList.AppendText($"{Environment.NewLine}");
            txtAdjacencyList.AppendText($"Graph 2:{Environment.NewLine}");
            txtAdjacencyList.AppendText($"{_graph2.PrintAdjacencyList()}");
        }

        /// <summary>
        ///     Search types.
        /// </summary>
        private enum SearchType
        {
            DFS,
            BFS,
            RecursiveDFS
        }
    }
}