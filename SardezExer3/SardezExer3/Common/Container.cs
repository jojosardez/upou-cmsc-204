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
using System.Linq;
using System.Reflection;

namespace SardezExer3.Common
{
    /// <summary>
    ///     My dependency injection container.
    /// </summary>
    public class Container
    {
        private static Container _instance;
        private static Dictionary<Type, object> _container;

        /// <summary>
        ///     Initialize the container.
        /// </summary>
        private Container()
        {
            _container = new Dictionary<Type, object>();
        }

        /// <summary>
        ///     Returns the singeton instance of the container.
        /// </summary>
        public static Container Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Container();
                return _instance;
            }
        }

        /// <summary>
        ///     Register an instance of a type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="instance">The instance.</param>
        public void RegisterInstance<T>(T instance)
        {
            _container.Remove(typeof (T));
            _container.Add(typeof (T), instance);
        }

        /// <summary>
        ///     Registers a type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        public void RegisterType<T>()
        {
            RegisterInstance((T) Activator.CreateInstance(typeof (T), GetInstanceDependencies<T>()));
        }

        /// <summary>
        ///     Gets the instances of the dependencies in the container.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>Array of instances of dependencies.</returns>
        private object[] GetInstanceDependencies<T>()
        {
            Dictionary<Type, object> dependencies = new Dictionary<Type, object>();
            foreach (ConstructorInfo constructor in typeof (T).GetConstructors())
            {
                foreach (ParameterInfo parameter in constructor.GetParameters())
                {
                    if (!dependencies.ContainsKey(parameter.ParameterType)
                        && Resolve(parameter.ParameterType) != null)
                        dependencies.Add(parameter.ParameterType, Resolve(parameter.ParameterType));
                }
            }
            return dependencies.Values.ToArray();
        }

        /// <summary>
        ///     Resolve a type's instance from the container.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The instance.</returns>
        public T Resolve<T>()
        {
            return (T) Resolve(typeof (T));
        }

        /// <summary>
        ///     Resolve a type's instance from the container.
        /// </summary>
        /// <param name="t">The type.</param>
        /// <returns>The instance.</returns>
        public object Resolve(Type t)
        {
            return _container[t];
        }
    }
}