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

namespace SardezExer2.BST
{
    /// <summary>
    ///     BST's search result object.
    /// </summary>
    /// <typeparam name="T">A value type.</typeparam>
    public class MyBSTSearchResult<T> where T : struct
    {
        /// <summary>
        ///     Creates a new instance of MyBSTSearchResult.
        /// </summary>
        /// <param name="found">Intidacte if the searched node was found.</param>
        /// <param name="node">The found searched node.</param>
        /// <param name="leftSearched">Indicate if the the node was found from its parent's left.</param>
        private MyBSTSearchResult(bool found, MyNode<T> node, bool leftSearched)
        {
            Found = found;
            Node = node;
            LeftSearched = leftSearched;
        }

        /// <summary>
        ///     Gets or sets if searched node was found.
        /// </summary>
        public bool Found { get; private set; }

        /// <summary>
        ///     Gets or sets the found searched node.
        /// </summary>
        public MyNode<T> Node { get; private set; }

        /// <summary>
        ///     Gets or sets if the the node was found from its parent's left.
        /// </summary>
        public bool LeftSearched { get; private set; }

        /// <summary>
        ///     Creates a new instance of MyBSTSearchResult.
        /// </summary>
        /// <param name="found">Intidacte if the searched node was found.</param>
        /// <param name="node">The found searched node.</param>
        /// <param name="leftSearched">Indicate if the the node was found from its parent's left.</param>
        /// <returns>MyBSTSearchResult object.</returns>
        public static MyBSTSearchResult<T> Create(bool found, MyNode<T> node, bool leftSearched)
        {
            return new MyBSTSearchResult<T>(found, node, leftSearched);
        }
    }
}