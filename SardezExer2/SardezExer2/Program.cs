/*************************************************************************
* SardezExer2 - BST: A Binary Search Tree Implementation for CMSC 204: EXERCISE 2
* Student ID: 2016-30105
* Name: Sardez, Angelito Jr. Ortiz
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
using System.Diagnostics;
using System.Windows.Forms;
using SardezExer2.BST;
using SardezExer2.Common;
using SardezExer2.Forms;

namespace SardezExer2
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(Container.Instance.Resolve<MainForm>());
        }

        /// <summary>
        ///     Reigter instances for type for dependency injection.
        /// </summary>
        private static void Bootstrap()
        {
            Container.Instance.RegisterType<Logger>();
            Container.Instance.RegisterType<MyBST<int>>();
            Container.Instance.RegisterType<InputBox>();
            Container.Instance.RegisterType<MainForm>();
        }
    }
}