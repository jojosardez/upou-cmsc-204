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
            //Test();

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

        private static void Test()
        {
            Logger log = new Logger();
            log.OnMessageLogged += Log_OnMessageLogged;
            MyBST<int> tree = new MyBST<int>(log);
            tree.Insert(5);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(1);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(10);
            tree.Remove(5);
            tree.Insert(8);
            tree.Insert(4);
            tree.Remove(7);
            tree.Remove(2);
            tree.Remove(6);
            tree.Remove(8);
            tree.Insert(20);
            tree.Insert(15);
            tree.Insert(25);
            tree.Insert(30);
            tree.Insert(13);
            tree.Insert(17);
            tree.Insert(12);
            tree.Insert(14);
            tree.Insert(16);
            tree.Remove(20);
            tree.Remove(10);
            tree.Remove(15);
            tree.Remove(4);
            tree.Insert(7);
            tree.Insert(5);
            tree.Insert(9);
            tree.Remove(3);
            tree.Remove(12);
            tree.Insert(27);
            tree.Insert(28);
            tree.Remove(25);
            tree.Insert(31);
            tree.Remove(27);
            tree.Insert(6);
            tree.Remove(5);
            tree.Remove(6);
            tree.Remove(9);
            tree.Insert(11);
            tree.Insert(12);
            tree.Insert(8);
            tree.Insert(9);
            tree.Remove(7);
        }

        private static void Log_OnMessageLogged(string message)
        {
           Debug.WriteLine(message);
        }
    }
}