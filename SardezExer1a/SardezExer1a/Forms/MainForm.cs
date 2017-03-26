/*************************************************************************
* SardezExer1a – STACKS: A Stack + Array Implementation for CMSC 204: EXERCISE 1
* Student ID: 2016-30105
* Name: Sardez, Angelito Jr. Ortiz
* Master of Information Systems Student
* University of the Philippines - Open University
*
* Copyright (C) 2017 Angelito (Jojo) O. Sardez, Jr.
* This file is part of SardezExer1a.
*
* SardezExer1a is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* SardezExer1a is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License.
* If not, see <http://www.gnu.org/licenses/>
*/

using System;
using System.Windows.Forms;
using SardezExer1a.Common;
using SardezExer1a.Stack;

namespace SardezExer1a.Forms
{
    /// <summary>
    ///     frmSardezExer1a Form.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly InputBox _inputBox;
        private readonly Logger _logger;
        private readonly MyStack<string> _myStack;

        /// <summary>
        ///     Initialize frmSardezExer1a.
        /// </summary>
        /// <param name="logger">Logger instance.</param>
        /// <param name="myStack">MyStack instance.</param>
        /// <param name="inputBox">InputBox instance.</param>
        public MainForm(Logger logger, MyStack<string> myStack, InputBox inputBox)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
            if (logger == null)
                throw new ArgumentNullException(nameof(myStack), "MyStack instance provided is null.");
            if (logger == null)
                throw new ArgumentNullException(nameof(inputBox), "InputBox instance provided is null.");

            InitializeComponent();

            // Assign dependencies
            _logger = logger;
            _myStack = myStack;
            _inputBox = inputBox;

            // Assign event handlers
            _logger.OnMessageLogged += _logger_OnMessageLogged;
            _myStack.OnStackAction += _myStack_OnStackAction;

            // Update status and log info
            UpdateStatusBar();
            _logger.LogInfo(GetType().Name, "SardezExer1a application successfully started.");
        }

        /// <summary>
        ///     Add kitchenware event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnAddKitchenware_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    _inputBox.ShowDialog("Add Kitchenware", "Name") == DialogResult.OK)
                {
                    _myStack.Push(InputBox.ResultValue);
                    string message = $"Kitchenware {InputBox.ResultValue} was successfully added.";
                    _logger.LogInfo(GetType().Name, message);
                    MessageBox.Show(message, "Add Kitchenware", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(GetType().Name, exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Wash kitchenware event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnWashKitchenware_Click(object sender, EventArgs e)
        {
            try
            {
                string item = _myStack.Pop();
                string message = $"{item} is being washed.";
                _logger.LogInfo(GetType().Name, message);
                MessageBox.Show(message, "Wash Kitchenware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(GetType().Name, exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Top kitchenware event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnTopKitchenware_Click(object sender, EventArgs e)
        {
            try
            {
                string item = _myStack.Peek();
                string message = $"{item} is on the top.";
                _logger.LogInfo(GetType().Name, message);
                MessageBox.Show(message, "Top Kitchenware", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(GetType().Name, exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Wash all kitchenware event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnWashAll_Click(object sender, EventArgs e)
        {
            try
            {
                _myStack.Clear();
                string message = $"All Kitchenwares were successfully washed.";
                _logger.LogInfo(GetType().Name, message);
                MessageBox.Show(message, "Wash All", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(GetType().Name, exception.Message);
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
        /// <param name="message">Message logged</param>
        private void _logger_OnMessageLogged(string message)
        {
            txtEvents.AppendText($"{message}{Environment.NewLine}");
        }

        /// <summary>
        ///     OnStackAction event handler.
        /// </summary>
        /// <param name="action">Action made.</param>
        private void _myStack_OnStackAction(string action)
        {
            UpdateStatusBar();
        }

        /// <summary>
        ///     Update the status bar.
        /// </summary>
        private void UpdateStatusBar()
        {
            tsSize.Text = $"Size (Capacity): {_myStack.Size}";
            tsTop.Text = $"Top Position: {_myStack.Top}";
            tsLastAction.Text = $"Last Action: {_myStack.LastAction}";
            txtArrayItems.Clear();
            foreach (var item in _myStack.GetItems())
            {
                txtArrayItems.AppendText($"[{item.Key}] = {item.Value}{Environment.NewLine}");
            }
        }
    }
}