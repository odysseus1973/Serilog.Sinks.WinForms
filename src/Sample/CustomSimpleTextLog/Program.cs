﻿using System;
using System.Windows.Forms;
using Serilog;
using Serilog.Sinks.WinForms.Base;

namespace CustomSimpleTextLog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                        .WriteToSimpleAndRichTextBox()
                        .CreateLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}