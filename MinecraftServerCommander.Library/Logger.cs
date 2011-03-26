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

namespace MinecraftServerCommander.Library
{
	public static class Logger
	{
		private static bool _debug;
		private static bool _debugSet = true;

		public static void SetDebug(bool state)
		{
			if (!_debugSet)
			{
				_debug = state;
				_debugSet = true;
			}
			else
			{
				Error("Tried to set Logger._debug after it has been initially set.");
				throw new FieldAccessException("Access to _debug field is prohibited after inital assignment.");
			}
		}

		private static void CheckFile()
		{
			if (!File.Exists(string.Format("msc_{0}.log", DateTime.Now.ToString("d-M-yyyy"))))
				using (File.Create(string.Format("msc_{0}.log", DateTime.Now.ToString("d-M-yyyy")))) { }
		}

		private static void FileWrite(string message)
		{
			var logFile = new StreamWriter(string.Format("msc_{0}.log", DateTime.Now.ToString("d-M-yyyy")), true);
			logFile.WriteLine(string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm:ss"), message));
			logFile.Close();
		}

		public static void Debug(string message)
		{
			if (_debug)
			{
				CheckFile();
				FileWrite(string.Format("[Debug] {0}", message));
			}
		}

		public static void Notice(string message)
		{
			CheckFile();
			FileWrite(string.Format("[Notice] {0}", message));
		}

		public static void Warning(string message)
		{
			CheckFile();
			FileWrite(string.Format("[Warning] {0}", message));
		}

		public static void Error(string message)
		{
			CheckFile();
			FileWrite(string.Format("[Error] {0}", message));
		}
	}
}
