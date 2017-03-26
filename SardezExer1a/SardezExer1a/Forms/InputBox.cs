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

namespace SardezExer1a.Forms
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
            _logger.LogInfo(GetType().Name, "InputBox was initialized.");
        }

        /// <summary>
        ///     Gets the result value.
        /// </summary>
        public static string ResultValue { get; private set; }

        /// <summary>
        ///     Shows the form as a modal dialog box.
        /// </summary>
        /// <param name="title">Title of the dialog.</param>
        /// <param name="message">Message of the dialog.</param>
        /// <returns>DialogResult value.</returns>
        public DialogResult ShowDialog(string title, string message)
        {
            Text = title;
            lblMessage.Text = message;
            ResultValue = string.Empty;
            txtValue.ResetText();
            txtValue.Select();
            _logger.LogInfo(GetType().Name, "InputBox was shown.");
            return ShowDialog();
        }

        /// <summary>
        ///     OK button event handler.
        /// </summary>
        /// <param name="sender">Object object.</param>
        /// <param name="e">EventArgs object.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValue.Text))
            {
                ResultValue = txtValue.Text.Trim();
                DialogResult = DialogResult.OK;
                _logger.LogInfo(GetType().Name, $"Input was OK. ResultValue was set to {ResultValue}.");
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
            _logger.LogInfo(GetType().Name, "Input was cancelled.");
            Close();
        }
    }
}