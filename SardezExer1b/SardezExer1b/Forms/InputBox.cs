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

namespace SardezExer1b.Forms
{
    /// <summary>
    ///     frmInputBox form.
    /// </summary>
    public partial class InputBox : Form
    {
        private readonly Logger _logger;

        /// <summary>
        ///     Initialize frmInputBox.
        /// </summary>
        public InputBox(Logger logger)
        {
            InitializeComponent();

            // Assign dependencies
            _logger = logger;
            _logger.LogInfo(nameof(InputBox), "InputBox was initialized.");
        }

        /// <summary>
        ///     Gets the result value 1.
        /// </summary>
        public static string ResultValue1 { get; private set; }

        /// <summary>
        ///     Gets the result value 2.
        /// </summary>
        public static string ResultValue2 { get; private set; }

        /// <summary>
        ///     Shows the form as a modal dialog box.
        /// </summary>
        /// <param name="title">Title of the dialog.</param>
        /// <param name="message1">Message 1 of the dialog.</param>
        /// <param name="message2">Message 2 of the dialog.</param>
        /// <returns>DialogResult value.</returns>
        public DialogResult ShowDialog(string title, string message1, string message2)
        {
            Text = title;
            lblMessage1.Text = message1;
            lblMessage2.Text = message2;
            ResultValue1 = string.Empty;
            ResultValue2 = string.Empty;
            txtValue1.ResetText();
            txtValue2.ResetText();
            txtValue1.Select();
            _logger.LogInfo(nameof(InputBox), "InputBox was shown.");
            return ShowDialog();
        }

        /// <summary>
        ///     OK button event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValue1.Text) && !string.IsNullOrEmpty(txtValue2.Text))
            {
                ResultValue1 = txtValue1.Text.Trim();
                ResultValue2 = txtValue2.Text.Trim();
                DialogResult = DialogResult.OK;
                _logger.LogInfo(nameof(InputBox),
                    $"Input was OK. ResultValue1 was set to {ResultValue1} and ResultValue2 was set to {ResultValue2}.");
                Close();
            }
        }

        /// <summary>
        ///     Cancel button event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            _logger.LogInfo(nameof(InputBox), "Input was cancelled.");
            Close();
        }
    }
}