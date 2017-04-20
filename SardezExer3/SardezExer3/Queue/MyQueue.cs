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
using SardezExer3.Common;

namespace SardezExer3.Queue
{
    /// <summary>
    ///     My queue implementation using linked list.
    /// </summary>
    /// <typeparam name="T">Item type.</typeparam>
    public class MyQueue<T>
    {
        public delegate void QueueAction(string action);

        private readonly Logger _logger;

        /// <summary>
        ///     Creates a new instance of MyQueue.
        /// </summary>
        /// <param name="logger">Logger object.</param>
        public MyQueue(Logger logger)
        {
            try
            {
                if (logger == null)
                    throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
                _logger = logger;
                _logger.LogInfo(GetSourceName(), "MyQueue initialization started.");
                Size = 0;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action("Queue Initialization");
                _logger.LogInfo(GetSourceName(), "MyQueue initialization ended.");
            }
        }

        /// <summary>
        ///     Gets the head of the queue.
        /// </summary>
        public MyNode<T> Head { get; private set; }

        /// <summary>
        ///     Gets the tail of the queue.
        /// </summary>
        public MyNode<T> Tail { get; private set; }

        /// <summary>
        ///     Gets the size of the queue
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        ///     Gets the last action done in the queue.
        /// </summary>
        public string LastAction { get; private set; }

        public event QueueAction OnQueueAction;


        /// <summary>
        ///     Enqueue an item.
        /// </summary>
        /// <param name="item">Person object.</param>
        public void Enqueue(T item)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Enqueue item {item} started.");
                MyNode<T> node = MyNode<T>.Create(item);
                if (Head == null)
                {
                    Head = node;
                    _logger.LogInfo(GetSourceName(), $"Node of the item {Head.Data} was set as the head of the queue.");
                    Tail = node;
                }
                else
                {
                    Tail.Next = node;
                    Tail = node;
                }
                Size++;
                _logger.LogInfo(GetSourceName(),
                    $"Node of the item {item} was enqueued and set as the tail of the queue.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Enqueue));
                _logger.LogInfo(GetSourceName(), $"Enqueue item {item} ended.");
            }
        }

        /// <summary>
        ///     Dequeue an item.
        /// </summary>
        /// <returns>Person object.</returns>
        public T Dequeue()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Dequeue an item started.");
                return DequeueOrPeek(true);
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Dequeue));
                _logger.LogInfo(GetSourceName(), "Dequeue an item ended.");
            }
        }

        /// <summary>
        ///     Peek an item.
        /// </summary>
        /// <returns>Person object.</returns>
        public T Peek()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Peek an item started.");
                return DequeueOrPeek(false);
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Peek));
                _logger.LogInfo(GetSourceName(), "Peek an item ended.");
            }
        }

        /// <summary>
        ///     Dequeue or peek an item.
        /// </summary>
        /// <param name="dequeue">Determines if the action is a dequeue or not.</param>
        /// <returns>Person object.</returns>
        private T DequeueOrPeek(bool dequeue)
        {
            if (Head == null)
                throw new InvalidOperationException("Queue is empty.");
            MyNode<T> node = Head;
            _logger.LogInfo(GetSourceName(),
                $"Node of the item {node.Data} was found at the head of the queue and will be returned to the caller.");
            if (dequeue)
            {
                _logger.LogInfo(GetSourceName(), $"Node of the item {Head.Data} will be removed from the queue.");
                Head = Head.Next;
                Size--;
                if (Head != null)
                    _logger.LogInfo(GetSourceName(), $"Node of the item {Head.Data} was set as the head of the queue.");
                else
                    Tail = null;
            }
            return node.Data;
        }

        /// <summary>
        ///     Clear all items from the queue.
        /// </summary>
        public void Clear()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Clear the queue started.");
                Head = null;
                Tail = null;
                Size = 0;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Clear));
                _logger.LogInfo(GetSourceName(), "Clear the queue ended.");
            }
        }

        /// <summary>
        ///     Get the queue's node data items.
        /// </summary>
        /// <returns>Queue's node data items in dictionary.</returns>
        public Dictionary<int, T> GetItems()
        {
            Dictionary<int, T> result = new Dictionary<int, T>();
            MyNode<T> node = Head;
            int index = 1;
            while (node != null)
            {
                result.Add(index++, node.Data);
                node = node.Next;
            }
            return result;
        }

        /// <summary>
        /// Gets the source name for logging.
        /// </summary>
        /// <returns>The source name.</returns>
        private string GetSourceName()
        {
            return $"MyQueue<{typeof(T).Name}>";
        }

        /// <summary>
        ///     Sets the last action made and broadcast to subscribers.
        /// </summary>
        /// <param name="action">The action.</param>
        private void Action(string action)
        {
            LastAction = action;
            OnQueueAction?.Invoke(action);
        }
    }
}