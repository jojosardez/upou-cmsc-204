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

namespace SardezExer3.Queue
{
    /// <summary>
    ///     Linked list's node.
    /// </summary>
    public class MyNode<T>
    {
        /// <summary>
        ///     Creates a new instance of node.
        /// </summary>
        /// <param name="data">Data instance.</param>
        private MyNode(T data)
        {
            Data = data;
        }

        /// <summary>
        ///     Gets the node data.
        /// </summary>
        public T Data { get; private set; }

        /// <summary>
        ///     Gets or sets the next node.
        /// </summary>
        public MyNode<T> Next { get; set; }

        /// <summary>
        ///     Creates a new instance of node.
        /// </summary>
        /// <param name="data">Data instance.</param>
        /// <returns>Node instance.</returns>
        public static MyNode<T> Create(T data)
        {
            return new MyNode<T>(data);
        }
    }
}