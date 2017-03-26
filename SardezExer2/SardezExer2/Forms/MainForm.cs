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
using System.Windows.Forms;
using SardezExer2.BST;
using SardezExer2.Common;

namespace SardezExer2.Forms
{
    /// <summary>
    ///     frmSardezExer2 Form.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly InputBox _inputBox;
        private readonly Logger _logger;
        private readonly MyBST<int> _myBST;

        /// <summary>
        ///     Initialize frmSardezExer2.
        /// </summary>
        /// <param name="logger">Logger instance.</param>
        /// <param name="myBST">MyBST instance.</param>
        /// <param name="inputBox">InputBox instance.</param>
        public MainForm(Logger logger, MyBST<int> myBST, InputBox inputBox)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
            if (myBST == null)
                throw new ArgumentNullException(nameof(myBST), "MyBST instance provided is null.");
            if (inputBox == null)
                throw new ArgumentNullException(nameof(inputBox), "InputBox instance provided is null.");

            InitializeComponent();

            // Assign dependencies
            _logger = logger;
            _myBST = myBST;
            _inputBox = inputBox;

            // Assign event handlers
            _logger.OnMessageLogged += _logger_OnMessageLogged;
            _myBST.OnBSTAction += _myBST_OnBSTAction;

            // Update status and log info
            _logger.LogInfo(nameof(MainForm), "SardezExer2 application successfully started.");
            UpdateStatusBar();
        }

        /// <summary>
        ///     Insert event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Insert Node", "Please enter a value:") == DialogResult.OK)
                {
                    _myBST.Insert(InputBox.ResultValue);
                    string message = $"Node of {InputBox.ResultValue} was successfully inserted.";
                    _logger.LogInfo(nameof(MainForm), message);
                    MessageBox.Show(message, "Insert Node", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Delete event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Delete Node", "Please enter a value:") == DialogResult.OK)
                {
                    _myBST.Remove(InputBox.ResultValue);
                    string message = $"Node of {InputBox.ResultValue} was successfully deleted.";
                    _logger.LogInfo(nameof(MainForm), message);
                    MessageBox.Show(message, "Delete Node", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Minimum event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnMinimum_Click(object sender, EventArgs e)
        {
            try
            {
                int value = _myBST.Minimum();
                string message = $"The minimum node value in the BST is {value}.";
                _logger.LogInfo(nameof(MainForm), message);
                MessageBox.Show(message, "Minimum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Maximum event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnMaximum_Click(object sender, EventArgs e)
        {
            try
            {
                int value = _myBST.Maximum();
                string message = $"The maximum node value in the BST is {value}.";
                _logger.LogInfo(nameof(MainForm), message);
                MessageBox.Show(message, "Maximum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Successor event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSuccessor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Successor", "Please enter a value:") == DialogResult.OK)
                {
                    int? value = _myBST.Successor(InputBox.ResultValue);
                    string message = value != null && value.HasValue
                        ? $"The successor of {InputBox.ResultValue} is {value}."
                        : $"{InputBox.ResultValue} has no successor.";
                    _logger.LogInfo(nameof(MainForm), message);
                    MessageBox.Show(message, "Successor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Predecessor event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnPredecessor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Predecessor", "Please enter a value:") == DialogResult.OK)
                {
                    int? value = _myBST.Predecessor(InputBox.ResultValue);
                    string message = value != null && value.HasValue
                        ? $"The predecessor of {InputBox.ResultValue} is {value}."
                        : $"{InputBox.ResultValue} has no predecessor.";
                    _logger.LogInfo(nameof(MainForm), message);
                    MessageBox.Show(message, "Predecessor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Search event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inputBox.ShowDialog("Search", "Please enter a value:") == DialogResult.OK)
                {
                    MyBSTSearchResult<int> result = _myBST.Search(InputBox.ResultValue);
                    string message = result.Found
                        ? $"The node of {InputBox.ResultValue} was found. Parent: {result.Node.Parent?.Data}, Left Child: {result.Node.Left?.Data}, Right Child: {result.Node.Right?.Data}."
                        : $"The node of {InputBox.ResultValue} was not found.";
                    _logger.LogInfo(nameof(MainForm), message);
                    MessageBox.Show(message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Print event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "BST's Contents: ";
                foreach (var item in _myBST.GetNodeData(MyBSTTraversalMode.InOrder))
                {
                    message += $"{item} ";
                }
                _logger.LogInfo(nameof(MainForm), message);
                MessageBox.Show(message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Clear event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                _myBST.Clear();
                string message = "The BST was cleared.";
                _logger.LogInfo(nameof(MainForm), message);
                MessageBox.Show(message, "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        ///     OnMessageLogged event handler.
        /// </summary>
        /// <param name="message">Message logged.</param>
        private void _logger_OnMessageLogged(string message)
        {
            txtEvents.AppendText($"{message}{Environment.NewLine}");
        }

        /// <summary>
        ///     OnBSTAction event handler.
        /// </summary>
        /// <param name="action">Action made.</param>
        private void _myBST_OnBSTAction(string action)
        {
            UpdateStatusBar();
        }

        /// <summary>
        ///     Update the status bar.
        /// </summary>
        private void UpdateStatusBar()
        {
            tsCount.Text = $"Node Count: {_myBST.Count}";
            tsRoot.Text = $"Root Node's Data: {_myBST.Root?.Data}";
            tsLastAction.Text = $"Last Action: {_myBST.LastAction}";
            txtBSTItems.Clear();
            txtBSTItems.AppendText($"Items in In-Order Traversal:{Environment.NewLine}");
            foreach (var item in _myBST.GetNodeData(MyBSTTraversalMode.InOrder))
            {
                txtBSTItems.AppendText($"{item} ");
            }
            txtBSTItems.AppendText($"{Environment.NewLine}");
            txtBSTItems.AppendText($"Items in Pre-Order Traversal:{Environment.NewLine}");
            foreach (var item in _myBST.GetNodeData(MyBSTTraversalMode.PreOrder))
            {
                txtBSTItems.AppendText($"{item} ");
            }
            txtBSTItems.AppendText($"{Environment.NewLine}");
            txtBSTItems.AppendText($"Items in Post-Order Traversal:{Environment.NewLine}");
            foreach (var item in _myBST.GetNodeData(MyBSTTraversalMode.PostOrder))
            {
                txtBSTItems.AppendText($"{item} ");
            }
        }
    }
}