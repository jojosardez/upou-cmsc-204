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

namespace SardezExer3.Stack
{
    /// <summary>
    ///     My stack implementation using an array.
    /// </summary>
    /// <typeparam name="T">Item type.</typeparam>
    public class MyStack<T>
    {
        public delegate void StackAction(string action);

        private readonly Logger _logger;
        private T[] _array;

        /// <summary>
        ///     Initialize the stack with a given initial size and Logger instance.
        /// </summary>
        /// <param name="logger">Logger instance.</param>
        public MyStack(Logger logger)
        {
            try
            {
                if (logger == null)
                    throw new ArgumentNullException(nameof(logger), "Logger instance provided is null.");
                _logger = logger;
                _logger.LogInfo(GetSourceName(), "MyStack initialization started.");
                Size = 10;
                _logger = logger;
                _array = new T[Size];
                Top = -1;
                _logger.LogInfo(GetSourceName(), $"MyStack was initialized with size of {Size}.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action("Stack Initialization");
                _logger.LogInfo(GetSourceName(), "MyStack initialization ended.");
            }
        }

        /// <summary>
        ///     Gets the current array size.
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        ///     Gets the current top position.
        /// </summary>
        public int Top { get; private set; }

        /// <summary>
        ///     Gets the last action done in the stack.
        /// </summary>
        public string LastAction { get; private set; }

        public event StackAction OnStackAction;

        /// <summary>
        ///     Push an item to the stack.
        /// </summary>
        /// <param name="item">Item to be pushed.</param>
        public void Push(T item)
        {
            try
            {
                _logger.LogInfo(GetSourceName(), $"Push item {item} started.");
                if (Top == Size - 1)
                {
                    _logger.LogInfo(GetSourceName(), "Top reached the array's capacity. The array will be resized.");
                    Size = Size*2;
                    T[] newArray = new T[Size];
                    Array.Copy(_array, 0, newArray, 0, _array.Length);
                    _array = newArray;
                    _logger.LogInfo(GetSourceName(),
                        $"The array was successfully resized. The new array capacity is now {Size}.");
                }
                Top++;
                _array[Top] = item;
                _logger.LogInfo(GetSourceName(), $"Item {item} was assigned to array index {Top}.");
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Push));
                _logger.LogInfo(GetSourceName(), $"Push item {item} ended.");
            }
        }

        /// <summary>
        ///     Pop last item from the stack.
        /// </summary>
        /// <returns>Popped item.</returns>
        public T Pop()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Pop an item started.");
                return PopOrPeek(true);
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Pop));
                _logger.LogInfo(GetSourceName(), "Pop an item ended.");
            }
        }

        /// <summary>
        ///     Peek last item from the stack.
        /// </summary>
        /// <returns>Peeked item.</returns>
        public T Peek()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Peek an item started.");
                return PopOrPeek(false);
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
        ///     Pop or peek last item from the stack.
        /// </summary>
        /// <param name="pop">Determines if the item should be popped.</param>
        /// <returns>Popped or peeked item.</returns>
        private T PopOrPeek(bool pop)
        {
            if (Top == -1)
                throw new InvalidOperationException("Stack is empty.");
            T item = _array[Top];
            _logger.LogInfo(GetSourceName(),
                $"Item {item} at array index {Top} was found and will be returned to the caller.");
            if (pop)
            {
                _logger.LogInfo(GetSourceName(), $"Item {item} at array index {Top} will be removed from the array.");
                _array[Top] = default(T);
                Top--;
            }
            return item;
        }

        /// <summary>
        ///     Clear all items from the stack.
        /// </summary>
        public void Clear()
        {
            try
            {
                _logger.LogInfo(GetSourceName(), "Clear the stack's array started.");
                Array.Clear(_array, 0, Size);
                Top = -1;
            }
            catch (Exception e)
            {
                _logger.LogError(GetSourceName(), e);
                throw;
            }
            finally
            {
                Action(nameof(Clear));
                _logger.LogInfo(GetSourceName(), "Clear the stack's array ended.");
            }
        }

        /// <summary>
        ///     Get the stack's array items.
        /// </summary>
        /// <returns>Stack's array item in dictionary.</returns>
        public Dictionary<int, T> GetItems()
        {
            Dictionary<int, T> result = new Dictionary<int, T>();
            for (int index = 0; index <= Top; index++)
            {
                result.Add(index, _array[index]);
            }
            return result;
        }

        /// <summary>
        /// Gets the source name for logging.
        /// </summary>
        /// <returns>The source name.</returns>
        private string GetSourceName()
        {
            return $"MyStack<{typeof(T).Name}>";
        }

        /// <summary>
        ///     Sets the last action made and broadcast to subscribers.
        /// </summary>
        /// <param name="action">The action.</param>
        private void Action(string action)
        {
            LastAction = action;
            OnStackAction?.Invoke(action);
        }
    }
}