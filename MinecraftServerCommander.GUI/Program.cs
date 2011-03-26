/*
 * Copyright (C) 2011 by Adam Hellberg
 * 
 * This file is part of Minecraft Server Commander.
 *
 * Minecraft Server Commander is free software: you can redistribute it
 * and/or modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * Minecraft Server Commander is distributed in the hope that it
 * will be useful, but WITHOUT ANY WARRANTY; without even the implied
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with Minecraft Server Commander.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.IO;
using System.Windows.Forms;
using MinecraftServerCommander.Library;

namespace MinecraftServerCommander.GUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			AppDomain.CurrentDomain.UnhandledException += MscUnhandledException;
			Logger.Notice("New instance started.");
			if (!File.Exists("msclib.dll"))
			{
				MessageBox.Show(@"Error: msclib.dll not found, exiting.", @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				//We can't use logger to log this since msclib.dll is missing!
				Environment.Exit(1);
			}
			if (!File.Exists("SharpZipLib.dll"))
			{
				MessageBox.Show(@"Error: SharpZipLib.dll not found, exiting.", @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Logger.Error("SharpZipLib.dll not found, exiting.");
				Environment.Exit(1);
			}
			if (!File.Exists("items.txt"))
			{
				MessageBox.Show(@"Error: items.txt not found, exiting.", @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Logger.Error("items.txt not found, exiting.");
				Environment.Exit(1);
			}
			string servPath = null;
			if (args.Length > 0)
			{
				foreach (var value in args)
				{
					if (value == "-debug")
						Logger.SetDebug(true);
					else
						servPath = value;
				}
			}
			Logger.SetDebug(false);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(!string.IsNullOrEmpty(servPath) ? new MscForm(servPath) : new MscForm());
		}

		static void MscUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			try
			{
				var ex = (Exception) e.ExceptionObject;
				// If there is an old log present, delete it.
				// Note: If it is unable to delete, create or write to the file and
				//       throws an exception the application will just exit.
				if (File.Exists("msc_fatal.log"))
					File.Delete("msc_fatal.log");
				using (File.Create("msc_fatal.log")) { }
				File.WriteAllText("msc_fatal.log", @"Unhandled exception occurred in "
								+ ex.Source + Environment.NewLine + Environment.NewLine + @"Exception: "
								+ ex.GetType() + Environment.NewLine + ex.Message + Environment.NewLine
								+ ex.StackTrace
				);
				// Show a message box to the user with information.
				string msg = string.Empty;
				msg += "FATAL: Unhandled exception occurred in: {0}\nProgram is unable to continue.\n\n";
				msg += "Please contact us with the following information:\n";
				msg += "What were you doing when this error occurred?\n\nPlease see msc_fatal.log for more detailed info.\n\nException: {1}\n{2}\n\n";
				msg += "Contact email: support@f16gaming.com, please include the log files.";
				MessageBox.Show(string.Format(msg, ex.Source, ex.GetType(), ex.Message), @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			finally
			{
				//TODO: "Official" exit codes?
				Environment.Exit(2);
			}
		}
	}
}
