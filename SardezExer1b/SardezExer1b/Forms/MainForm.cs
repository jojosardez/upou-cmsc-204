/*************************************************************************
* SardezExer1b - QUEUES: A Queue + Linked List Implementation for CMSC 204: EXERCISE 1
* Student ID: 2016-30105
* Name: Sardez, Angelito Jr. Ortiz
* Master of Information Systems Student
* University of the Philippines - Open University
*
* Copyright (C) 2017 Angelito (Jojo) O. Sardez, Jr.
* This file is part of SardezExer1b.
*
* SardezExer1b is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* SardezExer1b is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License.
* If not, see <http://www.gnu.org/licenses/>
*/

using System;
using System.Windows.Forms;
using SardezExer1b.Common;
using SardezExer1b.Entities;
using SardezExer1b.Queue;

namespace SardezExer1b.Forms
{
    /// <summary>
    ///     frmSardezExer1b Form.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly InputBox _inputBox;
        private readonly Logger _logger;
        private readonly MyQueue<Person> _myQueue;

        /// <summary>
        ///     Initialize frmSardezExer1b.
        /// </summary>
        /// <param name="logger">Logger instance.</param>
        /// <param name="myQueue">MyQueue instance.</param>
        /// <param name="inputBox">InputBox instance.</param>
        public MainForm(Logger logger, MyQueue<Person> myQueue, InputBox inputBox)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
            if (logger == null)
                throw new ArgumentNullException(nameof(myQueue), "MyQueue instance provided is null.");
            if (logger == null)
                throw new ArgumentNullException(nameof(inputBox), "InputBox instance provided is null.");

            InitializeComponent();

            // Assign dependencies
            _logger = logger;
            _myQueue = myQueue;
            _inputBox = inputBox;

            // Assign event handlers
            _logger.OnMessageLogged += _logger_OnMessageLogged;
            _myQueue.OnQueueAction += _myQueue_OnQueueAction;

            // Update status and log info
            _logger.LogInfo(nameof(MainForm), "SardezExer1b application successfully started.");
            UpdateStatusBar();
        }

        /// <summary>
        ///     Fall in line event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnFallInLine_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    _inputBox.ShowDialog("Fall in line",
                        "Please specify the name of the person:", "Please specify the order of the person:") ==
                    DialogResult.OK)
                {
                    Person item = Person.Create(InputBox.ResultValue1, InputBox.ResultValue2);
                    _myQueue.Enqueue(item);
                    string message = $"Person named {InputBox.ResultValue1} was successfully enqueued.";
                    _logger.LogInfo(nameof(MainForm), message);
                    MessageBox.Show(message, "Fall in line", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Get order event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Person item = _myQueue.Dequeue();
                string message =
                    $"Person's order: {item.Order}. Person named {item.Name} was just removed from the queue.";
                _logger.LogInfo(nameof(MainForm), message);
                MessageBox.Show(message, "Get order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Get name event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnGetName_Click(object sender, EventArgs e)
        {
            try
            {
                Person item = _myQueue.Peek();
                string message = $"Person named {item.Name} was found in front of the queue";
                _logger.LogInfo(nameof(MainForm), message);
                MessageBox.Show(message, "Get name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                _logger.LogError(nameof(MainForm), exception.Message);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Closing time event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnClosingTime_Click(object sender, EventArgs e)
        {
            try
            {
                _myQueue.Clear();
                string message = $"All persons were removed from the queue.";
                _logger.LogInfo(nameof(MainForm), message);
                MessageBox.Show(message, "Closing time", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        ///     OnQueueAction event handler.
        /// </summary>
        /// <param name="action">Action made.</param>
        private void _myQueue_OnQueueAction(string action)
        {
            UpdateStatusBar();
        }

        /// <summary>
        ///     Update the status bar.
        /// </summary>
        private void UpdateStatusBar()
        {
            tsSize.Text = $"Size: {_myQueue.Size}";
            tsHead.Text = $"Head's Data: {_myQueue.Head?.Data}";
            tsTail.Text = $"Tail's Data: {_myQueue.Tail?.Data}";
            tsLastAction.Text = $"Last Action: {_myQueue.LastAction}";
            txtQueueItems.Clear();
            foreach (var item in _myQueue.GetItems())
            {
                txtQueueItems.AppendText($"[{item.Key}] = {item.Value}{Environment.NewLine}");
            }
        }
    }
}