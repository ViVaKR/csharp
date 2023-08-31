﻿using System;
using System.Windows.Forms;

namespace J_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm
            {
                WindowState = FormWindowState.Maximized
            });
        }
    }
}
