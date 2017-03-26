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

namespace SardezExer1b.Entities
{
    /// <summary>
    ///     Person object.
    /// </summary>
    public class Person
    {
        /// <summary>
        ///     Create a new instance of Person.
        /// </summary>
        /// <param name="name">Name of the person.</param>
        /// <param name="order">Order of the person.</param>
        private Person(string name, string order)
        {
            Name = name;
            Order = order;
        }

        /// <summary>
        ///     Gets the name of the person.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Gets the order of the person.
        /// </summary>
        public string Order { get; }

        /// <summary>
        ///     Returns a new instance of Person.
        /// </summary>
        /// <param name="name">Name of the person.</param>
        /// <param name="order">Order of the person.</param>
        /// <returns>Person object.</returns>
        public static Person Create(string name, string order)
        {
            return new Person(name, order);
        }

        /// <summary>
        ///     Returns the person details in JSON.
        /// </summary>
        /// <returns>Person in JSON format.</returns>
        public override string ToString()
        {
            return $"{{\"Name\":\"{Name}\",\"Order\":\"{Order}\"}}";
        }
    }
}