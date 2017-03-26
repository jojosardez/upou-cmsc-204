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

namespace SardezExer2.Common
{
    /// <summary>
    ///     Logger implementation.
    /// </summary>
    public class Logger
    {
        public delegate void MessageLogged(string message);

        public event MessageLogged OnMessageLogged;

        /// <summary>
        ///     Log an information message.
        /// </summary>
        /// <param name="source">Source component.</param>
        /// <param name="message">Log message.</param>
        public void LogInfo(string source, string message)
        {
            Log("INFO", source, message);
        }

        /// <summary>
        ///     Log an error.
        /// </summary>
        /// <param name="source">Source component.</param>
        /// <param name="e">Exception object.</param>
        public void LogError(string source, Exception e)
        {
            LogError(source, e.ToString());
        }

        /// <summary>
        ///     Log an error.
        /// </summary>
        /// <param name="source">Source component.</param>
        /// <param name="errorMessage">Error message.</param>
        public void LogError(string source, string errorMessage)
        {
            Log("ERROR", source, errorMessage);
        }

        /// <summary>
        ///     Log a message.
        /// </summary>
        /// <param name="level">Log level.</param>
        /// <param name="source">Source component.</param>
        /// <param name="message">Message.</param>
        private void Log(string level, string source, string message)
        {
            OnMessageLogged?.Invoke($"[{DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss")}|{level}|{source}]: {message}");
        }
    }
}